using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataLoggerAppV1
{
    public partial class Monitor : Form
    {
        public static Monitor instance;
        public static bool isStay = false;
        public Monitor()
        {
            InitializeComponent();
            instance =this;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.standardControl45 = new SymbolFactoryDotNet.StandardControl();
            this.label24 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.standardControl90 = new SymbolFactoryDotNet.StandardControl();
            this.label55 = new System.Windows.Forms.Label();
            this.standardControl91 = new SymbolFactoryDotNet.StandardControl();
            this.label23 = new System.Windows.Forms.Label();
            this.standardControl88 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl89 = new SymbolFactoryDotNet.StandardControl();
            this.label4 = new System.Windows.Forms.Label();
            this.standardControl86 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl87 = new SymbolFactoryDotNet.StandardControl();
            this.label21 = new System.Windows.Forms.Label();
            this.standardControl85 = new SymbolFactoryDotNet.StandardControl();
            this.label20 = new System.Windows.Forms.Label();
            this.standardControl84 = new SymbolFactoryDotNet.StandardControl();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.standardControl83 = new SymbolFactoryDotNet.StandardControl();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.standardControl31 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl59 = new SymbolFactoryDotNet.StandardControl();
            this.label50 = new System.Windows.Forms.Label();
            this.standardControl60 = new SymbolFactoryDotNet.StandardControl();
            this.label57 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.standardControl82 = new SymbolFactoryDotNet.StandardControl();
            this.label49 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.standardControl80 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl81 = new SymbolFactoryDotNet.StandardControl();
            this.label7 = new System.Windows.Forms.Label();
            this.standardControl79 = new SymbolFactoryDotNet.StandardControl();
            this.label8 = new System.Windows.Forms.Label();
            this.standardControl76 = new SymbolFactoryDotNet.StandardControl();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.standardControl78 = new SymbolFactoryDotNet.StandardControl();
            this.label5 = new System.Windows.Forms.Label();
            this.standardControl77 = new SymbolFactoryDotNet.StandardControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.standardControl74 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl53 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl47 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl32 = new SymbolFactoryDotNet.StandardControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.standardControl46 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl14 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl41 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl40 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl26 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl25 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl23 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl22 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl4 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl24 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl6 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl3 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl2 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl1 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl5 = new SymbolFactoryDotNet.StandardControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.standardControl58 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl55 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl52 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl51 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl50 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl27 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl15 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl16 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl12 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl21 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl20 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl18 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl17 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl7 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl10 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl9 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl8 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl19 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl13 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl11 = new SymbolFactoryDotNet.StandardControl();
            this.label22 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.standardControl28 = new SymbolFactoryDotNet.StandardControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.standardControl69 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl70 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl65 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl49 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl54 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl63 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl64 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl57 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl66 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl73 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl48 = new SymbolFactoryDotNet.StandardControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.standardControl44 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl36 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl56 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl62 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl39 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl61 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl43 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl38 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl42 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl37 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl34 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl33 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl29 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl30 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl35 = new SymbolFactoryDotNet.StandardControl();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label51 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl77)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl32)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl11)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl28)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl48)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl35)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(1202, 523);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(124, 22);
            this.label46.TabIndex = 157;
            this.label46.Text = "THC Analyzer";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(404, 523);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(111, 22);
            this.label45.TabIndex = 173;
            this.label45.Text = "GC Analyzer";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(762, 11);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(236, 23);
            this.label41.TabIndex = 274;
            this.label41.Text = "VENT TO ATMOSPHERE";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(9, 450);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(106, 23);
            this.label40.TabIndex = 273;
            this.label40.Text = "SAMPLE 3";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(9, 365);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(106, 23);
            this.label39.TabIndex = 272;
            this.label39.Text = "SAMPLE 2";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(9, 272);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(106, 23);
            this.label38.TabIndex = 271;
            this.label38.Text = "SAMPLE 1";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(815, 784);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 23);
            this.label31.TabIndex = 266;
            this.label31.Text = "BOTTLE";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(813, 749);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(74, 23);
            this.label30.TabIndex = 265;
            this.label30.Text = "DRAIN";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(970, 832);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(107, 23);
            this.label29.TabIndex = 264;
            this.label29.Text = "FID AIR IN";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(930, 343);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(132, 23);
            this.label27.TabIndex = 263;
            this.label27.Text = "REGULATOR";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(939, 315);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(113, 23);
            this.label28.TabIndex = 262;
            this.label28.Text = "PRESSURE";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(710, 343);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(132, 23);
            this.label26.TabIndex = 261;
            this.label26.Text = "REGULATOR";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(719, 315);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 23);
            this.label25.TabIndex = 260;
            this.label25.Text = "PRESSURE";
            // 
            // standardControl45
            // 
            this.standardControl45.AnalogIntValue1 = ((short)(0));
            this.standardControl45.AnalogValue1 = 0D;
            this.standardControl45.BackColor = System.Drawing.Color.Transparent;
            this.standardControl45.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl45.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl45.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl45.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl45.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl45.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl45.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl45.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl45.BlinkColor = System.Drawing.Color.Red;
            this.standardControl45.Category = "1ARW.cat2";
            this.standardControl45.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl45.DebugData"));
            this.standardControl45.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl45.Location = new System.Drawing.Point(1235, 394);
            this.standardControl45.Name = "standardControl45";
            this.standardControl45.Size = new System.Drawing.Size(29, 23);
            this.standardControl45.Stretch = true;
            this.standardControl45.SymbolHandle = ((long)(34436));
            this.standardControl45.TabIndex = 259;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 691);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(132, 23);
            this.label24.TabIndex = 258;
            this.label24.Text = "FUEL GAS IN";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(136, 21);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(32, 24);
            this.label54.TabIndex = 170;
            this.label54.Text = "62";
            // 
            // standardControl90
            // 
            this.standardControl90.AnalogIntValue1 = ((short)(0));
            this.standardControl90.AnalogValue1 = 0D;
            this.standardControl90.BackColor = System.Drawing.Color.Transparent;
            this.standardControl90.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl90.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl90.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl90.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl90.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl90.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl90.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl90.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl90.BlinkColor = System.Drawing.Color.Red;
            this.standardControl90.Category = "1ARW.cat2";
            this.standardControl90.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl90.DebugData"));
            this.standardControl90.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl90.Location = new System.Drawing.Point(183, 710);
            this.standardControl90.Name = "standardControl90";
            this.standardControl90.Size = new System.Drawing.Size(29, 23);
            this.standardControl90.Stretch = true;
            this.standardControl90.SymbolHandle = ((long)(34436));
            this.standardControl90.TabIndex = 257;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(227, 21);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(58, 22);
            this.label55.TabIndex = 169;
            this.label55.Text = "mmm";
            // 
            // standardControl91
            // 
            this.standardControl91.AnalogIntValue1 = ((short)(0));
            this.standardControl91.AnalogValue1 = 0D;
            this.standardControl91.BackColor = System.Drawing.Color.Transparent;
            this.standardControl91.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl91.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl91.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl91.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl91.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl91.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl91.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl91.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl91.BlinkColor = System.Drawing.Color.Red;
            this.standardControl91.Category = "1PIPE.cat2";
            this.standardControl91.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl91.DebugData"));
            this.standardControl91.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl91.Location = new System.Drawing.Point(12, 720);
            this.standardControl91.Name = "standardControl91";
            this.standardControl91.Size = new System.Drawing.Size(182, 2);
            this.standardControl91.Stretch = true;
            this.standardControl91.SymbolHandle = ((long)(823526416));
            this.standardControl91.TabIndex = 256;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 643);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(170, 23);
            this.label23.TabIndex = 255;
            this.label23.Text = "CARRIER GAS IN";
            // 
            // standardControl88
            // 
            this.standardControl88.AnalogIntValue1 = ((short)(0));
            this.standardControl88.AnalogValue1 = 0D;
            this.standardControl88.BackColor = System.Drawing.Color.Transparent;
            this.standardControl88.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl88.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl88.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl88.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl88.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl88.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl88.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl88.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl88.BlinkColor = System.Drawing.Color.Red;
            this.standardControl88.Category = "1ARW.cat2";
            this.standardControl88.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl88.DebugData"));
            this.standardControl88.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl88.Location = new System.Drawing.Point(181, 660);
            this.standardControl88.Name = "standardControl88";
            this.standardControl88.Size = new System.Drawing.Size(29, 23);
            this.standardControl88.Stretch = true;
            this.standardControl88.SymbolHandle = ((long)(34436));
            this.standardControl88.TabIndex = 254;
            // 
            // standardControl89
            // 
            this.standardControl89.AnalogIntValue1 = ((short)(0));
            this.standardControl89.AnalogValue1 = 0D;
            this.standardControl89.BackColor = System.Drawing.Color.Transparent;
            this.standardControl89.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl89.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl89.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl89.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl89.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl89.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl89.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl89.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl89.BlinkColor = System.Drawing.Color.Red;
            this.standardControl89.Category = "1PIPE.cat2";
            this.standardControl89.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl89.DebugData"));
            this.standardControl89.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl89.Location = new System.Drawing.Point(10, 671);
            this.standardControl89.Name = "standardControl89";
            this.standardControl89.Size = new System.Drawing.Size(182, 2);
            this.standardControl89.Stretch = true;
            this.standardControl89.SymbolHandle = ((long)(823526416));
            this.standardControl89.TabIndex = 253;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 252;
            this.label4.Text = "CAL. GAS IN";
            // 
            // standardControl86
            // 
            this.standardControl86.AnalogIntValue1 = ((short)(0));
            this.standardControl86.AnalogValue1 = 0D;
            this.standardControl86.BackColor = System.Drawing.Color.Transparent;
            this.standardControl86.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl86.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl86.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl86.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl86.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl86.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl86.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl86.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl86.BlinkColor = System.Drawing.Color.Red;
            this.standardControl86.Category = "1ARW.cat2";
            this.standardControl86.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl86.DebugData"));
            this.standardControl86.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl86.Location = new System.Drawing.Point(223, 565);
            this.standardControl86.Name = "standardControl86";
            this.standardControl86.Size = new System.Drawing.Size(29, 23);
            this.standardControl86.Stretch = true;
            this.standardControl86.SymbolHandle = ((long)(34436));
            this.standardControl86.TabIndex = 251;
            // 
            // standardControl87
            // 
            this.standardControl87.AnalogIntValue1 = ((short)(0));
            this.standardControl87.AnalogValue1 = 0D;
            this.standardControl87.BackColor = System.Drawing.Color.Transparent;
            this.standardControl87.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl87.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl87.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl87.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl87.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl87.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl87.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl87.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl87.BlinkColor = System.Drawing.Color.Red;
            this.standardControl87.Category = "1PIPE.cat2";
            this.standardControl87.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl87.DebugData"));
            this.standardControl87.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl87.Location = new System.Drawing.Point(31, 576);
            this.standardControl87.Name = "standardControl87";
            this.standardControl87.Size = new System.Drawing.Size(191, 2);
            this.standardControl87.Stretch = true;
            this.standardControl87.SymbolHandle = ((long)(823526416));
            this.standardControl87.TabIndex = 250;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(795, 651);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 23);
            this.label21.TabIndex = 248;
            this.label21.Text = "5";
            // 
            // standardControl85
            // 
            this.standardControl85.AnalogIntValue1 = ((short)(0));
            this.standardControl85.AnalogValue1 = 0D;
            this.standardControl85.BackColor = System.Drawing.Color.Transparent;
            this.standardControl85.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl85.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl85.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl85.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl85.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl85.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl85.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl85.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl85.BlinkColor = System.Drawing.Color.Red;
            this.standardControl85.Category = "1AC.cat2";
            this.standardControl85.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl85.DebugData"));
            this.standardControl85.FillColor = System.Drawing.Color.White;
            this.standardControl85.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl85.Location = new System.Drawing.Point(784, 644);
            this.standardControl85.Name = "standardControl85";
            this.standardControl85.Size = new System.Drawing.Size(40, 40);
            this.standardControl85.Stretch = true;
            this.standardControl85.SymbolHandle = ((long)(1244714597));
            this.standardControl85.TabIndex = 247;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(795, 607);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 23);
            this.label20.TabIndex = 246;
            this.label20.Text = "4";
            // 
            // standardControl84
            // 
            this.standardControl84.AnalogIntValue1 = ((short)(0));
            this.standardControl84.AnalogValue1 = 0D;
            this.standardControl84.BackColor = System.Drawing.Color.Transparent;
            this.standardControl84.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl84.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl84.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl84.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl84.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl84.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl84.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl84.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl84.BlinkColor = System.Drawing.Color.Red;
            this.standardControl84.Category = "1AC.cat2";
            this.standardControl84.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl84.DebugData"));
            this.standardControl84.FillColor = System.Drawing.Color.White;
            this.standardControl84.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl84.Location = new System.Drawing.Point(784, 600);
            this.standardControl84.Name = "standardControl84";
            this.standardControl84.Size = new System.Drawing.Size(40, 40);
            this.standardControl84.Stretch = true;
            this.standardControl84.SymbolHandle = ((long)(1244714597));
            this.standardControl84.TabIndex = 245;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(839, 646);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 23);
            this.label19.TabIndex = 244;
            this.label19.Text = "Header";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(842, 619);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 23);
            this.label18.TabIndex = 243;
            this.label18.Text = "Vent";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(1190, 95);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(97, 22);
            this.label47.TabIndex = 158;
            this.label47.Text = "Total sufur";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(795, 563);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 23);
            this.label16.TabIndex = 242;
            this.label16.Text = "3";
            // 
            // standardControl83
            // 
            this.standardControl83.AnalogIntValue1 = ((short)(0));
            this.standardControl83.AnalogValue1 = 0D;
            this.standardControl83.BackColor = System.Drawing.Color.Transparent;
            this.standardControl83.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl83.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl83.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl83.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl83.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl83.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl83.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl83.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl83.BlinkColor = System.Drawing.Color.Red;
            this.standardControl83.Category = "1AC.cat2";
            this.standardControl83.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl83.DebugData"));
            this.standardControl83.FillColor = System.Drawing.Color.White;
            this.standardControl83.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl83.Location = new System.Drawing.Point(784, 556);
            this.standardControl83.Name = "standardControl83";
            this.standardControl83.Size = new System.Drawing.Size(40, 40);
            this.standardControl83.Stretch = true;
            this.standardControl83.SymbolHandle = ((long)(1244714597));
            this.standardControl83.TabIndex = 241;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(842, 593);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 23);
            this.label17.TabIndex = 240;
            this.label17.Text = "To";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(947, 701);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 23);
            this.label15.TabIndex = 239;
            this.label15.Text = "FUEL GAS IN";
            // 
            // standardControl31
            // 
            this.standardControl31.AnalogIntValue1 = ((short)(0));
            this.standardControl31.AnalogValue1 = 0D;
            this.standardControl31.BackColor = System.Drawing.Color.Transparent;
            this.standardControl31.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl31.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl31.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl31.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl31.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl31.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl31.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl31.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl31.BlinkColor = System.Drawing.Color.Red;
            this.standardControl31.Category = "1ARW.cat2";
            this.standardControl31.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl31.DebugData"));
            this.standardControl31.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl31.Location = new System.Drawing.Point(1085, 718);
            this.standardControl31.Name = "standardControl31";
            this.standardControl31.Size = new System.Drawing.Size(29, 23);
            this.standardControl31.Stretch = true;
            this.standardControl31.SymbolHandle = ((long)(34436));
            this.standardControl31.TabIndex = 238;
            // 
            // standardControl59
            // 
            this.standardControl59.AnalogIntValue1 = ((short)(0));
            this.standardControl59.AnalogValue1 = 0D;
            this.standardControl59.BackColor = System.Drawing.Color.Transparent;
            this.standardControl59.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl59.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl59.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl59.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl59.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl59.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl59.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl59.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl59.BlinkColor = System.Drawing.Color.Red;
            this.standardControl59.Category = "1ARW.cat2";
            this.standardControl59.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl59.DebugData"));
            this.standardControl59.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl59.Location = new System.Drawing.Point(1109, 563);
            this.standardControl59.Name = "standardControl59";
            this.standardControl59.Size = new System.Drawing.Size(29, 23);
            this.standardControl59.Stretch = true;
            this.standardControl59.SymbolHandle = ((long)(34436));
            this.standardControl59.TabIndex = 237;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(114, 17);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(32, 24);
            this.label50.TabIndex = 166;
            this.label50.Text = "62";
            // 
            // standardControl60
            // 
            this.standardControl60.AnalogIntValue1 = ((short)(0));
            this.standardControl60.AnalogValue1 = 0D;
            this.standardControl60.BackColor = System.Drawing.Color.Transparent;
            this.standardControl60.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl60.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl60.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl60.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl60.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl60.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl60.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl60.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl60.BlinkColor = System.Drawing.Color.Red;
            this.standardControl60.Category = "1ARW.cat2";
            this.standardControl60.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl60.DebugData"));
            this.standardControl60.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl60.Location = new System.Drawing.Point(1087, 669);
            this.standardControl60.Name = "standardControl60";
            this.standardControl60.Size = new System.Drawing.Size(29, 23);
            this.standardControl60.Stretch = true;
            this.standardControl60.SymbolHandle = ((long)(34436));
            this.standardControl60.TabIndex = 236;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(227, 83);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(58, 22);
            this.label57.TabIndex = 171;
            this.label57.Text = "mmm";
            this.label57.Click += new System.EventHandler(this.label57_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1395, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 23);
            this.label9.TabIndex = 231;
            this.label9.Text = "2";
            // 
            // standardControl82
            // 
            this.standardControl82.AnalogIntValue1 = ((short)(0));
            this.standardControl82.AnalogValue1 = 0D;
            this.standardControl82.BackColor = System.Drawing.Color.Transparent;
            this.standardControl82.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl82.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl82.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl82.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl82.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl82.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl82.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl82.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl82.BlinkColor = System.Drawing.Color.Red;
            this.standardControl82.Category = "1AC.cat2";
            this.standardControl82.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl82.DebugData"));
            this.standardControl82.FillColor = System.Drawing.Color.White;
            this.standardControl82.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl82.Location = new System.Drawing.Point(1385, 492);
            this.standardControl82.Name = "standardControl82";
            this.standardControl82.Size = new System.Drawing.Size(40, 40);
            this.standardControl82.Stretch = true;
            this.standardControl82.SymbolHandle = ((long)(1244714597));
            this.standardControl82.TabIndex = 230;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(193, 18);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(58, 22);
            this.label49.TabIndex = 165;
            this.label49.Text = "mmm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(944, 654);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 23);
            this.label14.TabIndex = 235;
            this.label14.Text = "SPAN GAS IN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(944, 606);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 23);
            this.label13.TabIndex = 234;
            this.label13.Text = "SAMPLE IN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(944, 548);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 23);
            this.label12.TabIndex = 233;
            this.label12.Text = "ZERO. GAS IN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1099, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 23);
            this.label11.TabIndex = 232;
            this.label11.Text = "CAL. GAS IN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1431, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 23);
            this.label10.TabIndex = 229;
            this.label10.Text = "To Vent Header";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(11, 18);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(62, 22);
            this.label48.TabIndex = 164;
            this.label48.Text = "6200T";
            // 
            // standardControl80
            // 
            this.standardControl80.AnalogIntValue1 = ((short)(0));
            this.standardControl80.AnalogValue1 = 0D;
            this.standardControl80.BackColor = System.Drawing.Color.Transparent;
            this.standardControl80.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl80.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl80.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl80.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl80.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl80.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl80.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl80.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl80.BlinkColor = System.Drawing.Color.Red;
            this.standardControl80.Category = "1ARW.cat2";
            this.standardControl80.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl80.DebugData"));
            this.standardControl80.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl80.Location = new System.Drawing.Point(1349, 499);
            this.standardControl80.Name = "standardControl80";
            this.standardControl80.Size = new System.Drawing.Size(29, 23);
            this.standardControl80.Stretch = true;
            this.standardControl80.SymbolHandle = ((long)(34436));
            this.standardControl80.TabIndex = 228;
            // 
            // standardControl81
            // 
            this.standardControl81.AnalogIntValue1 = ((short)(0));
            this.standardControl81.AnalogValue1 = 0D;
            this.standardControl81.BackColor = System.Drawing.Color.Transparent;
            this.standardControl81.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl81.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl81.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl81.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl81.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl81.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl81.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl81.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl81.BlinkColor = System.Drawing.Color.Red;
            this.standardControl81.Category = "1PIPE.cat2";
            this.standardControl81.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl81.DebugData"));
            this.standardControl81.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl81.Location = new System.Drawing.Point(1095, 510);
            this.standardControl81.Name = "standardControl81";
            this.standardControl81.Size = new System.Drawing.Size(260, 2);
            this.standardControl81.Stretch = true;
            this.standardControl81.SymbolHandle = ((long)(823526416));
            this.standardControl81.TabIndex = 227;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1461, 586);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 23);
            this.label7.TabIndex = 226;
            this.label7.Text = "6";
            // 
            // standardControl79
            // 
            this.standardControl79.AnalogIntValue1 = ((short)(0));
            this.standardControl79.AnalogValue1 = 0D;
            this.standardControl79.BackColor = System.Drawing.Color.Transparent;
            this.standardControl79.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl79.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl79.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl79.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl79.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl79.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl79.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl79.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl79.BlinkColor = System.Drawing.Color.Red;
            this.standardControl79.Category = "1AC.cat2";
            this.standardControl79.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl79.DebugData"));
            this.standardControl79.FillColor = System.Drawing.Color.White;
            this.standardControl79.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl79.Location = new System.Drawing.Point(1450, 579);
            this.standardControl79.Name = "standardControl79";
            this.standardControl79.Size = new System.Drawing.Size(40, 40);
            this.standardControl79.Stretch = true;
            this.standardControl79.SymbolHandle = ((long)(1244714597));
            this.standardControl79.TabIndex = 225;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1496, 587);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 23);
            this.label8.TabIndex = 224;
            this.label8.Text = "To Vent Header";
            // 
            // standardControl76
            // 
            this.standardControl76.AnalogIntValue1 = ((short)(0));
            this.standardControl76.AnalogValue1 = 0D;
            this.standardControl76.BackColor = System.Drawing.Color.Transparent;
            this.standardControl76.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl76.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl76.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl76.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl76.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl76.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl76.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl76.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl76.BlinkColor = System.Drawing.Color.Red;
            this.standardControl76.Category = "1ARW.cat2";
            this.standardControl76.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl76.DebugData"));
            this.standardControl76.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl76.Location = new System.Drawing.Point(1417, 230);
            this.standardControl76.Name = "standardControl76";
            this.standardControl76.Size = new System.Drawing.Size(29, 23);
            this.standardControl76.Stretch = true;
            this.standardControl76.SymbolHandle = ((long)(34436));
            this.standardControl76.TabIndex = 221;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(136, 146);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(32, 24);
            this.label58.TabIndex = 174;
            this.label58.Text = "62";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(227, 148);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(58, 22);
            this.label59.TabIndex = 173;
            this.label59.Text = "mmm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1460, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 23);
            this.label6.TabIndex = 223;
            this.label6.Text = "1";
            // 
            // standardControl78
            // 
            this.standardControl78.AnalogIntValue1 = ((short)(0));
            this.standardControl78.AnalogValue1 = 0D;
            this.standardControl78.BackColor = System.Drawing.Color.Transparent;
            this.standardControl78.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl78.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl78.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl78.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl78.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl78.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl78.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl78.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl78.BlinkColor = System.Drawing.Color.Red;
            this.standardControl78.Category = "1AC.cat2";
            this.standardControl78.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl78.DebugData"));
            this.standardControl78.FillColor = System.Drawing.Color.White;
            this.standardControl78.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl78.Location = new System.Drawing.Point(1449, 221);
            this.standardControl78.Name = "standardControl78";
            this.standardControl78.Size = new System.Drawing.Size(40, 40);
            this.standardControl78.Stretch = true;
            this.standardControl78.SymbolHandle = ((long)(1244714597));
            this.standardControl78.TabIndex = 222;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1495, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 170;
            this.label5.Text = "To Vent Header";
            // 
            // standardControl77
            // 
            this.standardControl77.AnalogIntValue1 = ((short)(0));
            this.standardControl77.AnalogValue1 = 0D;
            this.standardControl77.BackColor = System.Drawing.Color.Transparent;
            this.standardControl77.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl77.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl77.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl77.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl77.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl77.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl77.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl77.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl77.BlinkColor = System.Drawing.Color.Red;
            this.standardControl77.Category = "1PIPE.cat2";
            this.standardControl77.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl77.DebugData"));
            this.standardControl77.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl77.Location = new System.Drawing.Point(1364, 240);
            this.standardControl77.Name = "standardControl77";
            this.standardControl77.Size = new System.Drawing.Size(66, 2);
            this.standardControl77.Stretch = true;
            this.standardControl77.SymbolHandle = ((long)(823526416));
            this.standardControl77.TabIndex = 220;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label44);
            this.panel4.Controls.Add(this.label43);
            this.panel4.Controls.Add(this.label42);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(135, 821);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 141);
            this.panel4.TabIndex = 191;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(8, 12);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(227, 22);
            this.label44.TabIndex = 3;
            this.label44.Text = "ZERO GAS GENERATOR";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(8, 98);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(199, 22);
            this.label43.TabIndex = 2;
            this.label43.Text = "Maker: TELEDYNE AI";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(8, 65);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(101, 22);
            this.label42.TabIndex = 1;
            this.label42.Text = "Model: 701";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tag No: TBA";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(136, 83);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(32, 24);
            this.label56.TabIndex = 172;
            this.label56.Text = "62";
            this.label56.Click += new System.EventHandler(this.label56_Click);
            // 
            // standardControl74
            // 
            this.standardControl74.AnalogIntValue1 = ((short)(0));
            this.standardControl74.AnalogValue1 = 0D;
            this.standardControl74.BackColor = System.Drawing.Color.Transparent;
            this.standardControl74.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl74.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl74.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl74.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl74.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl74.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl74.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl74.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl74.BlinkColor = System.Drawing.Color.Red;
            this.standardControl74.Category = "1PIPE.cat2";
            this.standardControl74.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl74.DebugData"));
            this.standardControl74.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl74.Location = new System.Drawing.Point(328, 859);
            this.standardControl74.Name = "standardControl74";
            this.standardControl74.Size = new System.Drawing.Size(984, 2);
            this.standardControl74.Stretch = true;
            this.standardControl74.SymbolHandle = ((long)(823526416));
            this.standardControl74.TabIndex = 219;
            // 
            // standardControl53
            // 
            this.standardControl53.AnalogIntValue1 = ((short)(0));
            this.standardControl53.AnalogValue1 = 0D;
            this.standardControl53.BackColor = System.Drawing.Color.Transparent;
            this.standardControl53.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl53.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl53.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl53.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl53.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl53.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl53.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl53.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl53.BlinkColor = System.Drawing.Color.Red;
            this.standardControl53.Category = "1ash1.cat2";
            this.standardControl53.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl53.DebugData"));
            this.standardControl53.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl53.Location = new System.Drawing.Point(201, 237);
            this.standardControl53.Name = "standardControl53";
            this.standardControl53.Size = new System.Drawing.Size(18, 30);
            this.standardControl53.SymbolHandle = ((long)(1265761081));
            this.standardControl53.TabIndex = 77;
            // 
            // standardControl47
            // 
            this.standardControl47.AnalogIntValue1 = ((short)(0));
            this.standardControl47.AnalogValue1 = 0D;
            this.standardControl47.BackColor = System.Drawing.Color.Transparent;
            this.standardControl47.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl47.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl47.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl47.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl47.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl47.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl47.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl47.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl47.BlinkColor = System.Drawing.Color.Red;
            this.standardControl47.Category = "1HEAT.cat2";
            this.standardControl47.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl47.DebugData"));
            this.standardControl47.FillColor = System.Drawing.Color.Silver;
            this.standardControl47.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl47.Location = new System.Drawing.Point(963, 247);
            this.standardControl47.Name = "standardControl47";
            this.standardControl47.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate90;
            this.standardControl47.Size = new System.Drawing.Size(69, 63);
            this.standardControl47.SymbolHandle = ((long)(1113711002));
            this.standardControl47.TabIndex = 186;
            // 
            // standardControl32
            // 
            this.standardControl32.AnalogIntValue1 = ((short)(0));
            this.standardControl32.AnalogValue1 = 0D;
            this.standardControl32.BackColor = System.Drawing.Color.Transparent;
            this.standardControl32.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl32.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl32.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl32.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl32.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl32.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl32.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl32.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl32.BlinkColor = System.Drawing.Color.Red;
            this.standardControl32.Category = "1PIPE.cat2";
            this.standardControl32.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl32.DebugData"));
            this.standardControl32.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl32.Location = new System.Drawing.Point(1369, 131);
            this.standardControl32.Name = "standardControl32";
            this.standardControl32.Size = new System.Drawing.Size(99, 2);
            this.standardControl32.Stretch = true;
            this.standardControl32.SymbolHandle = ((long)(823526416));
            this.standardControl32.TabIndex = 190;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1443, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 70);
            this.panel2.TabIndex = 188;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thermal Converter";
            // 
            // standardControl46
            // 
            this.standardControl46.AnalogIntValue1 = ((short)(0));
            this.standardControl46.AnalogValue1 = 0D;
            this.standardControl46.BackColor = System.Drawing.Color.Transparent;
            this.standardControl46.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl46.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl46.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl46.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl46.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl46.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl46.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl46.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl46.BlinkColor = System.Drawing.Color.Red;
            this.standardControl46.Category = "1HEAT.cat2";
            this.standardControl46.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl46.DebugData"));
            this.standardControl46.FillColor = System.Drawing.Color.Silver;
            this.standardControl46.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl46.Location = new System.Drawing.Point(746, 246);
            this.standardControl46.Name = "standardControl46";
            this.standardControl46.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate90;
            this.standardControl46.Size = new System.Drawing.Size(69, 63);
            this.standardControl46.SymbolHandle = ((long)(1113711002));
            this.standardControl46.TabIndex = 184;
            // 
            // standardControl14
            // 
            this.standardControl14.AnalogIntValue1 = ((short)(0));
            this.standardControl14.AnalogValue1 = 0D;
            this.standardControl14.BackColor = System.Drawing.Color.Transparent;
            this.standardControl14.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl14.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl14.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl14.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl14.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl14.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl14.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl14.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl14.BlinkColor = System.Drawing.Color.Red;
            this.standardControl14.Category = "1ash1.cat2";
            this.standardControl14.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl14.DebugData"));
            this.standardControl14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl14.Location = new System.Drawing.Point(201, 144);
            this.standardControl14.Name = "standardControl14";
            this.standardControl14.Size = new System.Drawing.Size(18, 30);
            this.standardControl14.SymbolHandle = ((long)(1265761081));
            this.standardControl14.TabIndex = 76;
            // 
            // standardControl41
            // 
            this.standardControl41.AnalogIntValue1 = ((short)(0));
            this.standardControl41.AnalogValue1 = 0D;
            this.standardControl41.BackColor = System.Drawing.Color.Transparent;
            this.standardControl41.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl41.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl41.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl41.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl41.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl41.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl41.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl41.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl41.BlinkColor = System.Drawing.Color.Red;
            this.standardControl41.Category = "1PIPE.cat2";
            this.standardControl41.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl41.DebugData"));
            this.standardControl41.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl41.Location = new System.Drawing.Point(916, 283);
            this.standardControl41.Name = "standardControl41";
            this.standardControl41.Size = new System.Drawing.Size(2, 418);
            this.standardControl41.Stretch = true;
            this.standardControl41.SymbolHandle = ((long)(1221608394));
            this.standardControl41.TabIndex = 183;
            // 
            // standardControl40
            // 
            this.standardControl40.AnalogIntValue1 = ((short)(0));
            this.standardControl40.AnalogValue1 = 0D;
            this.standardControl40.BackColor = System.Drawing.Color.Transparent;
            this.standardControl40.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl40.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl40.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl40.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl40.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl40.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl40.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl40.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl40.BlinkColor = System.Drawing.Color.Red;
            this.standardControl40.Category = "1PIPE.cat2";
            this.standardControl40.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl40.DebugData"));
            this.standardControl40.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl40.Location = new System.Drawing.Point(918, 633);
            this.standardControl40.Name = "standardControl40";
            this.standardControl40.Size = new System.Drawing.Size(384, 2);
            this.standardControl40.Stretch = true;
            this.standardControl40.SymbolHandle = ((long)(823526416));
            this.standardControl40.TabIndex = 185;
            // 
            // standardControl26
            // 
            this.standardControl26.AnalogIntValue1 = ((short)(0));
            this.standardControl26.AnalogValue1 = 0D;
            this.standardControl26.BackColor = System.Drawing.Color.Transparent;
            this.standardControl26.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl26.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl26.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl26.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl26.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl26.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl26.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl26.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl26.BlinkColor = System.Drawing.Color.Red;
            this.standardControl26.Category = "1PIPE.cat2";
            this.standardControl26.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl26.DebugData"));
            this.standardControl26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl26.Location = new System.Drawing.Point(420, 43);
            this.standardControl26.Name = "standardControl26";
            this.standardControl26.Size = new System.Drawing.Size(2, 81);
            this.standardControl26.Stretch = true;
            this.standardControl26.SymbolHandle = ((long)(1221608394));
            this.standardControl26.TabIndex = 182;
            // 
            // standardControl25
            // 
            this.standardControl25.AnalogIntValue1 = ((short)(0));
            this.standardControl25.AnalogValue1 = 0D;
            this.standardControl25.BackColor = System.Drawing.Color.Transparent;
            this.standardControl25.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl25.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl25.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl25.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl25.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl25.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl25.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl25.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl25.BlinkColor = System.Drawing.Color.Red;
            this.standardControl25.Category = "1PIPE.cat2";
            this.standardControl25.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl25.DebugData"));
            this.standardControl25.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl25.Location = new System.Drawing.Point(327, 43);
            this.standardControl25.Name = "standardControl25";
            this.standardControl25.Size = new System.Drawing.Size(2, 80);
            this.standardControl25.Stretch = true;
            this.standardControl25.SymbolHandle = ((long)(1221608394));
            this.standardControl25.TabIndex = 181;
            // 
            // standardControl23
            // 
            this.standardControl23.AnalogIntValue1 = ((short)(0));
            this.standardControl23.AnalogValue1 = 0D;
            this.standardControl23.BackColor = System.Drawing.Color.Transparent;
            this.standardControl23.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl23.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl23.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl23.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl23.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl23.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl23.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl23.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl23.BlinkColor = System.Drawing.Color.Red;
            this.standardControl23.Category = "1PIPE.cat2";
            this.standardControl23.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl23.DebugData"));
            this.standardControl23.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl23.Location = new System.Drawing.Point(67, 41);
            this.standardControl23.Name = "standardControl23";
            this.standardControl23.Size = new System.Drawing.Size(1344, 2);
            this.standardControl23.Stretch = true;
            this.standardControl23.SymbolHandle = ((long)(823526416));
            this.standardControl23.TabIndex = 180;
            // 
            // standardControl22
            // 
            this.standardControl22.AnalogIntValue1 = ((short)(0));
            this.standardControl22.AnalogValue1 = 0D;
            this.standardControl22.BackColor = System.Drawing.Color.Transparent;
            this.standardControl22.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl22.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl22.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl22.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl22.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl22.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl22.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl22.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl22.BlinkColor = System.Drawing.Color.Red;
            this.standardControl22.Category = "1ARW.cat2";
            this.standardControl22.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl22.DebugData"));
            this.standardControl22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl22.Location = new System.Drawing.Point(6, 11);
            this.standardControl22.Name = "standardControl22";
            this.standardControl22.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate180;
            this.standardControl22.Size = new System.Drawing.Size(69, 63);
            this.standardControl22.SymbolHandle = ((long)(34436));
            this.standardControl22.TabIndex = 178;
            // 
            // standardControl4
            // 
            this.standardControl4.AnalogIntValue1 = ((short)(0));
            this.standardControl4.AnalogValue1 = 0D;
            this.standardControl4.BackColor = System.Drawing.Color.Transparent;
            this.standardControl4.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl4.BlinkColor = System.Drawing.Color.Red;
            this.standardControl4.Category = "1PIPE.cat2";
            this.standardControl4.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl4.DebugData"));
            this.standardControl4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl4.Location = new System.Drawing.Point(168, 375);
            this.standardControl4.Name = "standardControl4";
            this.standardControl4.Size = new System.Drawing.Size(155, 2);
            this.standardControl4.Stretch = true;
            this.standardControl4.SymbolHandle = ((long)(823526416));
            this.standardControl4.TabIndex = 176;
            // 
            // standardControl24
            // 
            this.standardControl24.AnalogIntValue1 = ((short)(0));
            this.standardControl24.AnalogValue1 = 0D;
            this.standardControl24.BackColor = System.Drawing.Color.Transparent;
            this.standardControl24.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl24.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl24.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl24.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl24.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl24.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl24.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl24.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl24.BlinkColor = System.Drawing.Color.Red;
            this.standardControl24.Category = "1PIPE.cat2";
            this.standardControl24.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl24.DebugData"));
            this.standardControl24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl24.Location = new System.Drawing.Point(229, 43);
            this.standardControl24.Name = "standardControl24";
            this.standardControl24.Size = new System.Drawing.Size(2, 78);
            this.standardControl24.Stretch = true;
            this.standardControl24.SymbolHandle = ((long)(1221608394));
            this.standardControl24.TabIndex = 179;
            // 
            // standardControl6
            // 
            this.standardControl6.AnalogIntValue1 = ((short)(0));
            this.standardControl6.AnalogValue1 = 0D;
            this.standardControl6.BackColor = System.Drawing.Color.Transparent;
            this.standardControl6.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl6.BlinkColor = System.Drawing.Color.Red;
            this.standardControl6.Category = "1PIPE.cat2";
            this.standardControl6.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl6.DebugData"));
            this.standardControl6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl6.Location = new System.Drawing.Point(167, 464);
            this.standardControl6.Name = "standardControl6";
            this.standardControl6.Size = new System.Drawing.Size(156, 2);
            this.standardControl6.Stretch = true;
            this.standardControl6.SymbolHandle = ((long)(823526416));
            this.standardControl6.TabIndex = 174;
            // 
            // standardControl3
            // 
            this.standardControl3.AnalogIntValue1 = ((short)(0));
            this.standardControl3.AnalogValue1 = 0D;
            this.standardControl3.BackColor = System.Drawing.Color.Transparent;
            this.standardControl3.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl3.BlinkColor = System.Drawing.Color.Red;
            this.standardControl3.Category = "1ARW.cat2";
            this.standardControl3.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl3.DebugData"));
            this.standardControl3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl3.Location = new System.Drawing.Point(112, 432);
            this.standardControl3.Name = "standardControl3";
            this.standardControl3.Size = new System.Drawing.Size(69, 63);
            this.standardControl3.SymbolHandle = ((long)(34436));
            this.standardControl3.TabIndex = 172;
            // 
            // standardControl2
            // 
            this.standardControl2.AnalogIntValue1 = ((short)(0));
            this.standardControl2.AnalogValue1 = 0D;
            this.standardControl2.BackColor = System.Drawing.Color.Transparent;
            this.standardControl2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl2.BlinkColor = System.Drawing.Color.Red;
            this.standardControl2.Category = "1ARW.cat2";
            this.standardControl2.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl2.DebugData"));
            this.standardControl2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl2.Location = new System.Drawing.Point(113, 343);
            this.standardControl2.Name = "standardControl2";
            this.standardControl2.Size = new System.Drawing.Size(69, 63);
            this.standardControl2.SymbolHandle = ((long)(34436));
            this.standardControl2.TabIndex = 171;
            // 
            // standardControl1
            // 
            this.standardControl1.AnalogIntValue1 = ((short)(0));
            this.standardControl1.AnalogValue1 = 0D;
            this.standardControl1.BackColor = System.Drawing.Color.Transparent;
            this.standardControl1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl1.BlinkColor = System.Drawing.Color.Red;
            this.standardControl1.Category = "1ARW.cat2";
            this.standardControl1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl1.DebugData"));
            this.standardControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl1.Location = new System.Drawing.Point(116, 250);
            this.standardControl1.Name = "standardControl1";
            this.standardControl1.Size = new System.Drawing.Size(69, 63);
            this.standardControl1.SymbolHandle = ((long)(34436));
            this.standardControl1.TabIndex = 169;
            // 
            // standardControl5
            // 
            this.standardControl5.AnalogIntValue1 = ((short)(0));
            this.standardControl5.AnalogValue1 = 0D;
            this.standardControl5.BackColor = System.Drawing.Color.Transparent;
            this.standardControl5.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl5.BlinkColor = System.Drawing.Color.Red;
            this.standardControl5.Category = "1PIPE.cat2";
            this.standardControl5.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl5.DebugData"));
            this.standardControl5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl5.Location = new System.Drawing.Point(168, 281);
            this.standardControl5.Name = "standardControl5";
            this.standardControl5.Size = new System.Drawing.Size(155, 2);
            this.standardControl5.Stretch = true;
            this.standardControl5.SymbolHandle = ((long)(823526416));
            this.standardControl5.TabIndex = 177;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.standardControl58);
            this.panel1.Controls.Add(this.standardControl55);
            this.panel1.Controls.Add(this.standardControl53);
            this.panel1.Controls.Add(this.standardControl14);
            this.panel1.Controls.Add(this.standardControl52);
            this.panel1.Controls.Add(this.standardControl51);
            this.panel1.Controls.Add(this.standardControl50);
            this.panel1.Controls.Add(this.standardControl27);
            this.panel1.Controls.Add(this.standardControl15);
            this.panel1.Controls.Add(this.standardControl16);
            this.panel1.Controls.Add(this.standardControl12);
            this.panel1.Controls.Add(this.standardControl21);
            this.panel1.Controls.Add(this.standardControl20);
            this.panel1.Controls.Add(this.standardControl18);
            this.panel1.Controls.Add(this.standardControl17);
            this.panel1.Controls.Add(this.standardControl7);
            this.panel1.Controls.Add(this.standardControl10);
            this.panel1.Controls.Add(this.standardControl9);
            this.panel1.Controls.Add(this.standardControl8);
            this.panel1.Controls.Add(this.standardControl19);
            this.panel1.Controls.Add(this.standardControl13);
            this.panel1.Controls.Add(this.standardControl11);
            this.panel1.Location = new System.Drawing.Point(204, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 393);
            this.panel1.TabIndex = 175;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(293, 44);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(114, 23);
            this.label37.TabIndex = 152;
            this.label37.Text = "SELECTOR";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(293, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(92, 23);
            this.label36.TabIndex = 152;
            this.label36.Text = "STREAM";
            // 
            // standardControl58
            // 
            this.standardControl58.AnalogIntValue1 = ((short)(0));
            this.standardControl58.AnalogValue1 = 0D;
            this.standardControl58.BackColor = System.Drawing.Color.Transparent;
            this.standardControl58.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl58.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl58.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl58.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl58.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl58.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl58.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl58.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl58.BlinkColor = System.Drawing.Color.Red;
            this.standardControl58.Category = "1PIPE.cat2";
            this.standardControl58.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl58.DebugData"));
            this.standardControl58.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl58.Location = new System.Drawing.Point(217, 265);
            this.standardControl58.Name = "standardControl58";
            this.standardControl58.Size = new System.Drawing.Size(2, 78);
            this.standardControl58.Stretch = true;
            this.standardControl58.SymbolHandle = ((long)(1221608394));
            this.standardControl58.TabIndex = 79;
            // 
            // standardControl55
            // 
            this.standardControl55.AnalogIntValue1 = ((short)(0));
            this.standardControl55.AnalogValue1 = 0D;
            this.standardControl55.BackColor = System.Drawing.Color.Transparent;
            this.standardControl55.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl55.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl55.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl55.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl55.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl55.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl55.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl55.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl55.BlinkColor = System.Drawing.Color.Red;
            this.standardControl55.Category = "1PIPE.cat2";
            this.standardControl55.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl55.DebugData"));
            this.standardControl55.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl55.Location = new System.Drawing.Point(217, 173);
            this.standardControl55.Name = "standardControl55";
            this.standardControl55.Size = new System.Drawing.Size(2, 65);
            this.standardControl55.Stretch = true;
            this.standardControl55.SymbolHandle = ((long)(1221608394));
            this.standardControl55.TabIndex = 78;
            // 
            // standardControl52
            // 
            this.standardControl52.AnalogIntValue1 = ((short)(0));
            this.standardControl52.AnalogValue1 = 0D;
            this.standardControl52.BackColor = System.Drawing.Color.Transparent;
            this.standardControl52.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl52.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl52.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl52.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl52.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl52.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl52.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl52.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl52.BlinkColor = System.Drawing.Color.Red;
            this.standardControl52.Category = "1PIPE.cat2";
            this.standardControl52.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl52.DebugData"));
            this.standardControl52.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl52.Location = new System.Drawing.Point(217, 111);
            this.standardControl52.Name = "standardControl52";
            this.standardControl52.Size = new System.Drawing.Size(2, 36);
            this.standardControl52.Stretch = true;
            this.standardControl52.SymbolHandle = ((long)(1221608394));
            this.standardControl52.TabIndex = 75;
            // 
            // standardControl51
            // 
            this.standardControl51.AnalogIntValue1 = ((short)(0));
            this.standardControl51.AnalogValue1 = 0D;
            this.standardControl51.BackColor = System.Drawing.Color.Transparent;
            this.standardControl51.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl51.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl51.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl51.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl51.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl51.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl51.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl51.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl51.BlinkColor = System.Drawing.Color.Red;
            this.standardControl51.Category = "1PIPE.cat2";
            this.standardControl51.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl51.DebugData"));
            this.standardControl51.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl51.Location = new System.Drawing.Point(121, 174);
            this.standardControl51.Name = "standardControl51";
            this.standardControl51.Size = new System.Drawing.Size(2, 79);
            this.standardControl51.Stretch = true;
            this.standardControl51.SymbolHandle = ((long)(1221608394));
            this.standardControl51.TabIndex = 74;
            // 
            // standardControl50
            // 
            this.standardControl50.AnalogIntValue1 = ((short)(0));
            this.standardControl50.AnalogValue1 = 0D;
            this.standardControl50.BackColor = System.Drawing.Color.Transparent;
            this.standardControl50.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl50.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl50.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl50.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl50.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl50.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl50.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl50.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl50.BlinkColor = System.Drawing.Color.Red;
            this.standardControl50.Category = "1ash1.cat2";
            this.standardControl50.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl50.DebugData"));
            this.standardControl50.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl50.Location = new System.Drawing.Point(106, 144);
            this.standardControl50.Name = "standardControl50";
            this.standardControl50.Size = new System.Drawing.Size(18, 30);
            this.standardControl50.SymbolHandle = ((long)(1265761081));
            this.standardControl50.TabIndex = 73;
            // 
            // standardControl27
            // 
            this.standardControl27.AnalogIntValue1 = ((short)(0));
            this.standardControl27.AnalogValue1 = 0D;
            this.standardControl27.BackColor = System.Drawing.Color.Transparent;
            this.standardControl27.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl27.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl27.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl27.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl27.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl27.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl27.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl27.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl27.BlinkColor = System.Drawing.Color.Red;
            this.standardControl27.Category = "1PIPE.cat2";
            this.standardControl27.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl27.DebugData"));
            this.standardControl27.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl27.Location = new System.Drawing.Point(400, 159);
            this.standardControl27.Name = "standardControl27";
            this.standardControl27.Size = new System.Drawing.Size(2, 184);
            this.standardControl27.Stretch = true;
            this.standardControl27.SymbolHandle = ((long)(1221608394));
            this.standardControl27.TabIndex = 39;
            // 
            // standardControl15
            // 
            this.standardControl15.AnalogIntValue1 = ((short)(0));
            this.standardControl15.AnalogValue1 = 0D;
            this.standardControl15.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.standardControl15.BackColor = System.Drawing.Color.Transparent;
            this.standardControl15.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl15.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl15.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl15.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl15.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl15.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl15.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl15.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl15.BlinkColor = System.Drawing.Color.Red;
            this.standardControl15.Category = "1HEAT.cat2";
            this.standardControl15.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl15.DebugData"));
            this.standardControl15.FillColor = System.Drawing.Color.Silver;
            this.standardControl15.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl15.Location = new System.Drawing.Point(270, 126);
            this.standardControl15.Name = "standardControl15";
            this.standardControl15.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate90;
            this.standardControl15.Size = new System.Drawing.Size(69, 63);
            this.standardControl15.SymbolHandle = ((long)(794709930));
            this.standardControl15.TabIndex = 38;
            // 
            // standardControl16
            // 
            this.standardControl16.AnalogIntValue1 = ((short)(0));
            this.standardControl16.AnalogValue1 = 0D;
            this.standardControl16.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.standardControl16.BackColor = System.Drawing.Color.Transparent;
            this.standardControl16.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl16.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl16.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl16.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl16.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl16.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl16.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl16.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl16.BlinkColor = System.Drawing.Color.Red;
            this.standardControl16.Category = "1HEAT.cat2";
            this.standardControl16.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl16.DebugData"));
            this.standardControl16.FillColor = System.Drawing.Color.Silver;
            this.standardControl16.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl16.Location = new System.Drawing.Point(270, 221);
            this.standardControl16.Name = "standardControl16";
            this.standardControl16.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate90;
            this.standardControl16.Size = new System.Drawing.Size(69, 63);
            this.standardControl16.SymbolHandle = ((long)(794709930));
            this.standardControl16.TabIndex = 22;
            // 
            // standardControl12
            // 
            this.standardControl12.AnalogIntValue1 = ((short)(0));
            this.standardControl12.AnalogValue1 = 0D;
            this.standardControl12.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.standardControl12.BackColor = System.Drawing.Color.Transparent;
            this.standardControl12.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl12.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl12.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl12.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl12.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl12.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl12.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl12.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl12.BlinkColor = System.Drawing.Color.Red;
            this.standardControl12.Category = "1HEAT.cat2";
            this.standardControl12.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl12.DebugData"));
            this.standardControl12.FillColor = System.Drawing.Color.Silver;
            this.standardControl12.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl12.Location = new System.Drawing.Point(184, 50);
            this.standardControl12.Name = "standardControl12";
            this.standardControl12.Size = new System.Drawing.Size(69, 63);
            this.standardControl12.SymbolHandle = ((long)(794709930));
            this.standardControl12.TabIndex = 19;
            // 
            // standardControl21
            // 
            this.standardControl21.AnalogIntValue1 = ((short)(0));
            this.standardControl21.AnalogValue1 = 0D;
            this.standardControl21.BackColor = System.Drawing.Color.Transparent;
            this.standardControl21.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl21.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl21.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl21.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl21.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl21.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl21.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl21.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl21.BlinkColor = System.Drawing.Color.Red;
            this.standardControl21.Category = "1PIPE.cat2";
            this.standardControl21.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl21.DebugData"));
            this.standardControl21.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl21.Location = new System.Drawing.Point(215, -15);
            this.standardControl21.Name = "standardControl21";
            this.standardControl21.Size = new System.Drawing.Size(2, 65);
            this.standardControl21.Stretch = true;
            this.standardControl21.SymbolHandle = ((long)(1221608394));
            this.standardControl21.TabIndex = 26;
            // 
            // standardControl20
            // 
            this.standardControl20.AnalogIntValue1 = ((short)(0));
            this.standardControl20.AnalogValue1 = 0D;
            this.standardControl20.BackColor = System.Drawing.Color.Transparent;
            this.standardControl20.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl20.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl20.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl20.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl20.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl20.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl20.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl20.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl20.BlinkColor = System.Drawing.Color.Red;
            this.standardControl20.Category = "1PIPE.cat2";
            this.standardControl20.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl20.DebugData"));
            this.standardControl20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl20.Location = new System.Drawing.Point(122, -15);
            this.standardControl20.Name = "standardControl20";
            this.standardControl20.Size = new System.Drawing.Size(2, 65);
            this.standardControl20.Stretch = true;
            this.standardControl20.SymbolHandle = ((long)(1221608394));
            this.standardControl20.TabIndex = 25;
            // 
            // standardControl18
            // 
            this.standardControl18.AnalogIntValue1 = ((short)(0));
            this.standardControl18.AnalogValue1 = 0D;
            this.standardControl18.BackColor = System.Drawing.Color.Transparent;
            this.standardControl18.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl18.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl18.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl18.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl18.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl18.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl18.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl18.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl18.BlinkColor = System.Drawing.Color.Red;
            this.standardControl18.Category = "1PIPE.cat2";
            this.standardControl18.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl18.DebugData"));
            this.standardControl18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl18.Location = new System.Drawing.Point(24, -14);
            this.standardControl18.Name = "standardControl18";
            this.standardControl18.Size = new System.Drawing.Size(2, 64);
            this.standardControl18.Stretch = true;
            this.standardControl18.SymbolHandle = ((long)(1221608394));
            this.standardControl18.TabIndex = 24;
            // 
            // standardControl17
            // 
            this.standardControl17.AnalogIntValue1 = ((short)(0));
            this.standardControl17.AnalogValue1 = 0D;
            this.standardControl17.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.standardControl17.BackColor = System.Drawing.Color.Transparent;
            this.standardControl17.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl17.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl17.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl17.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl17.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl17.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl17.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl17.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl17.BlinkColor = System.Drawing.Color.Red;
            this.standardControl17.Category = "1HEAT.cat2";
            this.standardControl17.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl17.DebugData"));
            this.standardControl17.FillColor = System.Drawing.Color.Silver;
            this.standardControl17.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl17.Location = new System.Drawing.Point(270, 310);
            this.standardControl17.Name = "standardControl17";
            this.standardControl17.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate90;
            this.standardControl17.Size = new System.Drawing.Size(69, 63);
            this.standardControl17.SymbolHandle = ((long)(794709930));
            this.standardControl17.TabIndex = 23;
            // 
            // standardControl7
            // 
            this.standardControl7.AnalogIntValue1 = ((short)(0));
            this.standardControl7.AnalogValue1 = 0D;
            this.standardControl7.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.standardControl7.BackColor = System.Drawing.Color.Transparent;
            this.standardControl7.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl7.BlinkColor = System.Drawing.Color.Red;
            this.standardControl7.Category = "1HEAT.cat2";
            this.standardControl7.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl7.DebugData"));
            this.standardControl7.FillColor = System.Drawing.Color.Silver;
            this.standardControl7.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl7.Location = new System.Drawing.Point(89, 50);
            this.standardControl7.Name = "standardControl7";
            this.standardControl7.Size = new System.Drawing.Size(69, 63);
            this.standardControl7.SymbolHandle = ((long)(794709930));
            this.standardControl7.TabIndex = 16;
            // 
            // standardControl10
            // 
            this.standardControl10.AnalogIntValue1 = ((short)(0));
            this.standardControl10.AnalogValue1 = 0D;
            this.standardControl10.BackColor = System.Drawing.Color.Transparent;
            this.standardControl10.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl10.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl10.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl10.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl10.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl10.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl10.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl10.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl10.BlinkColor = System.Drawing.Color.Red;
            this.standardControl10.Category = "1PIPE.cat2";
            this.standardControl10.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl10.DebugData"));
            this.standardControl10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl10.Location = new System.Drawing.Point(-20, 253);
            this.standardControl10.Name = "standardControl10";
            this.standardControl10.Size = new System.Drawing.Size(420, 2);
            this.standardControl10.Stretch = true;
            this.standardControl10.SymbolHandle = ((long)(823526416));
            this.standardControl10.TabIndex = 9;
            // 
            // standardControl9
            // 
            this.standardControl9.AnalogIntValue1 = ((short)(0));
            this.standardControl9.AnalogValue1 = 0D;
            this.standardControl9.BackColor = System.Drawing.Color.Transparent;
            this.standardControl9.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl9.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl9.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl9.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl9.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl9.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl9.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl9.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl9.BlinkColor = System.Drawing.Color.Red;
            this.standardControl9.Category = "1PIPE.cat2";
            this.standardControl9.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl9.DebugData"));
            this.standardControl9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl9.Location = new System.Drawing.Point(-20, 159);
            this.standardControl9.Name = "standardControl9";
            this.standardControl9.Size = new System.Drawing.Size(650, 2);
            this.standardControl9.Stretch = true;
            this.standardControl9.SymbolHandle = ((long)(823526416));
            this.standardControl9.TabIndex = 9;
            // 
            // standardControl8
            // 
            this.standardControl8.AnalogIntValue1 = ((short)(0));
            this.standardControl8.AnalogValue1 = 0D;
            this.standardControl8.BackColor = System.Drawing.Color.Transparent;
            this.standardControl8.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl8.BlinkColor = System.Drawing.Color.Red;
            this.standardControl8.Category = "1PIPE.cat2";
            this.standardControl8.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl8.DebugData"));
            this.standardControl8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl8.Location = new System.Drawing.Point(122, 108);
            this.standardControl8.Name = "standardControl8";
            this.standardControl8.Size = new System.Drawing.Size(2, 36);
            this.standardControl8.Stretch = true;
            this.standardControl8.SymbolHandle = ((long)(1221608394));
            this.standardControl8.TabIndex = 17;
            // 
            // standardControl19
            // 
            this.standardControl19.AnalogIntValue1 = ((short)(0));
            this.standardControl19.AnalogValue1 = 0D;
            this.standardControl19.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.standardControl19.BackColor = System.Drawing.Color.Transparent;
            this.standardControl19.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl19.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl19.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl19.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl19.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl19.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl19.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl19.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl19.BlinkColor = System.Drawing.Color.Red;
            this.standardControl19.Category = "1HEAT.cat2";
            this.standardControl19.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl19.DebugData"));
            this.standardControl19.FillColor = System.Drawing.Color.Silver;
            this.standardControl19.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl19.Location = new System.Drawing.Point(-8, 50);
            this.standardControl19.Name = "standardControl19";
            this.standardControl19.Size = new System.Drawing.Size(69, 63);
            this.standardControl19.SymbolHandle = ((long)(794709930));
            this.standardControl19.TabIndex = 7;
            // 
            // standardControl13
            // 
            this.standardControl13.AnalogIntValue1 = ((short)(0));
            this.standardControl13.AnalogValue1 = 0D;
            this.standardControl13.BackColor = System.Drawing.Color.Transparent;
            this.standardControl13.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl13.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl13.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl13.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl13.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl13.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl13.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl13.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl13.BlinkColor = System.Drawing.Color.Red;
            this.standardControl13.Category = "1PIPE.cat2";
            this.standardControl13.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl13.DebugData"));
            this.standardControl13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl13.Location = new System.Drawing.Point(24, 111);
            this.standardControl13.Name = "standardControl13";
            this.standardControl13.Size = new System.Drawing.Size(2, 48);
            this.standardControl13.Stretch = true;
            this.standardControl13.SymbolHandle = ((long)(1221608394));
            this.standardControl13.TabIndex = 13;
            // 
            // standardControl11
            // 
            this.standardControl11.AnalogIntValue1 = ((short)(0));
            this.standardControl11.AnalogValue1 = 0D;
            this.standardControl11.BackColor = System.Drawing.Color.Transparent;
            this.standardControl11.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl11.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl11.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl11.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl11.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl11.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl11.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl11.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl11.BlinkColor = System.Drawing.Color.Red;
            this.standardControl11.Category = "1PIPE.cat2";
            this.standardControl11.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl11.DebugData"));
            this.standardControl11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl11.Location = new System.Drawing.Point(-19, 342);
            this.standardControl11.Name = "standardControl11";
            this.standardControl11.Size = new System.Drawing.Size(420, 2);
            this.standardControl11.Stretch = true;
            this.standardControl11.SymbolHandle = ((long)(823526416));
            this.standardControl11.TabIndex = 18;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(804, 577);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 73);
            this.label22.TabIndex = 249;
            this.label22.Text = "}";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label50);
            this.panel5.Controls.Add(this.label49);
            this.panel5.Controls.Add(this.label48);
            this.panel5.Location = new System.Drawing.Point(1093, 134);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 65);
            this.panel5.TabIndex = 275;
            // 
            // standardControl28
            // 
            this.standardControl28.AnalogIntValue1 = ((short)(0));
            this.standardControl28.AnalogValue1 = 0D;
            this.standardControl28.BackColor = System.Drawing.Color.Transparent;
            this.standardControl28.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl28.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl28.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl28.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl28.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl28.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl28.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl28.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl28.BlinkColor = System.Drawing.Color.Red;
            this.standardControl28.Category = "1PIPE.cat2";
            this.standardControl28.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl28.DebugData"));
            this.standardControl28.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl28.Location = new System.Drawing.Point(651, 281);
            this.standardControl28.Name = "standardControl28";
            this.standardControl28.Size = new System.Drawing.Size(808, 2);
            this.standardControl28.Stretch = true;
            this.standardControl28.SymbolHandle = ((long)(823526416));
            this.standardControl28.TabIndex = 187;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label62);
            this.panel7.Controls.Add(this.label61);
            this.panel7.Controls.Add(this.label60);
            this.panel7.Controls.Add(this.label58);
            this.panel7.Controls.Add(this.label59);
            this.panel7.Controls.Add(this.label56);
            this.panel7.Controls.Add(this.label57);
            this.panel7.Controls.Add(this.label54);
            this.panel7.Controls.Add(this.label55);
            this.panel7.Location = new System.Drawing.Point(328, 554);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 192);
            this.panel7.TabIndex = 277;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(33, 149);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(62, 22);
            this.label62.TabIndex = 176;
            this.label62.Text = "6200T";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(33, 83);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(62, 22);
            this.label61.TabIndex = 175;
            this.label61.Text = "6200T";
            this.label61.Click += new System.EventHandler(this.label61_Click);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(33, 24);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(62, 22);
            this.label60.TabIndex = 169;
            this.label60.Text = "6200T";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // standardControl69
            // 
            this.standardControl69.AnalogIntValue1 = ((short)(0));
            this.standardControl69.AnalogValue1 = 0D;
            this.standardControl69.BackColor = System.Drawing.Color.Transparent;
            this.standardControl69.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl69.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl69.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl69.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl69.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl69.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl69.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl69.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl69.BlinkColor = System.Drawing.Color.Red;
            this.standardControl69.Category = "1ARW.cat2";
            this.standardControl69.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl69.DebugData"));
            this.standardControl69.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl69.Location = new System.Drawing.Point(1416, 587);
            this.standardControl69.Name = "standardControl69";
            this.standardControl69.Size = new System.Drawing.Size(29, 23);
            this.standardControl69.Stretch = true;
            this.standardControl69.SymbolHandle = ((long)(34436));
            this.standardControl69.TabIndex = 214;
            // 
            // standardControl70
            // 
            this.standardControl70.AnalogIntValue1 = ((short)(0));
            this.standardControl70.AnalogValue1 = 0D;
            this.standardControl70.BackColor = System.Drawing.Color.Transparent;
            this.standardControl70.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl70.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl70.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl70.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl70.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl70.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl70.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl70.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl70.BlinkColor = System.Drawing.Color.Red;
            this.standardControl70.Category = "1PIPE.cat2";
            this.standardControl70.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl70.DebugData"));
            this.standardControl70.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl70.Location = new System.Drawing.Point(1383, 598);
            this.standardControl70.Name = "standardControl70";
            this.standardControl70.Size = new System.Drawing.Size(62, 2);
            this.standardControl70.Stretch = true;
            this.standardControl70.SymbolHandle = ((long)(823526416));
            this.standardControl70.TabIndex = 213;
            // 
            // standardControl65
            // 
            this.standardControl65.AnalogIntValue1 = ((short)(0));
            this.standardControl65.AnalogValue1 = 0D;
            this.standardControl65.BackColor = System.Drawing.Color.Transparent;
            this.standardControl65.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl65.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl65.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl65.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl65.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl65.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl65.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl65.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl65.BlinkColor = System.Drawing.Color.Red;
            this.standardControl65.Category = "1TANK.cat2";
            this.standardControl65.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl65.DebugData"));
            this.standardControl65.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl65.Location = new System.Drawing.Point(762, 739);
            this.standardControl65.Name = "standardControl65";
            this.standardControl65.Size = new System.Drawing.Size(36, 75);
            this.standardControl65.Stretch = true;
            this.standardControl65.SymbolHandle = ((long)(2057225536));
            this.standardControl65.TabIndex = 209;
            // 
            // standardControl49
            // 
            this.standardControl49.AnalogIntValue1 = ((short)(0));
            this.standardControl49.AnalogValue1 = 0D;
            this.standardControl49.BackColor = System.Drawing.Color.Transparent;
            this.standardControl49.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl49.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl49.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl49.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl49.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl49.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl49.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl49.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl49.BlinkColor = System.Drawing.Color.Red;
            this.standardControl49.Category = "1ARW.cat2";
            this.standardControl49.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl49.DebugData"));
            this.standardControl49.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl49.Location = new System.Drawing.Point(750, 608);
            this.standardControl49.Name = "standardControl49";
            this.standardControl49.Size = new System.Drawing.Size(29, 23);
            this.standardControl49.Stretch = true;
            this.standardControl49.SymbolHandle = ((long)(34436));
            this.standardControl49.TabIndex = 206;
            // 
            // standardControl54
            // 
            this.standardControl54.AnalogIntValue1 = ((short)(0));
            this.standardControl54.AnalogValue1 = 0D;
            this.standardControl54.BackColor = System.Drawing.Color.Transparent;
            this.standardControl54.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl54.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl54.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl54.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl54.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl54.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl54.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl54.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl54.BlinkColor = System.Drawing.Color.Red;
            this.standardControl54.Category = "1PIPE.cat2";
            this.standardControl54.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl54.DebugData"));
            this.standardControl54.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl54.Location = new System.Drawing.Point(951, 729);
            this.standardControl54.Name = "standardControl54";
            this.standardControl54.Size = new System.Drawing.Size(247, 2);
            this.standardControl54.Stretch = true;
            this.standardControl54.SymbolHandle = ((long)(823526416));
            this.standardControl54.TabIndex = 215;
            // 
            // standardControl63
            // 
            this.standardControl63.AnalogIntValue1 = ((short)(0));
            this.standardControl63.AnalogValue1 = 0D;
            this.standardControl63.BackColor = System.Drawing.Color.Transparent;
            this.standardControl63.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl63.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl63.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl63.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl63.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl63.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl63.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl63.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl63.BlinkColor = System.Drawing.Color.Red;
            this.standardControl63.Category = "1ARW.cat2";
            this.standardControl63.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl63.DebugData"));
            this.standardControl63.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl63.Location = new System.Drawing.Point(748, 652);
            this.standardControl63.Name = "standardControl63";
            this.standardControl63.Size = new System.Drawing.Size(29, 23);
            this.standardControl63.Stretch = true;
            this.standardControl63.SymbolHandle = ((long)(34436));
            this.standardControl63.TabIndex = 208;
            // 
            // standardControl64
            // 
            this.standardControl64.AnalogIntValue1 = ((short)(0));
            this.standardControl64.AnalogValue1 = 0D;
            this.standardControl64.BackColor = System.Drawing.Color.Transparent;
            this.standardControl64.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl64.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl64.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl64.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl64.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl64.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl64.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl64.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl64.BlinkColor = System.Drawing.Color.Red;
            this.standardControl64.Category = "1PIPE.cat2";
            this.standardControl64.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl64.DebugData"));
            this.standardControl64.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl64.Location = new System.Drawing.Point(718, 663);
            this.standardControl64.Name = "standardControl64";
            this.standardControl64.Size = new System.Drawing.Size(62, 2);
            this.standardControl64.Stretch = true;
            this.standardControl64.SymbolHandle = ((long)(823526416));
            this.standardControl64.TabIndex = 207;
            // 
            // standardControl57
            // 
            this.standardControl57.AnalogIntValue1 = ((short)(0));
            this.standardControl57.AnalogValue1 = 0D;
            this.standardControl57.BackColor = System.Drawing.Color.Transparent;
            this.standardControl57.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl57.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl57.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl57.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl57.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl57.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl57.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl57.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl57.BlinkColor = System.Drawing.Color.Red;
            this.standardControl57.Category = "1PIPE.cat2";
            this.standardControl57.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl57.DebugData"));
            this.standardControl57.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl57.Location = new System.Drawing.Point(718, 619);
            this.standardControl57.Name = "standardControl57";
            this.standardControl57.Size = new System.Drawing.Size(62, 2);
            this.standardControl57.Stretch = true;
            this.standardControl57.SymbolHandle = ((long)(823526416));
            this.standardControl57.TabIndex = 205;
            // 
            // standardControl66
            // 
            this.standardControl66.AnalogIntValue1 = ((short)(0));
            this.standardControl66.AnalogValue1 = 0D;
            this.standardControl66.BackColor = System.Drawing.Color.Transparent;
            this.standardControl66.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl66.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl66.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl66.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl66.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl66.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl66.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl66.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl66.BlinkColor = System.Drawing.Color.Red;
            this.standardControl66.Category = "1PIPE.cat2";
            this.standardControl66.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl66.DebugData"));
            this.standardControl66.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl66.Location = new System.Drawing.Point(716, 744);
            this.standardControl66.Name = "standardControl66";
            this.standardControl66.Size = new System.Drawing.Size(62, 2);
            this.standardControl66.Stretch = true;
            this.standardControl66.SymbolHandle = ((long)(823526416));
            this.standardControl66.TabIndex = 210;
            // 
            // standardControl73
            // 
            this.standardControl73.AnalogIntValue1 = ((short)(0));
            this.standardControl73.AnalogValue1 = 0D;
            this.standardControl73.BackColor = System.Drawing.Color.Transparent;
            this.standardControl73.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl73.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl73.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl73.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl73.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl73.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl73.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl73.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl73.BlinkColor = System.Drawing.Color.Red;
            this.standardControl73.Category = "1PIPE.cat2";
            this.standardControl73.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl73.DebugData"));
            this.standardControl73.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl73.Location = new System.Drawing.Point(634, 737);
            this.standardControl73.Name = "standardControl73";
            this.standardControl73.Size = new System.Drawing.Size(2, 124);
            this.standardControl73.Stretch = true;
            this.standardControl73.SymbolHandle = ((long)(1221608394));
            this.standardControl73.TabIndex = 218;
            // 
            // standardControl48
            // 
            this.standardControl48.AnalogIntValue1 = ((short)(0));
            this.standardControl48.AnalogValue1 = 0D;
            this.standardControl48.BackColor = System.Drawing.Color.Transparent;
            this.standardControl48.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl48.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl48.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl48.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl48.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl48.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl48.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl48.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl48.BlinkColor = System.Drawing.Color.Red;
            this.standardControl48.Category = "1PIPE.cat2";
            this.standardControl48.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl48.DebugData"));
            this.standardControl48.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl48.Location = new System.Drawing.Point(570, 699);
            this.standardControl48.Name = "standardControl48";
            this.standardControl48.Size = new System.Drawing.Size(346, 2);
            this.standardControl48.Stretch = true;
            this.standardControl48.SymbolHandle = ((long)(823526416));
            this.standardControl48.TabIndex = 204;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1263, 374);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 92);
            this.panel3.TabIndex = 189;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "PRECISION CALIBRATOR";
            // 
            // standardControl44
            // 
            this.standardControl44.AnalogIntValue1 = ((short)(0));
            this.standardControl44.AnalogValue1 = 0D;
            this.standardControl44.BackColor = System.Drawing.Color.Transparent;
            this.standardControl44.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl44.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl44.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl44.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl44.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl44.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl44.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl44.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl44.BlinkColor = System.Drawing.Color.Red;
            this.standardControl44.Category = "1PIPE.cat2";
            this.standardControl44.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl44.DebugData"));
            this.standardControl44.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl44.Location = new System.Drawing.Point(1101, 405);
            this.standardControl44.Name = "standardControl44";
            this.standardControl44.Size = new System.Drawing.Size(191, 2);
            this.standardControl44.Stretch = true;
            this.standardControl44.SymbolHandle = ((long)(823526416));
            this.standardControl44.TabIndex = 199;
            // 
            // standardControl36
            // 
            this.standardControl36.AnalogIntValue1 = ((short)(0));
            this.standardControl36.AnalogValue1 = 0D;
            this.standardControl36.BackColor = System.Drawing.Color.Transparent;
            this.standardControl36.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl36.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl36.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl36.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl36.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl36.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl36.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl36.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl36.BlinkColor = System.Drawing.Color.Red;
            this.standardControl36.Category = "1ARW.cat2";
            this.standardControl36.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl36.DebugData"));
            this.standardControl36.FillColor = System.Drawing.Color.Black;
            this.standardControl36.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl36.Location = new System.Drawing.Point(1372, 160);
            this.standardControl36.Name = "standardControl36";
            this.standardControl36.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate180;
            this.standardControl36.Size = new System.Drawing.Size(20, 15);
            this.standardControl36.Stretch = true;
            this.standardControl36.SymbolHandle = ((long)(34436));
            this.standardControl36.TabIndex = 194;
            // 
            // standardControl56
            // 
            this.standardControl56.AnalogIntValue1 = ((short)(0));
            this.standardControl56.AnalogValue1 = 0D;
            this.standardControl56.BackColor = System.Drawing.Color.Transparent;
            this.standardControl56.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl56.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl56.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl56.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl56.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl56.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl56.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl56.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl56.BlinkColor = System.Drawing.Color.Red;
            this.standardControl56.Category = "1PIPE.cat2";
            this.standardControl56.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl56.DebugData"));
            this.standardControl56.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl56.Location = new System.Drawing.Point(1312, 737);
            this.standardControl56.Name = "standardControl56";
            this.standardControl56.Size = new System.Drawing.Size(2, 124);
            this.standardControl56.Stretch = true;
            this.standardControl56.SymbolHandle = ((long)(1221608394));
            this.standardControl56.TabIndex = 203;
            // 
            // standardControl62
            // 
            this.standardControl62.AnalogIntValue1 = ((short)(0));
            this.standardControl62.AnalogValue1 = 0D;
            this.standardControl62.BackColor = System.Drawing.Color.Transparent;
            this.standardControl62.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl62.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl62.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl62.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl62.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl62.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl62.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl62.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl62.BlinkColor = System.Drawing.Color.Red;
            this.standardControl62.Category = "1ARW.cat2";
            this.standardControl62.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl62.DebugData"));
            this.standardControl62.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl62.Location = new System.Drawing.Point(749, 565);
            this.standardControl62.Name = "standardControl62";
            this.standardControl62.Size = new System.Drawing.Size(29, 23);
            this.standardControl62.Stretch = true;
            this.standardControl62.SymbolHandle = ((long)(34436));
            this.standardControl62.TabIndex = 202;
            // 
            // standardControl39
            // 
            this.standardControl39.AnalogIntValue1 = ((short)(0));
            this.standardControl39.AnalogValue1 = 0D;
            this.standardControl39.BackColor = System.Drawing.Color.Transparent;
            this.standardControl39.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl39.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl39.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl39.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl39.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl39.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl39.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl39.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl39.BlinkColor = System.Drawing.Color.Red;
            this.standardControl39.Category = "1PIPE.cat2";
            this.standardControl39.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl39.DebugData"));
            this.standardControl39.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl39.Location = new System.Drawing.Point(718, 576);
            this.standardControl39.Name = "standardControl39";
            this.standardControl39.Size = new System.Drawing.Size(62, 2);
            this.standardControl39.Stretch = true;
            this.standardControl39.SymbolHandle = ((long)(823526416));
            this.standardControl39.TabIndex = 201;
            // 
            // standardControl61
            // 
            this.standardControl61.AnalogIntValue1 = ((short)(0));
            this.standardControl61.AnalogValue1 = 0D;
            this.standardControl61.BackColor = System.Drawing.Color.Transparent;
            this.standardControl61.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl61.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl61.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl61.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl61.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl61.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl61.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl61.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl61.BlinkColor = System.Drawing.Color.Red;
            this.standardControl61.Category = "1PIPE.cat2";
            this.standardControl61.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl61.DebugData"));
            this.standardControl61.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl61.Location = new System.Drawing.Point(946, 679);
            this.standardControl61.Name = "standardControl61";
            this.standardControl61.Size = new System.Drawing.Size(247, 2);
            this.standardControl61.Stretch = true;
            this.standardControl61.SymbolHandle = ((long)(823526416));
            this.standardControl61.TabIndex = 200;
            // 
            // standardControl43
            // 
            this.standardControl43.AnalogIntValue1 = ((short)(0));
            this.standardControl43.AnalogValue1 = 0D;
            this.standardControl43.BackColor = System.Drawing.Color.Transparent;
            this.standardControl43.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl43.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl43.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl43.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl43.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl43.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl43.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl43.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl43.BlinkColor = System.Drawing.Color.Red;
            this.standardControl43.Category = "1PIPE.cat2";
            this.standardControl43.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl43.DebugData"));
            this.standardControl43.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl43.Location = new System.Drawing.Point(946, 574);
            this.standardControl43.Name = "standardControl43";
            this.standardControl43.Size = new System.Drawing.Size(395, 2);
            this.standardControl43.Stretch = true;
            this.standardControl43.SymbolHandle = ((long)(823526416));
            this.standardControl43.TabIndex = 198;
            // 
            // standardControl38
            // 
            this.standardControl38.AnalogIntValue1 = ((short)(0));
            this.standardControl38.AnalogValue1 = 0D;
            this.standardControl38.BackColor = System.Drawing.Color.Transparent;
            this.standardControl38.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl38.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl38.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl38.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl38.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl38.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl38.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl38.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl38.BlinkColor = System.Drawing.Color.Red;
            this.standardControl38.Category = "1PIPE.cat2";
            this.standardControl38.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl38.DebugData"));
            this.standardControl38.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl38.Location = new System.Drawing.Point(1094, 450);
            this.standardControl38.Name = "standardControl38";
            this.standardControl38.Size = new System.Drawing.Size(2, 124);
            this.standardControl38.Stretch = true;
            this.standardControl38.SymbolHandle = ((long)(1221608394));
            this.standardControl38.TabIndex = 196;
            // 
            // standardControl42
            // 
            this.standardControl42.AnalogIntValue1 = ((short)(0));
            this.standardControl42.AnalogValue1 = 0D;
            this.standardControl42.BackColor = System.Drawing.Color.Transparent;
            this.standardControl42.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl42.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl42.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl42.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl42.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl42.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl42.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl42.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl42.BlinkColor = System.Drawing.Color.Red;
            this.standardControl42.Category = "1PIPE.cat2";
            this.standardControl42.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl42.DebugData"));
            this.standardControl42.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl42.Location = new System.Drawing.Point(1095, 449);
            this.standardControl42.Name = "standardControl42";
            this.standardControl42.Size = new System.Drawing.Size(167, 2);
            this.standardControl42.Stretch = true;
            this.standardControl42.SymbolHandle = ((long)(823526416));
            this.standardControl42.TabIndex = 197;
            // 
            // standardControl37
            // 
            this.standardControl37.AnalogIntValue1 = ((short)(0));
            this.standardControl37.AnalogValue1 = 0D;
            this.standardControl37.BackColor = System.Drawing.Color.Transparent;
            this.standardControl37.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl37.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl37.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl37.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl37.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl37.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl37.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl37.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl37.BlinkColor = System.Drawing.Color.Red;
            this.standardControl37.Category = "1PIPE.cat2";
            this.standardControl37.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl37.DebugData"));
            this.standardControl37.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl37.Location = new System.Drawing.Point(1458, 282);
            this.standardControl37.Name = "standardControl37";
            this.standardControl37.Size = new System.Drawing.Size(2, 125);
            this.standardControl37.Stretch = true;
            this.standardControl37.SymbolHandle = ((long)(1221608394));
            this.standardControl37.TabIndex = 195;
            // 
            // standardControl34
            // 
            this.standardControl34.AnalogIntValue1 = ((short)(0));
            this.standardControl34.AnalogValue1 = 0D;
            this.standardControl34.BackColor = System.Drawing.Color.Transparent;
            this.standardControl34.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl34.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl34.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl34.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl34.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl34.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl34.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl34.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl34.BlinkColor = System.Drawing.Color.Red;
            this.standardControl34.Category = "1ARW.cat2";
            this.standardControl34.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl34.DebugData"));
            this.standardControl34.FillColor = System.Drawing.Color.Black;
            this.standardControl34.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl34.Location = new System.Drawing.Point(1424, 124);
            this.standardControl34.Name = "standardControl34";
            this.standardControl34.Size = new System.Drawing.Size(20, 15);
            this.standardControl34.Stretch = true;
            this.standardControl34.SymbolHandle = ((long)(34436));
            this.standardControl34.TabIndex = 193;
            // 
            // standardControl33
            // 
            this.standardControl33.AnalogIntValue1 = ((short)(0));
            this.standardControl33.AnalogValue1 = 0D;
            this.standardControl33.BackColor = System.Drawing.Color.Transparent;
            this.standardControl33.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl33.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl33.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl33.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl33.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl33.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl33.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl33.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl33.BlinkColor = System.Drawing.Color.Red;
            this.standardControl33.Category = "1PIPE.cat2";
            this.standardControl33.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl33.DebugData"));
            this.standardControl33.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl33.Location = new System.Drawing.Point(1369, 166);
            this.standardControl33.Name = "standardControl33";
            this.standardControl33.Size = new System.Drawing.Size(99, 2);
            this.standardControl33.Stretch = true;
            this.standardControl33.SymbolHandle = ((long)(823526416));
            this.standardControl33.TabIndex = 192;
            // 
            // standardControl29
            // 
            this.standardControl29.AnalogIntValue1 = ((short)(0));
            this.standardControl29.AnalogValue1 = 0D;
            this.standardControl29.BackColor = System.Drawing.Color.Transparent;
            this.standardControl29.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl29.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl29.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl29.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl29.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl29.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl29.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl29.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl29.BlinkColor = System.Drawing.Color.Red;
            this.standardControl29.Category = "1Mach.cat2";
            this.standardControl29.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl29.DebugData"));
            this.standardControl29.FillColor = System.Drawing.Color.Silver;
            this.standardControl29.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl29.Location = new System.Drawing.Point(1062, 124);
            this.standardControl29.Name = "standardControl29";
            this.standardControl29.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate90;
            this.standardControl29.Size = new System.Drawing.Size(308, 203);
            this.standardControl29.Stretch = true;
            this.standardControl29.SymbolHandle = ((long)(2107456727));
            this.standardControl29.TabIndex = 278;
            // 
            // standardControl30
            // 
            this.standardControl30.AnalogIntValue1 = ((short)(0));
            this.standardControl30.AnalogValue1 = 0D;
            this.standardControl30.BackColor = System.Drawing.Color.Transparent;
            this.standardControl30.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl30.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl30.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl30.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl30.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl30.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl30.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl30.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl30.BlinkColor = System.Drawing.Color.Red;
            this.standardControl30.Category = "1Mach.cat2";
            this.standardControl30.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl30.DebugData"));
            this.standardControl30.FillColor = System.Drawing.Color.Silver;
            this.standardControl30.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl30.Location = new System.Drawing.Point(1109, 556);
            this.standardControl30.Name = "standardControl30";
            this.standardControl30.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate90;
            this.standardControl30.Size = new System.Drawing.Size(301, 203);
            this.standardControl30.Stretch = true;
            this.standardControl30.SymbolHandle = ((long)(2107456727));
            this.standardControl30.TabIndex = 279;
            // 
            // standardControl35
            // 
            this.standardControl35.AnalogIntValue1 = ((short)(0));
            this.standardControl35.AnalogValue1 = 0D;
            this.standardControl35.BackColor = System.Drawing.Color.Transparent;
            this.standardControl35.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl35.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl35.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl35.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl35.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl35.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl35.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl35.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl35.BlinkColor = System.Drawing.Color.Red;
            this.standardControl35.Category = "1Mach.cat2";
            this.standardControl35.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl35.DebugData"));
            this.standardControl35.FillColor = System.Drawing.Color.Silver;
            this.standardControl35.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl35.Location = new System.Drawing.Point(204, 548);
            this.standardControl35.Name = "standardControl35";
            this.standardControl35.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate90;
            this.standardControl35.Size = new System.Drawing.Size(516, 203);
            this.standardControl35.Stretch = true;
            this.standardControl35.SymbolHandle = ((long)(2107456727));
            this.standardControl35.TabIndex = 280;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Controls.Add(this.standardControl34);
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.standardControl29);
            this.panel8.Controls.Add(this.label45);
            this.panel8.Controls.Add(this.label41);
            this.panel8.Controls.Add(this.label46);
            this.panel8.Controls.Add(this.label47);
            this.panel8.Controls.Add(this.label40);
            this.panel8.Controls.Add(this.label39);
            this.panel8.Controls.Add(this.label38);
            this.panel8.Controls.Add(this.label31);
            this.panel8.Controls.Add(this.label30);
            this.panel8.Controls.Add(this.label29);
            this.panel8.Controls.Add(this.label27);
            this.panel8.Controls.Add(this.label28);
            this.panel8.Controls.Add(this.label26);
            this.panel8.Controls.Add(this.label25);
            this.panel8.Controls.Add(this.standardControl45);
            this.panel8.Controls.Add(this.label24);
            this.panel8.Controls.Add(this.standardControl90);
            this.panel8.Controls.Add(this.standardControl91);
            this.panel8.Controls.Add(this.label23);
            this.panel8.Controls.Add(this.standardControl88);
            this.panel8.Controls.Add(this.standardControl89);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.standardControl86);
            this.panel8.Controls.Add(this.standardControl87);
            this.panel8.Controls.Add(this.label21);
            this.panel8.Controls.Add(this.standardControl85);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.standardControl84);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.standardControl83);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.standardControl31);
            this.panel8.Controls.Add(this.standardControl59);
            this.panel8.Controls.Add(this.standardControl60);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.standardControl82);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.standardControl80);
            this.panel8.Controls.Add(this.standardControl81);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.standardControl79);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.standardControl76);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.standardControl78);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.standardControl77);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.standardControl74);
            this.panel8.Controls.Add(this.standardControl47);
            this.panel8.Controls.Add(this.standardControl32);
            this.panel8.Controls.Add(this.standardControl46);
            this.panel8.Controls.Add(this.standardControl41);
            this.panel8.Controls.Add(this.standardControl26);
            this.panel8.Controls.Add(this.standardControl25);
            this.panel8.Controls.Add(this.standardControl23);
            this.panel8.Controls.Add(this.standardControl22);
            this.panel8.Controls.Add(this.standardControl24);
            this.panel8.Controls.Add(this.standardControl3);
            this.panel8.Controls.Add(this.standardControl2);
            this.panel8.Controls.Add(this.standardControl1);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.label22);
            this.panel8.Controls.Add(this.standardControl28);
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Controls.Add(this.standardControl69);
            this.panel8.Controls.Add(this.standardControl70);
            this.panel8.Controls.Add(this.standardControl65);
            this.panel8.Controls.Add(this.standardControl49);
            this.panel8.Controls.Add(this.standardControl63);
            this.panel8.Controls.Add(this.standardControl64);
            this.panel8.Controls.Add(this.standardControl57);
            this.panel8.Controls.Add(this.standardControl66);
            this.panel8.Controls.Add(this.standardControl73);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.standardControl44);
            this.panel8.Controls.Add(this.standardControl36);
            this.panel8.Controls.Add(this.standardControl62);
            this.panel8.Controls.Add(this.standardControl39);
            this.panel8.Controls.Add(this.standardControl38);
            this.panel8.Controls.Add(this.standardControl42);
            this.panel8.Controls.Add(this.standardControl37);
            this.panel8.Controls.Add(this.standardControl33);
            this.panel8.Controls.Add(this.standardControl30);
            this.panel8.Controls.Add(this.standardControl54);
            this.panel8.Controls.Add(this.standardControl61);
            this.panel8.Controls.Add(this.standardControl43);
            this.panel8.Controls.Add(this.standardControl35);
            this.panel8.Controls.Add(this.standardControl40);
            this.panel8.Controls.Add(this.standardControl56);
            this.panel8.Controls.Add(this.standardControl48);
            this.panel8.Controls.Add(this.standardControl5);
            this.panel8.Controls.Add(this.standardControl4);
            this.panel8.Controls.Add(this.standardControl6);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1641, 970);
            this.panel8.TabIndex = 281;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(18, 23);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(62, 22);
            this.label51.TabIndex = 167;
            this.label51.Text = "6200T";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(180, 22);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(58, 22);
            this.label53.TabIndex = 167;
            this.label53.Text = "mmm";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(106, 19);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(32, 24);
            this.label52.TabIndex = 168;
            this.label52.Text = "62";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label52);
            this.panel6.Controls.Add(this.label53);
            this.panel6.Controls.Add(this.label51);
            this.panel6.Location = new System.Drawing.Point(1137, 565);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 73);
            this.panel6.TabIndex = 276;
            // 
            // Monitor
            // 
            this.ClientSize = new System.Drawing.Size(1640, 970);
            this.Controls.Add(this.panel8);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monitor";
            this.Load += new System.EventHandler(this.Monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.standardControl45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl77)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl32)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl11)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl28)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl48)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl35)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }
        private IContainer components;
        private Label label46;
        private Label label45;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label27;
        private Label label28;
        private Label label26;
        private Label label25;
        private SymbolFactoryDotNet.StandardControl standardControl45;
        private Label label24;
        private Label label54;
        private SymbolFactoryDotNet.StandardControl standardControl90;
        private Label label55;
        private SymbolFactoryDotNet.StandardControl standardControl91;
        private Label label23;
        private SymbolFactoryDotNet.StandardControl standardControl88;
        private SymbolFactoryDotNet.StandardControl standardControl89;
        private Label label4;
        private SymbolFactoryDotNet.StandardControl standardControl86;
        private SymbolFactoryDotNet.StandardControl standardControl87;
        private Label label21;
        private SymbolFactoryDotNet.StandardControl standardControl85;
        private Label label20;
        private SymbolFactoryDotNet.StandardControl standardControl84;
        private Label label19;
        private Label label18;
        private Label label47;
        private Label label16;
        private SymbolFactoryDotNet.StandardControl standardControl83;
        private Label label17;
        private Label label15;
        private SymbolFactoryDotNet.StandardControl standardControl31;
        private SymbolFactoryDotNet.StandardControl standardControl59;
        private Label label50;
        private SymbolFactoryDotNet.StandardControl standardControl60;
        private Label label57;
        private Label label9;
        private SymbolFactoryDotNet.StandardControl standardControl82;
        private Label label49;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label48;
        private SymbolFactoryDotNet.StandardControl standardControl80;
        private SymbolFactoryDotNet.StandardControl standardControl81;
        private Label label7;
        private SymbolFactoryDotNet.StandardControl standardControl79;
        private Label label8;
        private SymbolFactoryDotNet.StandardControl standardControl76;
        private Label label58;
        private Label label59;
        private Label label6;
        private SymbolFactoryDotNet.StandardControl standardControl78;
        private Label label5;
        private SymbolFactoryDotNet.StandardControl standardControl77;
        private Panel panel4;
        private Label label44;
        private Label label43;
        private Label label42;
        private Label label3;
        private Label label56;
        private SymbolFactoryDotNet.StandardControl standardControl74;
        private SymbolFactoryDotNet.StandardControl standardControl53;
        private SymbolFactoryDotNet.StandardControl standardControl47;
        private SymbolFactoryDotNet.StandardControl standardControl32;
        private Panel panel2;
        private Label label1;
        private SymbolFactoryDotNet.StandardControl standardControl46;
        private SymbolFactoryDotNet.StandardControl standardControl14;
        private SymbolFactoryDotNet.StandardControl standardControl41;
        private SymbolFactoryDotNet.StandardControl standardControl40;
        private SymbolFactoryDotNet.StandardControl standardControl26;
        private SymbolFactoryDotNet.StandardControl standardControl25;
        private SymbolFactoryDotNet.StandardControl standardControl23;
        private SymbolFactoryDotNet.StandardControl standardControl22;
        private SymbolFactoryDotNet.StandardControl standardControl4;
        private SymbolFactoryDotNet.StandardControl standardControl24;
        private SymbolFactoryDotNet.StandardControl standardControl6;
        private SymbolFactoryDotNet.StandardControl standardControl3;
        private SymbolFactoryDotNet.StandardControl standardControl2;
        private SymbolFactoryDotNet.StandardControl standardControl1;
        private SymbolFactoryDotNet.StandardControl standardControl5;
        private Panel panel1;
        private Label label37;
        private Label label36;
        private SymbolFactoryDotNet.StandardControl standardControl58;
        private SymbolFactoryDotNet.StandardControl standardControl55;
        private SymbolFactoryDotNet.StandardControl standardControl52;
        private SymbolFactoryDotNet.StandardControl standardControl51;
        private SymbolFactoryDotNet.StandardControl standardControl50;
        private SymbolFactoryDotNet.StandardControl standardControl27;
        private SymbolFactoryDotNet.StandardControl standardControl15;
        private SymbolFactoryDotNet.StandardControl standardControl16;
        private SymbolFactoryDotNet.StandardControl standardControl12;
        private SymbolFactoryDotNet.StandardControl standardControl21;
        private SymbolFactoryDotNet.StandardControl standardControl20;
        private SymbolFactoryDotNet.StandardControl standardControl18;
        private SymbolFactoryDotNet.StandardControl standardControl17;
        private SymbolFactoryDotNet.StandardControl standardControl7;
        private SymbolFactoryDotNet.StandardControl standardControl10;
        private SymbolFactoryDotNet.StandardControl standardControl9;
        private SymbolFactoryDotNet.StandardControl standardControl8;
        private SymbolFactoryDotNet.StandardControl standardControl19;
        private SymbolFactoryDotNet.StandardControl standardControl13;
        private SymbolFactoryDotNet.StandardControl standardControl11;
        private Label label22;
        private Panel panel5;
        private SymbolFactoryDotNet.StandardControl standardControl28;
        private Panel panel7;
        private Timer timer1;
        private SymbolFactoryDotNet.StandardControl standardControl69;
        private SymbolFactoryDotNet.StandardControl standardControl70;
        private SymbolFactoryDotNet.StandardControl standardControl65;
        private SymbolFactoryDotNet.StandardControl standardControl49;
        private SymbolFactoryDotNet.StandardControl standardControl54;
        private SymbolFactoryDotNet.StandardControl standardControl63;
        private SymbolFactoryDotNet.StandardControl standardControl64;
        private SymbolFactoryDotNet.StandardControl standardControl57;
        private SymbolFactoryDotNet.StandardControl standardControl66;
        private SymbolFactoryDotNet.StandardControl standardControl73;
        private SymbolFactoryDotNet.StandardControl standardControl48;
        private Panel panel3;
        private Label label2;
        private SymbolFactoryDotNet.StandardControl standardControl44;
        private SymbolFactoryDotNet.StandardControl standardControl36;
        private SymbolFactoryDotNet.StandardControl standardControl56;
        private SymbolFactoryDotNet.StandardControl standardControl62;
        private SymbolFactoryDotNet.StandardControl standardControl39;
        private SymbolFactoryDotNet.StandardControl standardControl61;
        private SymbolFactoryDotNet.StandardControl standardControl43;
        private SymbolFactoryDotNet.StandardControl standardControl38;
        private SymbolFactoryDotNet.StandardControl standardControl42;
        private SymbolFactoryDotNet.StandardControl standardControl37;
        private SymbolFactoryDotNet.StandardControl standardControl34;
        private SymbolFactoryDotNet.StandardControl standardControl33;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Dashboard.boolBypassStream1 == false)
            {

                standardControl19.DiscreteValue1 = true;
                standardControl19.DiscreteValue2 = false;
            }
            else {
                standardControl19.DiscreteValue1 = false;
                standardControl19.DiscreteValue2 = true;

            }
            if (Dashboard.boolBypassStream2 == false)
            {

                standardControl7.DiscreteValue1 = true;
                standardControl7.DiscreteValue2 = false;

            }
            else
            {
                standardControl7.DiscreteValue2 = true;
                standardControl7.DiscreteValue1 = false;


            }
            if (Dashboard.boolBypassStream3 == false)
            {

                standardControl12.DiscreteValue1 = true;
                standardControl12.DiscreteValue2 = false;

            }
            else
            {
                standardControl12.DiscreteValue2 = true;
                standardControl12.DiscreteValue1 = false;

            }

           


            if (Dashboard.boolInletStream1 == false)
            {

                standardControl15.DiscreteValue1 = true;
                standardControl15.DiscreteValue2 = false;

            }
            else
            {
                standardControl15.DiscreteValue2 = true;
                standardControl15.DiscreteValue1 = false;

            }
            if (Dashboard.boolInletStream2 == false)
            {

                standardControl16.DiscreteValue1 = true;
                standardControl16.DiscreteValue2 = false;

            }
            else
            {
                standardControl16.DiscreteValue2 = true;
                standardControl16.DiscreteValue1 = false;

            }
            if (Dashboard.boolInletStream3 == false)
            {

                standardControl17.DiscreteValue1 = true;
                standardControl17.DiscreteValue2 = false;

            }
            else
            {
                standardControl17.DiscreteValue2 = true;
                standardControl17.DiscreteValue1 = false;


            }

            label50.Text = Convert.ToString(Convert.ToInt32(Dashboard.DataAi0 * 100) / 100F);
            label54.Text = Convert.ToString(Convert.ToInt32(Dashboard.DataAi1 * 100) / 100F);
            label56.Text = Convert.ToString(Convert.ToInt32(Dashboard.DataAi2 * 100) / 100F);
            label58.Text = Convert.ToString(Convert.ToInt32(Dashboard.DataAi3 * 100) / 100F);
            label52.Text = Convert.ToString(Convert.ToInt32(Dashboard.DataAi4 * 100) / 100F);

            label49.Text = Properties.Settings.Default.UnitAi0;
            label55.Text = Properties.Settings.Default.UnitAi1;
            label57.Text = Properties.Settings.Default.UnitAi2;
            label53.Text = Properties.Settings.Default.UnitAi3;
            label59.Text = Properties.Settings.Default.UnitAi4;

            label48.Text = Properties.Settings.Default.NameAi0;
            label60.Text = Properties.Settings.Default.NameAi1;
            label61.Text = Properties.Settings.Default.NameAi2;
            label62.Text = Properties.Settings.Default.NameAi3;
            label51.Text = Properties.Settings.Default.NameAi4;

        }

        private Label label62;
        private Label label61;
        private Label label60;

        private void Monitor_Load(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private SymbolFactoryDotNet.StandardControl standardControl29;
        private SymbolFactoryDotNet.StandardControl standardControl30;
        private SymbolFactoryDotNet.StandardControl standardControl35;
        private Panel panel8;
        private Panel panel6;
        private Label label52;
        private Label label53;
        private Label label51;
    }
}
