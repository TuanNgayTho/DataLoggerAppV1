using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using LiveCharts;
using LiveCharts.Geared;
using MySql.Data.MySqlClient;
using Winforms.Cartesian.ConstantChanges;

namespace Geared.Winforms.SpeedTest
{
    public class TruyXuat
    {
        private double _trend;
        float[] value = new float[86400];
        float[] value1 = new float[86400];
        float[] value2 = new float[86400];
        float[] value3 = new float[86400];
        float[] value4 = new float[86400];
        float[] value5 = new float[86400];
        float[] value6 = new float[86400];
        float[] value7 = new float[86400];
        int temp;
        string[] ts= new string[86400];
        DateTime temptime;
        public System.DateTime DateTime { get; set; }
        public TruyXuat()
        {
            // DateTime = new DateTime();
            Values = new GearedValues<double>().WithQuality(Quality.Low);
            Values1 = new GearedValues<double>().WithQuality(Quality.Low);
            Values2 = new GearedValues<double>().WithQuality(Quality.Low);
            Values3 = new GearedValues<double>().WithQuality(Quality.Low);
            Values4 = new GearedValues<double>().WithQuality(Quality.Low);
            Values5 = new GearedValues<double>().WithQuality(Quality.Low);
            Values6 = new GearedValues<double>().WithQuality(Quality.Low);
            Values7 = new GearedValues<double>().WithQuality(Quality.Low);
        }

        public bool IsReading { get; set; }
        public GearedValues<double> Values { get; set; }
        public GearedValues<double> Values1 { get; set; }
        public GearedValues<double> Values2 { get; set; }
        public GearedValues<double> Values3 { get; set; }
        public GearedValues<double> Values4 { get; set; }
        public GearedValues<double> Values5 { get; set; }
        public GearedValues<double> Values6 { get; set; }
        public GearedValues<double> Values7 { get; set; }

        public double Count { get; set; }
        public double CurrentLecture { get; set; }
        public bool IsHot { get; set; }

        public void Stop()
        {
            IsReading = false;
        }

        public void Clear()
        {
            Values.Clear();
            Values1.Clear();
            Values2.Clear();
            Values3.Clear();
            Values4.Clear();
            Values5.Clear();
            Values6.Clear();
            Values7.Clear();
        }

        public void Read(List<String>times1,String Day1,String Day2)
        {

            
            if (IsReading) return;

            //lets keep in memory only the last 20000 records,
            //to keep everything running faster
            const int keepRecords = 86400;
            IsReading = true;

            //while (IsReading)
            //{
               // Thread.Sleep(1);


                try
                {
                    DateTime enteredDate;
                    string server = "localhost";
                    string database = "datalogger";
                    string uid = "root";
                    string password = "root";
                    string constring = "server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

                    MySqlConnection con = new MySqlConnection(constring);
                    con.Open();


                    var query = "select * from samples WHERE ts >='" + Day1 + "' AND ts <='" + Day2 + "'";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {


                    value[temp] = Convert.ToInt32(float.Parse(reader["aivalue0"].ToString()) * 100) / 100F;
                    value1[temp] = Convert.ToInt32(float.Parse(reader["aivalue1"].ToString()) * 100) / 100F;
                    value2[temp] = Convert.ToInt32(float.Parse(reader["aivalue2"].ToString()) * 100) / 100F;
                    value3[temp] = Convert.ToInt32(float.Parse(reader["aivalue3"].ToString()) * 100) / 100F;
                    value4[temp] = Convert.ToInt32(float.Parse(reader["aivalue4"].ToString()) * 100) / 100F;
                    value5[temp] = Convert.ToInt32(float.Parse(reader["aivalue5"].ToString()) * 100) / 100F;
                    value6[temp] = Convert.ToInt32(float.Parse(reader["aivalue6"].ToString()) * 100) / 100F;
                    value7[temp] = Convert.ToInt32(float.Parse(reader["aivalue7"].ToString()) * 100) / 100F;
                    //System.Windows.MessageBox.Show("ok");
                    ts[temp] = reader["ts"].ToString();

                    temp++;
                }

                
                //var first = Values.DefaultIfEmpty(0).FirstOrDefault();
                //var first1 = Values1.DefaultIfEmpty(0).FirstOrDefault();
                //var first2 = Values2.DefaultIfEmpty(0).FirstOrDefault();
                //var first3 = Values3.DefaultIfEmpty(0).FirstOrDefault();
                //var first4 = Values4.DefaultIfEmpty(0).FirstOrDefault();
                //var first5 = Values5.DefaultIfEmpty(0).FirstOrDefault();
                //var first6 = Values6.DefaultIfEmpty(0).FirstOrDefault();
                //var first7 = Values7.DefaultIfEmpty(0).FirstOrDefault();
                //if (Values.Count > keepRecords - 1)
                //{
                //    times1.RemoveAt(0);
                //    Values.Remove(first);
                //    Values1.Remove(first1);
                //    Values2.Remove(first2);
                //    Values3.Remove(first3);
                //    Values4.Remove(first4);
                //    Values5.Remove(first5);
                //    Values6.Remove(first6);
                //    Values7.Remove(first7);

                //}
                for(int i = 0; i<=86400;i++)
                {
                    times1.Add(ts[i]);
                    Values.Add(double.Parse(value[i].ToString()));
                    Values1.Add(double.Parse(value1[i].ToString()));
                    Values2.Add(double.Parse(value2[i].ToString()));
                    Values3.Add(double.Parse(value3[i].ToString()));
                    Values4.Add(double.Parse(value4[i].ToString()));
                    Values5.Add(double.Parse(value5[i].ToString()));
                    Values6.Add(double.Parse(value6[i].ToString()));
                    Values7.Add(double.Parse(value7[i].ToString()));

                }



                //    when multi threading avoid indexed calls like -> Values[0] 
                //    instead enumerate the collection
                //    ChartValues/GearedValues returns a thread safe copy once you enumerate it.
                //    TIPS: use foreach instead of for
                //    LINQ methods also enumerate the collections
                con.Close();
                }

                catch { }

                //temptime = ts;
                IsHot = _trend > 0;
                Count = Values.Count;
                CurrentLecture = _trend;

            //}


    /*        Action readFromTread = () =>
            {
                while (IsReading)
                {
                    Thread.Sleep(1);


                    try
                    {
                        DateTime enteredDate;
                        string server = "localhost";
                        string database = "datalogger";
                        string uid = "root";
                        string password = "root";
                        string constring = "server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

                        MySqlConnection con = new MySqlConnection(constring);
                        con.Open();


                        var query = "select * from samples WHERE ts >='" + Day1 + "' AND ts <='" + Day2 + "'";

                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataReader reader = cmd.ExecuteReader();
                         
                        while (reader.Read())
                        {


                            value = Convert.ToInt32(float.Parse(reader["aivalue0"].ToString()) * 100) / 100F;
                            value1 = Convert.ToInt32(float.Parse(reader["aivalue1"].ToString()) * 100) / 100F;
                            value2 = Convert.ToInt32(float.Parse(reader["aivalue2"].ToString()) * 100) / 100F;
                            value3 = Convert.ToInt32(float.Parse(reader["aivalue3"].ToString()) * 100) / 100F;
                            value4 = Convert.ToInt32(float.Parse(reader["aivalue4"].ToString()) * 100) / 100F;
                            value5 = Convert.ToInt32(float.Parse(reader["aivalue5"].ToString()) * 100) / 100F;
                            value6 = Convert.ToInt32(float.Parse(reader["aivalue6"].ToString()) * 100) / 100F;
                            value7 = Convert.ToInt32(float.Parse(reader["aivalue7"].ToString()) * 100) / 100F;
                            System.Windows.MessageBox.Show("ok");
                            ts = DateTime.Parse(reader["ts"].ToString());
                            
                        }


                        var first = Values.DefaultIfEmpty(0).FirstOrDefault();
                        var first1 = Values1.DefaultIfEmpty(0).FirstOrDefault();
                        var first2 = Values2.DefaultIfEmpty(0).FirstOrDefault();
                        var first3 = Values3.DefaultIfEmpty(0).FirstOrDefault();
                        var first4 = Values4.DefaultIfEmpty(0).FirstOrDefault();
                        var first5 = Values5.DefaultIfEmpty(0).FirstOrDefault();
                        var first6 = Values6.DefaultIfEmpty(0).FirstOrDefault();
                        var first7 = Values7.DefaultIfEmpty(0).FirstOrDefault();
                        if (Values.Count > keepRecords - 1)
                        {
                            times1.RemoveAt(0);
                            Values.Remove(first);
                            Values1.Remove(first1);
                            Values2.Remove(first2);
                            Values3.Remove(first3);
                            Values4.Remove(first4);
                            Values5.Remove(first5);
                            Values6.Remove(first6);
                            Values7.Remove(first7);

                        }
                        if (Values.Count < keepRecords)
                        {
                            times1.Add(ts.ToString());
                            Values.Add(double.Parse(value.ToString()));
                            Values1.Add(double.Parse(value1.ToString()));
                            Values2.Add(double.Parse(value2.ToString()));
                            Values3.Add(double.Parse(value3.ToString()));
                            Values4.Add(double.Parse(value4.ToString()));
                            Values5.Add(double.Parse(value5.ToString()));
                            Values6.Add(double.Parse(value6.ToString()));
                            Values7.Add(double.Parse(value7.ToString()));

                        }


                        //    when multi threading avoid indexed calls like -> Values[0] 
                        //    instead enumerate the collection
                        //    ChartValues/GearedValues returns a thread safe copy once you enumerate it.
                        //    TIPS: use foreach instead of for
                        //    LINQ methods also enumerate the collections
                        con.Close();
                    }

                    catch { }

                    temptime = ts;
                    IsHot = _trend > 0;
                    Count = Values.Count;
                    CurrentLecture = _trend;

                }
            };*/

            //2 different tasks adding a value every ms
            //add as many tasks as you want to test this feature
          //  Task.Factory.StartNew(readFromTread);
          //  Task.Factory.StartNew(readFromTread);
          //  Task.Factory.StartNew(readFromTread);
            //Task.Factory.StartNew(readFromTread);
            //Task.Factory.StartNew(readFromTread);
            //Task.Factory.StartNew(readFromTread);
            //Task.Factory.StartNew(readFromTread);
            //Task.Factory.StartNew(readFromTread);
        }
    }



}