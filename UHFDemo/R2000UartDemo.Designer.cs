﻿namespace UHFDemo
{
    partial class R2000UartDemo
    {
        /// <summary>
        /// The necessary designer variables.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean all using resources.
        /// </summary>
        /// <param name="disposing">If hosting resources should be released,is true,or is false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// The designer support the required method - No
        /// Use the core editor to modify contents of this method.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R2000UartDemo));
            this.tabCtrMain = new System.Windows.Forms.TabControl();
            this.PagReaderSetting = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btReaderSetupRefresh = new System.Windows.Forms.Button();
            this.gbCmdReadGpio = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.rdbGpio3High = new System.Windows.Forms.RadioButton();
            this.rdbGpio3Low = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.rdbGpio4High = new System.Windows.Forms.RadioButton();
            this.rdbGpio4Low = new System.Windows.Forms.RadioButton();
            this.btnWriteGpio4Value = new System.Windows.Forms.Button();
            this.btnWriteGpio3Value = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.rdbGpio1High = new System.Windows.Forms.RadioButton();
            this.rdbGpio1Low = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.rdbGpio2High = new System.Windows.Forms.RadioButton();
            this.rdbGpio2Low = new System.Windows.Forms.RadioButton();
            this.btnReadGpioValue = new System.Windows.Forms.Button();
            this.gbCmdBeeper = new System.Windows.Forms.GroupBox();
            this.btnSetBeeperMode = new System.Windows.Forms.Button();
            this.rdbBeeperModeTag = new System.Windows.Forms.RadioButton();
            this.rdbBeeperModeInventory = new System.Windows.Forms.RadioButton();
            this.rdbBeeperModeSlient = new System.Windows.Forms.RadioButton();
            this.gbCmdTemperature = new System.Windows.Forms.GroupBox();
            this.btnGetReaderTemperature = new System.Windows.Forms.Button();
            this.txtReaderTemperature = new System.Windows.Forms.TextBox();
            this.gbCmdVersion = new System.Windows.Forms.GroupBox();
            this.btnGetFirmwareVersion = new System.Windows.Forms.Button();
            this.txtFirmwareVersion = new System.Windows.Forms.TextBox();
            this.btnResetReader = new System.Windows.Forms.Button();
            this.gbCmdBaudrate = new System.Windows.Forms.GroupBox();
            this.htbGetIdentifier = new CustomControl.HexTextBox();
            this.htbSetIdentifier = new CustomControl.HexTextBox();
            this.btSetIdentifier = new System.Windows.Forms.Button();
            this.btGetIdentifier = new System.Windows.Forms.Button();
            this.gbCmdReaderAddress = new System.Windows.Forms.GroupBox();
            this.htxtReadId = new CustomControl.HexTextBox();
            this.btnSetReadAddress = new System.Windows.Forms.Button();
            this.gbTcpIp = new System.Windows.Forms.GroupBox();
            this.btnDisconnectTcp = new System.Windows.Forms.Button();
            this.txtTcpPort = new System.Windows.Forms.TextBox();
            this.btnConnectTcp = new System.Windows.Forms.Button();
            this.ipIpServer = new CustomControl.IpAddressTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbRS232 = new System.Windows.Forms.GroupBox();
            this.btnSetUartBaudrate = new System.Windows.Forms.Button();
            this.btnDisconnectRs232 = new System.Windows.Forms.Button();
            this.cmbSetBaudrate = new System.Windows.Forms.ComboBox();
            this.lbChangeBaudrate = new System.Windows.Forms.Label();
            this.btnConnectRs232 = new System.Windows.Forms.Button();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbConnectType = new System.Windows.Forms.GroupBox();
            this.rdbTcpIp = new System.Windows.Forms.RadioButton();
            this.rdbRS232 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbReturnLoss = new System.Windows.Forms.GroupBox();
            this.label110 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.cmbReturnLossFreq = new System.Windows.Forms.ComboBox();
            this.label108 = new System.Windows.Forms.Label();
            this.textReturnLoss = new System.Windows.Forms.TextBox();
            this.btReturnLoss = new System.Windows.Forms.Button();
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.btGetProfile = new System.Windows.Forms.Button();
            this.btSetProfile = new System.Windows.Forms.Button();
            this.rdbProfile3 = new System.Windows.Forms.RadioButton();
            this.rdbProfile2 = new System.Windows.Forms.RadioButton();
            this.rdbProfile1 = new System.Windows.Forms.RadioButton();
            this.rdbProfile0 = new System.Windows.Forms.RadioButton();
            this.btRfSetup = new System.Windows.Forms.Button();
            this.gbMonza = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rdbMonzaOff = new System.Windows.Forms.RadioButton();
            this.btSetMonzaStatus = new System.Windows.Forms.Button();
            this.btGetMonzaStatus = new System.Windows.Forms.Button();
            this.rdbMonzaOn = new System.Windows.Forms.RadioButton();
            this.gbCmdAntDetector = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAntDectector = new System.Windows.Forms.TextBox();
            this.btnGetAntDetector = new System.Windows.Forms.Button();
            this.btnSetAntDetector = new System.Windows.Forms.Button();
            this.gbCmdDrm = new System.Windows.Forms.GroupBox();
            this.btnGetDrmMode = new System.Windows.Forms.Button();
            this.btnSetDrmMode = new System.Windows.Forms.Button();
            this.rdbDrmModeClose = new System.Windows.Forms.RadioButton();
            this.rdbDrmModeOpen = new System.Windows.Forms.RadioButton();
            this.gbCmdAntenna = new System.Windows.Forms.GroupBox();
            this.label107 = new System.Windows.Forms.Label();
            this.cmbWorkAnt = new System.Windows.Forms.ComboBox();
            this.btnGetWorkAntenna = new System.Windows.Forms.Button();
            this.btnSetWorkAntenna = new System.Windows.Forms.Button();
            this.gbCmdRegion = new System.Windows.Forms.GroupBox();
            this.cbUserDefineFreq = new System.Windows.Forms.CheckBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label106 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.textFreqQuantity = new System.Windows.Forms.TextBox();
            this.TextFreqInterval = new System.Windows.Forms.TextBox();
            this.textStartFreq = new System.Windows.Forms.TextBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.cmbFrequencyEnd = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbFrequencyStart = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbRegionChn = new System.Windows.Forms.RadioButton();
            this.rdbRegionEtsi = new System.Windows.Forms.RadioButton();
            this.rdbRegionFcc = new System.Windows.Forms.RadioButton();
            this.btnGetFrequencyRegion = new System.Windows.Forms.Button();
            this.btnSetFrequencyRegion = new System.Windows.Forms.Button();
            this.gbCmdOutputPower = new System.Windows.Forms.GroupBox();
            this.btnGetOutputPower = new System.Windows.Forms.Button();
            this.btnSetOutputPower = new System.Windows.Forms.Button();
            this.txtOutputPower = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pageEpcTest = new System.Windows.Forms.TabPage();
            this.tabEpcTest = new System.Windows.Forms.TabControl();
            this.pageRealMode = new System.Windows.Forms.TabPage();
            this.tagsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.cbRealWorkant1 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant4 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant3 = new System.Windows.Forms.CheckBox();
            this.cbRealWorkant2 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textRealRound = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.btRealTimeInventory = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbRealSession = new System.Windows.Forms.CheckBox();
            this.cmbTarget = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.tbRealMinRssi = new System.Windows.Forms.TextBox();
            this.tbRealMaxRssi = new System.Windows.Forms.TextBox();
            this.btRealFresh = new System.Windows.Forms.Button();
            this.label70 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.lbRealTagCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ledReal3 = new LxControl.LxLedControl();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.ledReal5 = new LxControl.LxLedControl();
            this.ledReal2 = new LxControl.LxLedControl();
            this.ledReal4 = new LxControl.LxLedControl();
            this.label53 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.ledReal1 = new LxControl.LxLedControl();
            this.lvRealList = new System.Windows.Forms.ListView();
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageBufferedMode = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btClearBuffer = new System.Windows.Forms.Button();
            this.btQueryBuffer = new System.Windows.Forms.Button();
            this.btGetClearBuffer = new System.Windows.Forms.Button();
            this.btGetBuffer = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btBufferInventory = new System.Windows.Forms.Button();
            this.label85 = new System.Windows.Forms.Label();
            this.textReadRoundBuffer = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbBufferWorkant1 = new System.Windows.Forms.CheckBox();
            this.cbBufferWorkant4 = new System.Windows.Forms.CheckBox();
            this.cbBufferWorkant2 = new System.Windows.Forms.CheckBox();
            this.cbBufferWorkant3 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ledBuffer4 = new LxControl.LxLedControl();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.ledBuffer5 = new LxControl.LxLedControl();
            this.ledBuffer2 = new LxControl.LxLedControl();
            this.ledBuffer3 = new LxControl.LxLedControl();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.ledBuffer1 = new LxControl.LxLedControl();
            this.btBufferFresh = new System.Windows.Forms.Button();
            this.labelBufferTagCount = new System.Windows.Forms.Label();
            this.lvBufferList = new System.Windows.Forms.ListView();
            this.columnHeader49 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader51 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader52 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageFast4AntMode = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ledFast4 = new LxControl.LxLedControl();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.ledFast5 = new LxControl.LxLedControl();
            this.ledFast2 = new LxControl.LxLedControl();
            this.ledFast3 = new LxControl.LxLedControl();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.ledFast1 = new LxControl.LxLedControl();
            this.txtFastMaxRssi = new System.Windows.Forms.TextBox();
            this.txtFastMinRssi = new System.Windows.Forms.TextBox();
            this.buttonFastFresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDStay = new System.Windows.Forms.TextBox();
            this.txtCStay = new System.Windows.Forms.TextBox();
            this.txtBStay = new System.Windows.Forms.TextBox();
            this.txtAStay = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.cmbAntSelect1 = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.cmbAntSelect2 = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.cmbAntSelect3 = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.cmbAntSelect4 = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btFastInventory = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lvFastList = new System.Windows.Forms.ListView();
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label49 = new System.Windows.Forms.Label();
            this.txtFastTagList = new System.Windows.Forms.Label();
            this.pageAcessTag = new System.Windows.Forms.TabPage();
            this.ltvOperate = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbCmdOperateTag = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.btnKillTag = new System.Windows.Forms.Button();
            this.htxtKillPwd = new CustomControl.HexTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.htxtLockPwd = new CustomControl.HexTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.rdbUserMemory = new System.Windows.Forms.RadioButton();
            this.rdbTidMemory = new System.Windows.Forms.RadioButton();
            this.rdbEpcMermory = new System.Windows.Forms.RadioButton();
            this.rdbKillPwd = new System.Windows.Forms.RadioButton();
            this.rdbAccessPwd = new System.Windows.Forms.RadioButton();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.rdbLockEver = new System.Windows.Forms.RadioButton();
            this.rdbFreeEver = new System.Windows.Forms.RadioButton();
            this.rdbLock = new System.Windows.Forms.RadioButton();
            this.rdbFree = new System.Windows.Forms.RadioButton();
            this.btnLockTag = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.htxtWriteData = new CustomControl.HexTextBox();
            this.txtWordCnt = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnWriteTag = new System.Windows.Forms.Button();
            this.btnReadTag = new System.Windows.Forms.Button();
            this.txtWordAdd = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.htxtReadAndWritePwd = new CustomControl.HexTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.rdbUser = new System.Windows.Forms.RadioButton();
            this.rdbTid = new System.Windows.Forms.RadioButton();
            this.rdbEpc = new System.Windows.Forms.RadioButton();
            this.rdbReserved = new System.Windows.Forms.RadioButton();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSetAccessEpcMatch = new System.Windows.Forms.Button();
            this.cmbSetAccessEpcMatch = new System.Windows.Forms.ComboBox();
            this.txtAccessEpcMatch = new System.Windows.Forms.TextBox();
            this.ckAccessEpcMatch = new System.Windows.Forms.CheckBox();
            this.PagISO18000 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInventoryISO18000 = new System.Windows.Forms.Button();
            this.ltvTagISO18000 = new System.Windows.Forms.ListView();
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbISO1800LockQuery = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.htxtQueryAdd = new CustomControl.HexTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.htxtLockAdd = new CustomControl.HexTextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.btnQueryTagISO18000 = new System.Windows.Forms.Button();
            this.btnLockTagISO18000 = new System.Windows.Forms.Button();
            this.gbISO1800ReadWrite = new System.Windows.Forms.GroupBox();
            this.txtLoopTimes = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtLoop = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.htxtWriteData18000 = new CustomControl.HexTextBox();
            this.txtWriteLength = new System.Windows.Forms.TextBox();
            this.htxtReadData18000 = new CustomControl.HexTextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.btnWriteTagISO18000 = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.txtReadLength = new System.Windows.Forms.TextBox();
            this.htxtWriteStartAdd = new CustomControl.HexTextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.htxtReadStartAdd = new CustomControl.HexTextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.btnReadTagISO18000 = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.htxtReadUID = new CustomControl.HexTextBox();
            this.PagTranDataLog = new System.Windows.Forms.TabPage();
            this.gbCmdManual = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.htxtSendData = new CustomControl.HexTextBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSendData = new System.Windows.Forms.Button();
            this.htxtCheckData = new CustomControl.HexTextBox();
            this.lrtxtDataTran = new CustomControl.LogRichTextBox();
            this.pagKimlikDemo = new System.Windows.Forms.TabPage();
            this.kimlikTabControl = new System.Windows.Forms.TabControl();
            this.kimlikImageTabPage = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.backKimlikPanel = new System.Windows.Forms.Panel();
            this.medeniLabel = new System.Windows.Forms.Label();
            this.nufusSerfiLabel = new System.Windows.Forms.Label();
            this.diniLabel = new System.Windows.Forms.Label();
            this.vhkiLabel = new System.Windows.Forms.Label();
            this.kanLabel = new System.Windows.Forms.Label();
            this.verilisTarihiLabel = new System.Windows.Forms.Label();
            this.ilLabel = new System.Windows.Forms.Label();
            this.verilisNedeniLabel = new System.Windows.Forms.Label();
            this.ilceLabel = new System.Windows.Forms.Label();
            this.kayitNoLabel = new System.Windows.Forms.Label();
            this.mahLabel = new System.Windows.Forms.Label();
            this.verildigiLabel = new System.Windows.Forms.Label();
            this.ciltLabel = new System.Windows.Forms.Label();
            this.siraNoLabel = new System.Windows.Forms.Label();
            this.aileSiraNoLabel = new System.Windows.Forms.Label();
            this.backKimlikPicBox = new System.Windows.Forms.PictureBox();
            this.kimlikFrontPanel = new System.Windows.Forms.Panel();
            this.wantedPicBox = new System.Windows.Forms.PictureBox();
            this.seriLabel = new System.Windows.Forms.Label();
            this.adiLabel = new System.Windows.Forms.Label();
            this.tcKimLabel = new System.Windows.Forms.Label();
            this.soyadiLabel = new System.Windows.Forms.Label();
            this.doguTarihLabel = new System.Windows.Forms.Label();
            this.anaAdiLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.babaAdiLabel = new System.Windows.Forms.Label();
            this.doguYeriLabel = new System.Windows.Forms.Label();
            this.imagePicBox = new System.Windows.Forms.PictureBox();
            this.kimlikPicBox = new System.Windows.Forms.PictureBox();
            this.kimlikListTabPage = new System.Windows.Forms.TabPage();
            this.kimlikListPanel = new System.Windows.Forms.Panel();
            this.kimlikDetailsButton = new System.Windows.Forms.Button();
            this.kimlikListDataGridView = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.getAllKimlikFromDbButton = new System.Windows.Forms.Button();
            this.clearKimlikButton = new System.Windows.Forms.Button();
            this.btnStartKimlik = new System.Windows.Forms.Button();
            this.pagInvDemo = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.inventoryMsgsListView = new System.Windows.Forms.ListView();
            this.label15 = new System.Windows.Forms.Label();
            this.pckgPanel = new System.Windows.Forms.Panel();
            this.pckgDataGridView = new System.Windows.Forms.DataGridView();
            this.pckgTitleLabel = new System.Windows.Forms.Label();
            this.itemPanel = new System.Windows.Forms.Panel();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.itemTitleLabel = new System.Windows.Forms.Label();
            this.boxPanel = new System.Windows.Forms.Panel();
            this.boxDataGridView = new System.Windows.Forms.DataGridView();
            this.boxTitleLabel = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnStartExitInventory = new System.Windows.Forms.Button();
            this.chkIntegrityButton = new System.Windows.Forms.Button();
            this.clearInventoryTablesButton = new System.Windows.Forms.Button();
            this.btnStartInventory = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.ckDisplayLog = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.lxLedControl9 = new LxControl.LxLedControl();
            this.lxLedControl10 = new LxControl.LxLedControl();
            this.lxLedControl11 = new LxControl.LxLedControl();
            this.lxLedControl12 = new LxControl.LxLedControl();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.lxLedControl13 = new LxControl.LxLedControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.ckClearOperationRec = new System.Windows.Forms.CheckBox();
            this.lrtxtLog = new CustomControl.LogRichTextBox();
            this.lxLedControl14 = new LxControl.LxLedControl();
            this.lxLedControl15 = new LxControl.LxLedControl();
            this.lxLedControl16 = new LxControl.LxLedControl();
            this.lxLedControl17 = new LxControl.LxLedControl();
            this.lxLedControl18 = new LxControl.LxLedControl();
            this.timerInventory = new System.Windows.Forms.Timer(this.components);
            this.tabCtrMain.SuspendLayout();
            this.PagReaderSetting.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbCmdReadGpio.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbCmdBeeper.SuspendLayout();
            this.gbCmdTemperature.SuspendLayout();
            this.gbCmdVersion.SuspendLayout();
            this.gbCmdBaudrate.SuspendLayout();
            this.gbCmdReaderAddress.SuspendLayout();
            this.gbTcpIp.SuspendLayout();
            this.gbRS232.SuspendLayout();
            this.gbConnectType.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbReturnLoss.SuspendLayout();
            this.gbProfile.SuspendLayout();
            this.gbMonza.SuspendLayout();
            this.gbCmdAntDetector.SuspendLayout();
            this.gbCmdDrm.SuspendLayout();
            this.gbCmdAntenna.SuspendLayout();
            this.gbCmdRegion.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.gbCmdOutputPower.SuspendLayout();
            this.pageEpcTest.SuspendLayout();
            this.tabEpcTest.SuspendLayout();
            this.pageRealMode.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal1)).BeginInit();
            this.pageBufferedMode.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer1)).BeginInit();
            this.pageFast4AntMode.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pageAcessTag.SuspendLayout();
            this.gbCmdOperateTag.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.PagISO18000.SuspendLayout();
            this.gbISO1800LockQuery.SuspendLayout();
            this.gbISO1800ReadWrite.SuspendLayout();
            this.PagTranDataLog.SuspendLayout();
            this.gbCmdManual.SuspendLayout();
            this.pagKimlikDemo.SuspendLayout();
            this.kimlikTabControl.SuspendLayout();
            this.kimlikImageTabPage.SuspendLayout();
            this.panel12.SuspendLayout();
            this.backKimlikPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backKimlikPicBox)).BeginInit();
            this.kimlikFrontPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wantedPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kimlikPicBox)).BeginInit();
            this.kimlikListTabPage.SuspendLayout();
            this.kimlikListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kimlikListDataGridView)).BeginInit();
            this.panel11.SuspendLayout();
            this.pagInvDemo.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.pckgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pckgDataGridView)).BeginInit();
            this.itemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.boxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxDataGridView)).BeginInit();
            this.panel14.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl18)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrMain
            // 
            this.tabCtrMain.Controls.Add(this.PagReaderSetting);
            this.tabCtrMain.Controls.Add(this.pageEpcTest);
            this.tabCtrMain.Controls.Add(this.PagISO18000);
            this.tabCtrMain.Controls.Add(this.PagTranDataLog);
            this.tabCtrMain.Controls.Add(this.pagKimlikDemo);
            this.tabCtrMain.Controls.Add(this.pagInvDemo);
            this.tabCtrMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabCtrMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrMain.Name = "tabCtrMain";
            this.tabCtrMain.SelectedIndex = 0;
            this.tabCtrMain.Size = new System.Drawing.Size(1018, 629);
            this.tabCtrMain.TabIndex = 0;
            this.tabCtrMain.SelectedIndexChanged += new System.EventHandler(this.tabCtrMain_SelectedIndexChanged);
            this.tabCtrMain.Click += new System.EventHandler(this.tabCtrMain_Click);
            // 
            // PagReaderSetting
            // 
            this.PagReaderSetting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PagReaderSetting.Controls.Add(this.tabControl1);
            this.PagReaderSetting.Location = new System.Drawing.Point(4, 22);
            this.PagReaderSetting.Name = "PagReaderSetting";
            this.PagReaderSetting.Padding = new System.Windows.Forms.Padding(3);
            this.PagReaderSetting.Size = new System.Drawing.Size(1010, 603);
            this.PagReaderSetting.TabIndex = 0;
            this.PagReaderSetting.Text = "Reader Setup";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(3, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 593);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.btReaderSetupRefresh);
            this.tabPage1.Controls.Add(this.gbCmdReadGpio);
            this.tabPage1.Controls.Add(this.gbCmdBeeper);
            this.tabPage1.Controls.Add(this.gbCmdTemperature);
            this.tabPage1.Controls.Add(this.gbCmdVersion);
            this.tabPage1.Controls.Add(this.btnResetReader);
            this.tabPage1.Controls.Add(this.gbCmdBaudrate);
            this.tabPage1.Controls.Add(this.gbCmdReaderAddress);
            this.tabPage1.Controls.Add(this.gbTcpIp);
            this.tabPage1.Controls.Add(this.gbRS232);
            this.tabPage1.Controls.Add(this.gbConnectType);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Setup";
            // 
            // btReaderSetupRefresh
            // 
            this.btReaderSetupRefresh.Location = new System.Drawing.Point(857, 514);
            this.btReaderSetupRefresh.Name = "btReaderSetupRefresh";
            this.btReaderSetupRefresh.Size = new System.Drawing.Size(89, 25);
            this.btReaderSetupRefresh.TabIndex = 15;
            this.btReaderSetupRefresh.Text = "Refresh";
            this.btReaderSetupRefresh.UseVisualStyleBackColor = true;
            this.btReaderSetupRefresh.Click += new System.EventHandler(this.btReaderSetupRefresh_Click);
            // 
            // gbCmdReadGpio
            // 
            this.gbCmdReadGpio.Controls.Add(this.groupBox11);
            this.gbCmdReadGpio.Controls.Add(this.groupBox10);
            this.gbCmdReadGpio.ForeColor = System.Drawing.Color.Black;
            this.gbCmdReadGpio.Location = new System.Drawing.Point(463, 130);
            this.gbCmdReadGpio.Name = "gbCmdReadGpio";
            this.gbCmdReadGpio.Size = new System.Drawing.Size(519, 252);
            this.gbCmdReadGpio.TabIndex = 12;
            this.gbCmdReadGpio.TabStop = false;
            this.gbCmdReadGpio.Text = "Read/Write GPIO";
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Transparent;
            this.groupBox11.Controls.Add(this.groupBox6);
            this.groupBox11.Controls.Add(this.groupBox7);
            this.groupBox11.Controls.Add(this.btnWriteGpio4Value);
            this.groupBox11.Controls.Add(this.btnWriteGpio3Value);
            this.groupBox11.ForeColor = System.Drawing.Color.Black;
            this.groupBox11.Location = new System.Drawing.Point(16, 131);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(485, 106);
            this.groupBox11.TabIndex = 13;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Write GPIO";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.rdbGpio3High);
            this.groupBox6.Controls.Add(this.rdbGpio3Low);
            this.groupBox6.Location = new System.Drawing.Point(56, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(245, 31);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(31, 12);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(42, 13);
            this.label33.TabIndex = 6;
            this.label33.Text = "GPIO3:";
            // 
            // rdbGpio3High
            // 
            this.rdbGpio3High.AutoSize = true;
            this.rdbGpio3High.Location = new System.Drawing.Point(78, 11);
            this.rdbGpio3High.Name = "rdbGpio3High";
            this.rdbGpio3High.Size = new System.Drawing.Size(47, 17);
            this.rdbGpio3High.TabIndex = 6;
            this.rdbGpio3High.TabStop = true;
            this.rdbGpio3High.Text = "High";
            this.rdbGpio3High.UseVisualStyleBackColor = true;
            // 
            // rdbGpio3Low
            // 
            this.rdbGpio3Low.AutoSize = true;
            this.rdbGpio3Low.Location = new System.Drawing.Point(161, 11);
            this.rdbGpio3Low.Name = "rdbGpio3Low";
            this.rdbGpio3Low.Size = new System.Drawing.Size(45, 17);
            this.rdbGpio3Low.TabIndex = 0;
            this.rdbGpio3Low.TabStop = true;
            this.rdbGpio3Low.Text = "Low";
            this.rdbGpio3Low.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.rdbGpio4High);
            this.groupBox7.Controls.Add(this.rdbGpio4Low);
            this.groupBox7.Location = new System.Drawing.Point(56, 59);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(245, 33);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(30, 13);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(42, 13);
            this.label32.TabIndex = 9;
            this.label32.Text = "GPIO4:";
            // 
            // rdbGpio4High
            // 
            this.rdbGpio4High.AutoSize = true;
            this.rdbGpio4High.Location = new System.Drawing.Point(77, 11);
            this.rdbGpio4High.Name = "rdbGpio4High";
            this.rdbGpio4High.Size = new System.Drawing.Size(47, 17);
            this.rdbGpio4High.TabIndex = 1;
            this.rdbGpio4High.TabStop = true;
            this.rdbGpio4High.Text = "High";
            this.rdbGpio4High.UseVisualStyleBackColor = true;
            // 
            // rdbGpio4Low
            // 
            this.rdbGpio4Low.AutoSize = true;
            this.rdbGpio4Low.Location = new System.Drawing.Point(161, 11);
            this.rdbGpio4Low.Name = "rdbGpio4Low";
            this.rdbGpio4Low.Size = new System.Drawing.Size(45, 17);
            this.rdbGpio4Low.TabIndex = 2;
            this.rdbGpio4Low.TabStop = true;
            this.rdbGpio4Low.Text = "Low";
            this.rdbGpio4Low.UseVisualStyleBackColor = true;
            this.rdbGpio4Low.CheckedChanged += new System.EventHandler(this.rdbGpio4Low_CheckedChanged);
            // 
            // btnWriteGpio4Value
            // 
            this.btnWriteGpio4Value.Location = new System.Drawing.Point(378, 66);
            this.btnWriteGpio4Value.Name = "btnWriteGpio4Value";
            this.btnWriteGpio4Value.Size = new System.Drawing.Size(90, 25);
            this.btnWriteGpio4Value.TabIndex = 5;
            this.btnWriteGpio4Value.Text = "Write GPIO4";
            this.btnWriteGpio4Value.UseVisualStyleBackColor = true;
            this.btnWriteGpio4Value.Click += new System.EventHandler(this.btnWriteGpio4Value_Click);
            // 
            // btnWriteGpio3Value
            // 
            this.btnWriteGpio3Value.Location = new System.Drawing.Point(378, 26);
            this.btnWriteGpio3Value.Name = "btnWriteGpio3Value";
            this.btnWriteGpio3Value.Size = new System.Drawing.Size(90, 25);
            this.btnWriteGpio3Value.TabIndex = 10;
            this.btnWriteGpio3Value.Text = "Write GPIO3";
            this.btnWriteGpio3Value.UseVisualStyleBackColor = true;
            this.btnWriteGpio3Value.Click += new System.EventHandler(this.btnWriteGpio3Value_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox4);
            this.groupBox10.Controls.Add(this.groupBox5);
            this.groupBox10.Controls.Add(this.btnReadGpioValue);
            this.groupBox10.ForeColor = System.Drawing.Color.Black;
            this.groupBox10.Location = new System.Drawing.Point(17, 18);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(485, 106);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Read GPIO";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.rdbGpio1High);
            this.groupBox4.Controls.Add(this.rdbGpio1Low);
            this.groupBox4.Location = new System.Drawing.Point(53, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 33);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(31, 15);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "GPIO1:";
            // 
            // rdbGpio1High
            // 
            this.rdbGpio1High.AutoSize = true;
            this.rdbGpio1High.Location = new System.Drawing.Point(78, 13);
            this.rdbGpio1High.Name = "rdbGpio1High";
            this.rdbGpio1High.Size = new System.Drawing.Size(47, 17);
            this.rdbGpio1High.TabIndex = 1;
            this.rdbGpio1High.TabStop = true;
            this.rdbGpio1High.Text = "High";
            this.rdbGpio1High.UseVisualStyleBackColor = true;
            // 
            // rdbGpio1Low
            // 
            this.rdbGpio1Low.AutoSize = true;
            this.rdbGpio1Low.Location = new System.Drawing.Point(163, 13);
            this.rdbGpio1Low.Name = "rdbGpio1Low";
            this.rdbGpio1Low.Size = new System.Drawing.Size(45, 17);
            this.rdbGpio1Low.TabIndex = 2;
            this.rdbGpio1Low.TabStop = true;
            this.rdbGpio1Low.Text = "Low";
            this.rdbGpio1Low.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.rdbGpio2High);
            this.groupBox5.Controls.Add(this.rdbGpio2Low);
            this.groupBox5.Location = new System.Drawing.Point(53, 60);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(247, 33);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(30, 15);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(42, 13);
            this.label31.TabIndex = 3;
            this.label31.Text = "GPIO2:";
            // 
            // rdbGpio2High
            // 
            this.rdbGpio2High.AutoSize = true;
            this.rdbGpio2High.Location = new System.Drawing.Point(77, 13);
            this.rdbGpio2High.Name = "rdbGpio2High";
            this.rdbGpio2High.Size = new System.Drawing.Size(47, 17);
            this.rdbGpio2High.TabIndex = 4;
            this.rdbGpio2High.TabStop = true;
            this.rdbGpio2High.Text = "High";
            this.rdbGpio2High.UseVisualStyleBackColor = true;
            // 
            // rdbGpio2Low
            // 
            this.rdbGpio2Low.AutoSize = true;
            this.rdbGpio2Low.Location = new System.Drawing.Point(163, 13);
            this.rdbGpio2Low.Name = "rdbGpio2Low";
            this.rdbGpio2Low.Size = new System.Drawing.Size(45, 17);
            this.rdbGpio2Low.TabIndex = 5;
            this.rdbGpio2Low.TabStop = true;
            this.rdbGpio2Low.Text = "Low";
            this.rdbGpio2Low.UseVisualStyleBackColor = true;
            // 
            // btnReadGpioValue
            // 
            this.btnReadGpioValue.Location = new System.Drawing.Point(377, 67);
            this.btnReadGpioValue.Name = "btnReadGpioValue";
            this.btnReadGpioValue.Size = new System.Drawing.Size(90, 25);
            this.btnReadGpioValue.TabIndex = 0;
            this.btnReadGpioValue.Text = "Read";
            this.btnReadGpioValue.UseVisualStyleBackColor = true;
            this.btnReadGpioValue.Click += new System.EventHandler(this.btnReadGpioValue_Click);
            // 
            // gbCmdBeeper
            // 
            this.gbCmdBeeper.Controls.Add(this.btnSetBeeperMode);
            this.gbCmdBeeper.Controls.Add(this.rdbBeeperModeTag);
            this.gbCmdBeeper.Controls.Add(this.rdbBeeperModeInventory);
            this.gbCmdBeeper.Controls.Add(this.rdbBeeperModeSlient);
            this.gbCmdBeeper.ForeColor = System.Drawing.Color.Black;
            this.gbCmdBeeper.Location = new System.Drawing.Point(463, 389);
            this.gbCmdBeeper.Name = "gbCmdBeeper";
            this.gbCmdBeeper.Size = new System.Drawing.Size(519, 104);
            this.gbCmdBeeper.TabIndex = 11;
            this.gbCmdBeeper.TabStop = false;
            this.gbCmdBeeper.Text = "Buzzer Behavior";
            // 
            // btnSetBeeperMode
            // 
            this.btnSetBeeperMode.Location = new System.Drawing.Point(394, 64);
            this.btnSetBeeperMode.Name = "btnSetBeeperMode";
            this.btnSetBeeperMode.Size = new System.Drawing.Size(90, 25);
            this.btnSetBeeperMode.TabIndex = 3;
            this.btnSetBeeperMode.Text = "Set";
            this.btnSetBeeperMode.UseVisualStyleBackColor = true;
            this.btnSetBeeperMode.Click += new System.EventHandler(this.btnSetBeeperMode_Click);
            // 
            // rdbBeeperModeTag
            // 
            this.rdbBeeperModeTag.AutoSize = true;
            this.rdbBeeperModeTag.Location = new System.Drawing.Point(71, 74);
            this.rdbBeeperModeTag.Name = "rdbBeeperModeTag";
            this.rdbBeeperModeTag.Size = new System.Drawing.Size(222, 17);
            this.rdbBeeperModeTag.TabIndex = 2;
            this.rdbBeeperModeTag.TabStop = true;
            this.rdbBeeperModeTag.Text = "Beep after a tag is identified.(For test only)";
            this.rdbBeeperModeTag.UseVisualStyleBackColor = true;
            // 
            // rdbBeeperModeInventory
            // 
            this.rdbBeeperModeInventory.AutoSize = true;
            this.rdbBeeperModeInventory.Location = new System.Drawing.Point(71, 48);
            this.rdbBeeperModeInventory.Name = "rdbBeeperModeInventory";
            this.rdbBeeperModeInventory.Size = new System.Drawing.Size(165, 17);
            this.rdbBeeperModeInventory.TabIndex = 1;
            this.rdbBeeperModeInventory.TabStop = true;
            this.rdbBeeperModeInventory.Text = "Beep after an inventory round";
            this.rdbBeeperModeInventory.UseVisualStyleBackColor = true;
            // 
            // rdbBeeperModeSlient
            // 
            this.rdbBeeperModeSlient.AutoSize = true;
            this.rdbBeeperModeSlient.Location = new System.Drawing.Point(71, 22);
            this.rdbBeeperModeSlient.Name = "rdbBeeperModeSlient";
            this.rdbBeeperModeSlient.Size = new System.Drawing.Size(50, 17);
            this.rdbBeeperModeSlient.TabIndex = 0;
            this.rdbBeeperModeSlient.TabStop = true;
            this.rdbBeeperModeSlient.Text = "Quiet";
            this.rdbBeeperModeSlient.UseVisualStyleBackColor = true;
            // 
            // gbCmdTemperature
            // 
            this.gbCmdTemperature.Controls.Add(this.btnGetReaderTemperature);
            this.gbCmdTemperature.Controls.Add(this.txtReaderTemperature);
            this.gbCmdTemperature.ForeColor = System.Drawing.Color.Black;
            this.gbCmdTemperature.Location = new System.Drawing.Point(463, 70);
            this.gbCmdTemperature.Name = "gbCmdTemperature";
            this.gbCmdTemperature.Size = new System.Drawing.Size(519, 53);
            this.gbCmdTemperature.TabIndex = 10;
            this.gbCmdTemperature.TabStop = false;
            this.gbCmdTemperature.Text = "Internal Temperature";
            // 
            // btnGetReaderTemperature
            // 
            this.btnGetReaderTemperature.Location = new System.Drawing.Point(393, 18);
            this.btnGetReaderTemperature.Name = "btnGetReaderTemperature";
            this.btnGetReaderTemperature.Size = new System.Drawing.Size(90, 25);
            this.btnGetReaderTemperature.TabIndex = 0;
            this.btnGetReaderTemperature.Text = "Get";
            this.btnGetReaderTemperature.UseVisualStyleBackColor = true;
            this.btnGetReaderTemperature.Click += new System.EventHandler(this.btnGetReaderTemperature_Click);
            // 
            // txtReaderTemperature
            // 
            this.txtReaderTemperature.Location = new System.Drawing.Point(106, 18);
            this.txtReaderTemperature.Name = "txtReaderTemperature";
            this.txtReaderTemperature.ReadOnly = true;
            this.txtReaderTemperature.Size = new System.Drawing.Size(120, 20);
            this.txtReaderTemperature.TabIndex = 1;
            this.txtReaderTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbCmdVersion
            // 
            this.gbCmdVersion.Controls.Add(this.btnGetFirmwareVersion);
            this.gbCmdVersion.Controls.Add(this.txtFirmwareVersion);
            this.gbCmdVersion.ForeColor = System.Drawing.Color.Black;
            this.gbCmdVersion.Location = new System.Drawing.Point(463, 16);
            this.gbCmdVersion.Name = "gbCmdVersion";
            this.gbCmdVersion.Size = new System.Drawing.Size(519, 48);
            this.gbCmdVersion.TabIndex = 9;
            this.gbCmdVersion.TabStop = false;
            this.gbCmdVersion.Text = "Firmware Version";
            // 
            // btnGetFirmwareVersion
            // 
            this.btnGetFirmwareVersion.Location = new System.Drawing.Point(394, 15);
            this.btnGetFirmwareVersion.Name = "btnGetFirmwareVersion";
            this.btnGetFirmwareVersion.Size = new System.Drawing.Size(90, 25);
            this.btnGetFirmwareVersion.TabIndex = 0;
            this.btnGetFirmwareVersion.Text = "Get";
            this.btnGetFirmwareVersion.UseVisualStyleBackColor = true;
            this.btnGetFirmwareVersion.Click += new System.EventHandler(this.btnGetFirmwareVersion_Click);
            // 
            // txtFirmwareVersion
            // 
            this.txtFirmwareVersion.Location = new System.Drawing.Point(105, 17);
            this.txtFirmwareVersion.Name = "txtFirmwareVersion";
            this.txtFirmwareVersion.ReadOnly = true;
            this.txtFirmwareVersion.Size = new System.Drawing.Size(121, 20);
            this.txtFirmwareVersion.TabIndex = 1;
            this.txtFirmwareVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnResetReader
            // 
            this.btnResetReader.Location = new System.Drawing.Point(10, 504);
            this.btnResetReader.Name = "btnResetReader";
            this.btnResetReader.Size = new System.Drawing.Size(434, 44);
            this.btnResetReader.TabIndex = 8;
            this.btnResetReader.Text = "Reset Reader";
            this.btnResetReader.UseVisualStyleBackColor = true;
            this.btnResetReader.Click += new System.EventHandler(this.btnResetReader_Click);
            // 
            // gbCmdBaudrate
            // 
            this.gbCmdBaudrate.Controls.Add(this.htbGetIdentifier);
            this.gbCmdBaudrate.Controls.Add(this.htbSetIdentifier);
            this.gbCmdBaudrate.Controls.Add(this.btSetIdentifier);
            this.gbCmdBaudrate.Controls.Add(this.btGetIdentifier);
            this.gbCmdBaudrate.ForeColor = System.Drawing.Color.Black;
            this.gbCmdBaudrate.Location = new System.Drawing.Point(10, 389);
            this.gbCmdBaudrate.Name = "gbCmdBaudrate";
            this.gbCmdBaudrate.Size = new System.Drawing.Size(434, 104);
            this.gbCmdBaudrate.TabIndex = 7;
            this.gbCmdBaudrate.TabStop = false;
            this.gbCmdBaudrate.Text = "Reader Identifier(12 Bytes)";
            // 
            // htbGetIdentifier
            // 
            this.htbGetIdentifier.Location = new System.Drawing.Point(34, 24);
            this.htbGetIdentifier.Name = "htbGetIdentifier";
            this.htbGetIdentifier.ReadOnly = true;
            this.htbGetIdentifier.Size = new System.Drawing.Size(228, 20);
            this.htbGetIdentifier.TabIndex = 13;
            this.htbGetIdentifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // htbSetIdentifier
            // 
            this.htbSetIdentifier.Location = new System.Drawing.Point(34, 66);
            this.htbSetIdentifier.Name = "htbSetIdentifier";
            this.htbSetIdentifier.Size = new System.Drawing.Size(228, 20);
            this.htbSetIdentifier.TabIndex = 12;
            this.htbSetIdentifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSetIdentifier
            // 
            this.btSetIdentifier.Location = new System.Drawing.Point(314, 65);
            this.btSetIdentifier.Name = "btSetIdentifier";
            this.btSetIdentifier.Size = new System.Drawing.Size(90, 25);
            this.btSetIdentifier.TabIndex = 1;
            this.btSetIdentifier.Text = "Set";
            this.btSetIdentifier.UseVisualStyleBackColor = true;
            this.btSetIdentifier.Click += new System.EventHandler(this.btSetIdentifier_Click);
            // 
            // btGetIdentifier
            // 
            this.btGetIdentifier.Location = new System.Drawing.Point(314, 23);
            this.btGetIdentifier.Name = "btGetIdentifier";
            this.btGetIdentifier.Size = new System.Drawing.Size(90, 25);
            this.btGetIdentifier.TabIndex = 0;
            this.btGetIdentifier.Text = "Get";
            this.btGetIdentifier.UseVisualStyleBackColor = true;
            this.btGetIdentifier.Click += new System.EventHandler(this.btGetIdentifier_Click);
            // 
            // gbCmdReaderAddress
            // 
            this.gbCmdReaderAddress.Controls.Add(this.htxtReadId);
            this.gbCmdReaderAddress.Controls.Add(this.btnSetReadAddress);
            this.gbCmdReaderAddress.ForeColor = System.Drawing.Color.Black;
            this.gbCmdReaderAddress.Location = new System.Drawing.Point(10, 311);
            this.gbCmdReaderAddress.Name = "gbCmdReaderAddress";
            this.gbCmdReaderAddress.Size = new System.Drawing.Size(434, 72);
            this.gbCmdReaderAddress.TabIndex = 5;
            this.gbCmdReaderAddress.TabStop = false;
            this.gbCmdReaderAddress.Text = "RS-485 Address(HEX)";
            // 
            // htxtReadId
            // 
            this.htxtReadId.Location = new System.Drawing.Point(114, 27);
            this.htxtReadId.Name = "htxtReadId";
            this.htxtReadId.Size = new System.Drawing.Size(121, 20);
            this.htxtReadId.TabIndex = 2;
            this.htxtReadId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetReadAddress
            // 
            this.btnSetReadAddress.Location = new System.Drawing.Point(314, 28);
            this.btnSetReadAddress.Name = "btnSetReadAddress";
            this.btnSetReadAddress.Size = new System.Drawing.Size(90, 25);
            this.btnSetReadAddress.TabIndex = 1;
            this.btnSetReadAddress.Text = "Set";
            this.btnSetReadAddress.UseVisualStyleBackColor = true;
            this.btnSetReadAddress.Click += new System.EventHandler(this.btnSetReadAddress_Click);
            // 
            // gbTcpIp
            // 
            this.gbTcpIp.Controls.Add(this.btnDisconnectTcp);
            this.gbTcpIp.Controls.Add(this.txtTcpPort);
            this.gbTcpIp.Controls.Add(this.btnConnectTcp);
            this.gbTcpIp.Controls.Add(this.ipIpServer);
            this.gbTcpIp.Controls.Add(this.label4);
            this.gbTcpIp.Controls.Add(this.label3);
            this.gbTcpIp.Location = new System.Drawing.Point(10, 213);
            this.gbTcpIp.Name = "gbTcpIp";
            this.gbTcpIp.Size = new System.Drawing.Size(434, 91);
            this.gbTcpIp.TabIndex = 3;
            this.gbTcpIp.TabStop = false;
            this.gbTcpIp.Text = "TCP/IP";
            // 
            // btnDisconnectTcp
            // 
            this.btnDisconnectTcp.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisconnectTcp.Location = new System.Drawing.Point(314, 55);
            this.btnDisconnectTcp.Name = "btnDisconnectTcp";
            this.btnDisconnectTcp.Size = new System.Drawing.Size(90, 25);
            this.btnDisconnectTcp.TabIndex = 3;
            this.btnDisconnectTcp.Text = "Disconnect";
            this.btnDisconnectTcp.UseVisualStyleBackColor = true;
            this.btnDisconnectTcp.Click += new System.EventHandler(this.btnDisconnectTcp_Click);
            // 
            // txtTcpPort
            // 
            this.txtTcpPort.Location = new System.Drawing.Point(114, 56);
            this.txtTcpPort.Name = "txtTcpPort";
            this.txtTcpPort.Size = new System.Drawing.Size(120, 20);
            this.txtTcpPort.TabIndex = 1;
            this.txtTcpPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnectTcp
            // 
            this.btnConnectTcp.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnectTcp.Location = new System.Drawing.Point(314, 21);
            this.btnConnectTcp.Name = "btnConnectTcp";
            this.btnConnectTcp.Size = new System.Drawing.Size(90, 25);
            this.btnConnectTcp.TabIndex = 2;
            this.btnConnectTcp.Text = "Connect";
            this.btnConnectTcp.UseVisualStyleBackColor = true;
            this.btnConnectTcp.Click += new System.EventHandler(this.btnConnectTcp_Click);
            // 
            // ipIpServer
            // 
            this.ipIpServer.IpAddressStr = "";
            this.ipIpServer.Location = new System.Drawing.Point(114, 22);
            this.ipIpServer.Name = "ipIpServer";
            this.ipIpServer.Size = new System.Drawing.Size(120, 23);
            this.ipIpServer.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reader IP Add:";
            // 
            // gbRS232
            // 
            this.gbRS232.Controls.Add(this.btnSetUartBaudrate);
            this.gbRS232.Controls.Add(this.btnDisconnectRs232);
            this.gbRS232.Controls.Add(this.cmbSetBaudrate);
            this.gbRS232.Controls.Add(this.lbChangeBaudrate);
            this.gbRS232.Controls.Add(this.btnConnectRs232);
            this.gbRS232.Controls.Add(this.cmbBaudrate);
            this.gbRS232.Controls.Add(this.cmbComPort);
            this.gbRS232.Controls.Add(this.label2);
            this.gbRS232.Controls.Add(this.label1);
            this.gbRS232.Location = new System.Drawing.Point(10, 70);
            this.gbRS232.Name = "gbRS232";
            this.gbRS232.Size = new System.Drawing.Size(434, 134);
            this.gbRS232.TabIndex = 2;
            this.gbRS232.TabStop = false;
            this.gbRS232.Text = "RS-232";
            // 
            // btnSetUartBaudrate
            // 
            this.btnSetUartBaudrate.Location = new System.Drawing.Point(315, 101);
            this.btnSetUartBaudrate.Name = "btnSetUartBaudrate";
            this.btnSetUartBaudrate.Size = new System.Drawing.Size(90, 25);
            this.btnSetUartBaudrate.TabIndex = 1;
            this.btnSetUartBaudrate.Text = "Set";
            this.btnSetUartBaudrate.UseVisualStyleBackColor = true;
            this.btnSetUartBaudrate.Click += new System.EventHandler(this.btnSetUartBaudrate_Click);
            // 
            // btnDisconnectRs232
            // 
            this.btnDisconnectRs232.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisconnectRs232.Location = new System.Drawing.Point(314, 53);
            this.btnDisconnectRs232.Name = "btnDisconnectRs232";
            this.btnDisconnectRs232.Size = new System.Drawing.Size(90, 25);
            this.btnDisconnectRs232.TabIndex = 3;
            this.btnDisconnectRs232.Text = "Disconnect";
            this.btnDisconnectRs232.UseVisualStyleBackColor = true;
            this.btnDisconnectRs232.Click += new System.EventHandler(this.btnDisconnectRs232_Click);
            // 
            // cmbSetBaudrate
            // 
            this.cmbSetBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetBaudrate.FormattingEnabled = true;
            this.cmbSetBaudrate.Items.AddRange(new object[] {
            "38400",
            "115200"});
            this.cmbSetBaudrate.Location = new System.Drawing.Point(114, 102);
            this.cmbSetBaudrate.Name = "cmbSetBaudrate";
            this.cmbSetBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cmbSetBaudrate.TabIndex = 0;
            // 
            // lbChangeBaudrate
            // 
            this.lbChangeBaudrate.AutoSize = true;
            this.lbChangeBaudrate.Location = new System.Drawing.Point(27, 106);
            this.lbChangeBaudrate.Name = "lbChangeBaudrate";
            this.lbChangeBaudrate.Size = new System.Drawing.Size(72, 13);
            this.lbChangeBaudrate.TabIndex = 0;
            this.lbChangeBaudrate.Text = "Set Baudrate:";
            // 
            // btnConnectRs232
            // 
            this.btnConnectRs232.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnectRs232.Location = new System.Drawing.Point(314, 16);
            this.btnConnectRs232.Name = "btnConnectRs232";
            this.btnConnectRs232.Size = new System.Drawing.Size(90, 25);
            this.btnConnectRs232.TabIndex = 2;
            this.btnConnectRs232.Text = "Connect";
            this.btnConnectRs232.UseVisualStyleBackColor = true;
            this.btnConnectRs232.Click += new System.EventHandler(this.btnConnectRs232_Click);
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            "38400",
            "115200"});
            this.cmbBaudrate.Location = new System.Drawing.Point(113, 54);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cmbBaudrate.TabIndex = 1;
            // 
            // cmbComPort
            // 
            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16"});
            this.cmbComPort.Location = new System.Drawing.Point(113, 17);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(121, 21);
            this.cmbComPort.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Port:";
            // 
            // gbConnectType
            // 
            this.gbConnectType.Controls.Add(this.rdbTcpIp);
            this.gbConnectType.Controls.Add(this.rdbRS232);
            this.gbConnectType.Location = new System.Drawing.Point(10, 16);
            this.gbConnectType.Name = "gbConnectType";
            this.gbConnectType.Size = new System.Drawing.Size(434, 48);
            this.gbConnectType.TabIndex = 1;
            this.gbConnectType.TabStop = false;
            this.gbConnectType.Text = "Connection";
            // 
            // rdbTcpIp
            // 
            this.rdbTcpIp.AutoSize = true;
            this.rdbTcpIp.Location = new System.Drawing.Point(264, 18);
            this.rdbTcpIp.Name = "rdbTcpIp";
            this.rdbTcpIp.Size = new System.Drawing.Size(61, 17);
            this.rdbTcpIp.TabIndex = 1;
            this.rdbTcpIp.TabStop = true;
            this.rdbTcpIp.Text = "TCP/IP";
            this.rdbTcpIp.UseVisualStyleBackColor = true;
            this.rdbTcpIp.CheckedChanged += new System.EventHandler(this.rdbTcpIp_CheckedChanged);
            // 
            // rdbRS232
            // 
            this.rdbRS232.AutoSize = true;
            this.rdbRS232.Location = new System.Drawing.Point(109, 18);
            this.rdbRS232.Name = "rdbRS232";
            this.rdbRS232.Size = new System.Drawing.Size(58, 17);
            this.rdbRS232.TabIndex = 0;
            this.rdbRS232.TabStop = true;
            this.rdbRS232.Text = "RS232";
            this.rdbRS232.UseVisualStyleBackColor = true;
            this.rdbRS232.CheckedChanged += new System.EventHandler(this.rdbRS232_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.gbReturnLoss);
            this.tabPage2.Controls.Add(this.gbProfile);
            this.tabPage2.Controls.Add(this.btRfSetup);
            this.tabPage2.Controls.Add(this.gbMonza);
            this.tabPage2.Controls.Add(this.gbCmdAntDetector);
            this.tabPage2.Controls.Add(this.gbCmdDrm);
            this.tabPage2.Controls.Add(this.gbCmdAntenna);
            this.tabPage2.Controls.Add(this.gbCmdRegion);
            this.tabPage2.Controls.Add(this.gbCmdOutputPower);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RF Setup";
            // 
            // gbReturnLoss
            // 
            this.gbReturnLoss.BackColor = System.Drawing.Color.Transparent;
            this.gbReturnLoss.Controls.Add(this.label110);
            this.gbReturnLoss.Controls.Add(this.label109);
            this.gbReturnLoss.Controls.Add(this.cmbReturnLossFreq);
            this.gbReturnLoss.Controls.Add(this.label108);
            this.gbReturnLoss.Controls.Add(this.textReturnLoss);
            this.gbReturnLoss.Controls.Add(this.btReturnLoss);
            this.gbReturnLoss.ForeColor = System.Drawing.Color.Black;
            this.gbReturnLoss.Location = new System.Drawing.Point(505, 72);
            this.gbReturnLoss.Name = "gbReturnLoss";
            this.gbReturnLoss.Size = new System.Drawing.Size(477, 50);
            this.gbReturnLoss.TabIndex = 19;
            this.gbReturnLoss.TabStop = false;
            this.gbReturnLoss.Text = "Measure RF Port Return Loss";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(156, 24);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(18, 13);
            this.label110.TabIndex = 15;
            this.label110.Text = "@";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(250, 24);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(29, 13);
            this.label109.TabIndex = 14;
            this.label109.Text = "MHz";
            // 
            // cmbReturnLossFreq
            // 
            this.cmbReturnLossFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReturnLossFreq.FormattingEnabled = true;
            this.cmbReturnLossFreq.Items.AddRange(new object[] {
            "865.00",
            "865.50",
            "866.00",
            "866.50",
            "867.00",
            "867.50",
            "868.00",
            "902.00",
            "902.50",
            "903.00",
            "903.50",
            "904.00",
            "904.50",
            "905.00",
            "905.50",
            "906.00",
            "906.50",
            "907.00",
            "907.50",
            "908.00",
            "908.50",
            "909.00",
            "909.50",
            "910.00",
            "910.50",
            "911.00",
            "911.50",
            "912.00",
            "912.50",
            "913.00",
            "913.50",
            "914.00",
            "914.50",
            "915.00",
            "915.50",
            "916.00",
            "916.50",
            "917.00",
            "917.50",
            "918.00",
            "918.50",
            "919.00",
            "919.50",
            "920.00",
            "920.50",
            "921.00",
            "921.50",
            "922.00",
            "922.50",
            "923.00",
            "923.50",
            "924.00",
            "924.50",
            "925.00",
            "925.50",
            "926.00",
            "926.50",
            "927.00",
            "927.50",
            "928.00"});
            this.cmbReturnLossFreq.Location = new System.Drawing.Point(173, 20);
            this.cmbReturnLossFreq.Name = "cmbReturnLossFreq";
            this.cmbReturnLossFreq.Size = new System.Drawing.Size(71, 21);
            this.cmbReturnLossFreq.TabIndex = 13;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(50, 24);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(24, 13);
            this.label108.TabIndex = 12;
            this.label108.Text = "RL:";
            // 
            // textReturnLoss
            // 
            this.textReturnLoss.Location = new System.Drawing.Point(79, 20);
            this.textReturnLoss.Name = "textReturnLoss";
            this.textReturnLoss.ReadOnly = true;
            this.textReturnLoss.Size = new System.Drawing.Size(71, 20);
            this.textReturnLoss.TabIndex = 11;
            this.textReturnLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btReturnLoss
            // 
            this.btReturnLoss.Location = new System.Drawing.Point(369, 18);
            this.btReturnLoss.Name = "btReturnLoss";
            this.btReturnLoss.Size = new System.Drawing.Size(90, 25);
            this.btReturnLoss.TabIndex = 10;
            this.btReturnLoss.Text = "Measure";
            this.btReturnLoss.UseVisualStyleBackColor = true;
            this.btReturnLoss.Click += new System.EventHandler(this.btReturnLoss_Click);
            // 
            // gbProfile
            // 
            this.gbProfile.Controls.Add(this.btGetProfile);
            this.gbProfile.Controls.Add(this.btSetProfile);
            this.gbProfile.Controls.Add(this.rdbProfile3);
            this.gbProfile.Controls.Add(this.rdbProfile2);
            this.gbProfile.Controls.Add(this.rdbProfile1);
            this.gbProfile.Controls.Add(this.rdbProfile0);
            this.gbProfile.ForeColor = System.Drawing.Color.Black;
            this.gbProfile.Location = new System.Drawing.Point(15, 449);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(967, 79);
            this.gbProfile.TabIndex = 18;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "RF Link Setup";
            // 
            // btGetProfile
            // 
            this.btGetProfile.Location = new System.Drawing.Point(734, 31);
            this.btGetProfile.Name = "btGetProfile";
            this.btGetProfile.Size = new System.Drawing.Size(90, 25);
            this.btGetProfile.TabIndex = 9;
            this.btGetProfile.Text = "Get";
            this.btGetProfile.UseVisualStyleBackColor = true;
            this.btGetProfile.Click += new System.EventHandler(this.btGetProfile_Click);
            // 
            // btSetProfile
            // 
            this.btSetProfile.Location = new System.Drawing.Point(859, 31);
            this.btSetProfile.Name = "btSetProfile";
            this.btSetProfile.Size = new System.Drawing.Size(90, 25);
            this.btSetProfile.TabIndex = 8;
            this.btSetProfile.Text = "Set";
            this.btSetProfile.UseVisualStyleBackColor = true;
            this.btSetProfile.Click += new System.EventHandler(this.btSetProfile_Click);
            // 
            // rdbProfile3
            // 
            this.rdbProfile3.AutoSize = true;
            this.rdbProfile3.Location = new System.Drawing.Point(295, 49);
            this.rdbProfile3.Name = "rdbProfile3";
            this.rdbProfile3.Size = new System.Drawing.Size(195, 17);
            this.rdbProfile3.TabIndex = 3;
            this.rdbProfile3.TabStop = true;
            this.rdbProfile3.Text = "Profile 3  Tari 6.25uS; FM0 400KHz;";
            this.rdbProfile3.UseVisualStyleBackColor = true;
            // 
            // rdbProfile2
            // 
            this.rdbProfile2.AutoSize = true;
            this.rdbProfile2.Location = new System.Drawing.Point(14, 49);
            this.rdbProfile2.Name = "rdbProfile2";
            this.rdbProfile2.Size = new System.Drawing.Size(198, 17);
            this.rdbProfile2.TabIndex = 2;
            this.rdbProfile2.TabStop = true;
            this.rdbProfile2.Text = "Profile 2  Tari 25uS; Miller 4 300KHz;";
            this.rdbProfile2.UseVisualStyleBackColor = true;
            // 
            // rdbProfile1
            // 
            this.rdbProfile1.AutoSize = true;
            this.rdbProfile1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbProfile1.ForeColor = System.Drawing.Color.Black;
            this.rdbProfile1.Location = new System.Drawing.Point(295, 22);
            this.rdbProfile1.Name = "rdbProfile1";
            this.rdbProfile1.Size = new System.Drawing.Size(401, 16);
            this.rdbProfile1.TabIndex = 1;
            this.rdbProfile1.TabStop = true;
            this.rdbProfile1.Text = "Profile 1(Recommended and Default)   Tari 25uS; Miller 4 250KHz";
            this.rdbProfile1.UseVisualStyleBackColor = true;
            // 
            // rdbProfile0
            // 
            this.rdbProfile0.AutoSize = true;
            this.rdbProfile0.Location = new System.Drawing.Point(14, 22);
            this.rdbProfile0.Name = "rdbProfile0";
            this.rdbProfile0.Size = new System.Drawing.Size(177, 17);
            this.rdbProfile0.TabIndex = 0;
            this.rdbProfile0.TabStop = true;
            this.rdbProfile0.Text = "Profile 0  Tari 25uS; FM0 40KHz";
            this.rdbProfile0.UseVisualStyleBackColor = true;
            // 
            // btRfSetup
            // 
            this.btRfSetup.Location = new System.Drawing.Point(874, 534);
            this.btRfSetup.Name = "btRfSetup";
            this.btRfSetup.Size = new System.Drawing.Size(90, 25);
            this.btRfSetup.TabIndex = 17;
            this.btRfSetup.Text = "Refresh";
            this.btRfSetup.UseVisualStyleBackColor = true;
            this.btRfSetup.Click += new System.EventHandler(this.btRfSetup_Click);
            // 
            // gbMonza
            // 
            this.gbMonza.Controls.Add(this.label14);
            this.gbMonza.Controls.Add(this.label11);
            this.gbMonza.Controls.Add(this.rdbMonzaOff);
            this.gbMonza.Controls.Add(this.btSetMonzaStatus);
            this.gbMonza.Controls.Add(this.btGetMonzaStatus);
            this.gbMonza.Controls.Add(this.rdbMonzaOn);
            this.gbMonza.ForeColor = System.Drawing.Color.Black;
            this.gbMonza.Location = new System.Drawing.Point(15, 212);
            this.gbMonza.Name = "gbMonza";
            this.gbMonza.Size = new System.Drawing.Size(967, 67);
            this.gbMonza.TabIndex = 15;
            this.gbMonza.TabStop = false;
            this.gbMonza.Text = "Impinj Monza FastTID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Location = new System.Drawing.Point(48, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(284, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "2.If this function is not supported by tags, please turn it off. ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label11.Location = new System.Drawing.Point(12, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(375, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Note: 1.Only a certain number of  Impinj Monza tag types support this function.";
            // 
            // rdbMonzaOff
            // 
            this.rdbMonzaOff.AutoSize = true;
            this.rdbMonzaOff.Location = new System.Drawing.Point(622, 34);
            this.rdbMonzaOff.Name = "rdbMonzaOff";
            this.rdbMonzaOff.Size = new System.Drawing.Size(39, 17);
            this.rdbMonzaOff.TabIndex = 3;
            this.rdbMonzaOff.TabStop = true;
            this.rdbMonzaOff.Text = "Off";
            this.rdbMonzaOff.UseVisualStyleBackColor = true;
            // 
            // btSetMonzaStatus
            // 
            this.btSetMonzaStatus.Location = new System.Drawing.Point(859, 26);
            this.btSetMonzaStatus.Name = "btSetMonzaStatus";
            this.btSetMonzaStatus.Size = new System.Drawing.Size(90, 25);
            this.btSetMonzaStatus.TabIndex = 2;
            this.btSetMonzaStatus.Text = "Set";
            this.btSetMonzaStatus.UseVisualStyleBackColor = true;
            this.btSetMonzaStatus.Click += new System.EventHandler(this.btSetMonzaStatus_Click);
            // 
            // btGetMonzaStatus
            // 
            this.btGetMonzaStatus.Location = new System.Drawing.Point(734, 26);
            this.btGetMonzaStatus.Name = "btGetMonzaStatus";
            this.btGetMonzaStatus.Size = new System.Drawing.Size(90, 25);
            this.btGetMonzaStatus.TabIndex = 1;
            this.btGetMonzaStatus.Text = "Get";
            this.btGetMonzaStatus.UseVisualStyleBackColor = true;
            this.btGetMonzaStatus.Click += new System.EventHandler(this.btGetMonzaStatus_Click);
            // 
            // rdbMonzaOn
            // 
            this.rdbMonzaOn.AutoSize = true;
            this.rdbMonzaOn.Location = new System.Drawing.Point(521, 34);
            this.rdbMonzaOn.Name = "rdbMonzaOn";
            this.rdbMonzaOn.Size = new System.Drawing.Size(39, 17);
            this.rdbMonzaOn.TabIndex = 0;
            this.rdbMonzaOn.TabStop = true;
            this.rdbMonzaOn.Text = "On";
            this.rdbMonzaOn.UseVisualStyleBackColor = true;
            // 
            // gbCmdAntDetector
            // 
            this.gbCmdAntDetector.Controls.Add(this.label7);
            this.gbCmdAntDetector.Controls.Add(this.label6);
            this.gbCmdAntDetector.Controls.Add(this.label5);
            this.gbCmdAntDetector.Controls.Add(this.label10);
            this.gbCmdAntDetector.Controls.Add(this.label8);
            this.gbCmdAntDetector.Controls.Add(this.tbAntDectector);
            this.gbCmdAntDetector.Controls.Add(this.btnGetAntDetector);
            this.gbCmdAntDetector.Controls.Add(this.btnSetAntDetector);
            this.gbCmdAntDetector.ForeColor = System.Drawing.Color.Black;
            this.gbCmdAntDetector.Location = new System.Drawing.Point(15, 128);
            this.gbCmdAntDetector.Name = "gbCmdAntDetector";
            this.gbCmdAntDetector.Size = new System.Drawing.Size(967, 78);
            this.gbCmdAntDetector.TabIndex = 13;
            this.gbCmdAntDetector.TabStop = false;
            this.gbCmdAntDetector.Text = "Antenna Connection Detector";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(48, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "2.Reader stops tag operation if return loss is above the threshold.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(48, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "3.User can turn it off by setting the threshold to 0.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(413, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Note: 1.Reader detects antenna connections by measuring the return loss of RF por" +
    "ts.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "RL Threshold:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(646, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "dB";
            // 
            // tbAntDectector
            // 
            this.tbAntDectector.Location = new System.Drawing.Point(569, 35);
            this.tbAntDectector.Name = "tbAntDectector";
            this.tbAntDectector.Size = new System.Drawing.Size(71, 20);
            this.tbAntDectector.TabIndex = 4;
            this.tbAntDectector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetAntDetector
            // 
            this.btnGetAntDetector.Location = new System.Drawing.Point(734, 34);
            this.btnGetAntDetector.Name = "btnGetAntDetector";
            this.btnGetAntDetector.Size = new System.Drawing.Size(90, 25);
            this.btnGetAntDetector.TabIndex = 3;
            this.btnGetAntDetector.Text = "Get";
            this.btnGetAntDetector.UseVisualStyleBackColor = true;
            this.btnGetAntDetector.Click += new System.EventHandler(this.btnGetAntDetector_Click);
            // 
            // btnSetAntDetector
            // 
            this.btnSetAntDetector.Location = new System.Drawing.Point(859, 34);
            this.btnSetAntDetector.Name = "btnSetAntDetector";
            this.btnSetAntDetector.Size = new System.Drawing.Size(90, 25);
            this.btnSetAntDetector.TabIndex = 2;
            this.btnSetAntDetector.Text = "Set";
            this.btnSetAntDetector.UseVisualStyleBackColor = true;
            this.btnSetAntDetector.Click += new System.EventHandler(this.btnSetAntDetector_Click);
            // 
            // gbCmdDrm
            // 
            this.gbCmdDrm.Controls.Add(this.btnGetDrmMode);
            this.gbCmdDrm.Controls.Add(this.btnSetDrmMode);
            this.gbCmdDrm.Controls.Add(this.rdbDrmModeClose);
            this.gbCmdDrm.Controls.Add(this.rdbDrmModeOpen);
            this.gbCmdDrm.ForeColor = System.Drawing.Color.Black;
            this.gbCmdDrm.Location = new System.Drawing.Point(15, 9);
            this.gbCmdDrm.Name = "gbCmdDrm";
            this.gbCmdDrm.Size = new System.Drawing.Size(472, 53);
            this.gbCmdDrm.TabIndex = 10;
            this.gbCmdDrm.TabStop = false;
            this.gbCmdDrm.Text = "DRM Status";
            // 
            // btnGetDrmMode
            // 
            this.btnGetDrmMode.Location = new System.Drawing.Point(235, 17);
            this.btnGetDrmMode.Name = "btnGetDrmMode";
            this.btnGetDrmMode.Size = new System.Drawing.Size(90, 25);
            this.btnGetDrmMode.TabIndex = 3;
            this.btnGetDrmMode.Text = "Get";
            this.btnGetDrmMode.UseVisualStyleBackColor = true;
            this.btnGetDrmMode.Click += new System.EventHandler(this.btnGetDrmMode_Click);
            // 
            // btnSetDrmMode
            // 
            this.btnSetDrmMode.Location = new System.Drawing.Point(344, 17);
            this.btnSetDrmMode.Name = "btnSetDrmMode";
            this.btnSetDrmMode.Size = new System.Drawing.Size(90, 25);
            this.btnSetDrmMode.TabIndex = 2;
            this.btnSetDrmMode.Text = "Set";
            this.btnSetDrmMode.UseVisualStyleBackColor = true;
            this.btnSetDrmMode.Click += new System.EventHandler(this.btnSetDrmMode_Click);
            // 
            // rdbDrmModeClose
            // 
            this.rdbDrmModeClose.AutoSize = true;
            this.rdbDrmModeClose.Location = new System.Drawing.Point(149, 21);
            this.rdbDrmModeClose.Name = "rdbDrmModeClose";
            this.rdbDrmModeClose.Size = new System.Drawing.Size(39, 17);
            this.rdbDrmModeClose.TabIndex = 1;
            this.rdbDrmModeClose.TabStop = true;
            this.rdbDrmModeClose.Text = "Off";
            this.rdbDrmModeClose.UseVisualStyleBackColor = true;
            // 
            // rdbDrmModeOpen
            // 
            this.rdbDrmModeOpen.AutoSize = true;
            this.rdbDrmModeOpen.Location = new System.Drawing.Point(38, 21);
            this.rdbDrmModeOpen.Name = "rdbDrmModeOpen";
            this.rdbDrmModeOpen.Size = new System.Drawing.Size(39, 17);
            this.rdbDrmModeOpen.TabIndex = 0;
            this.rdbDrmModeOpen.TabStop = true;
            this.rdbDrmModeOpen.Text = "On";
            this.rdbDrmModeOpen.UseVisualStyleBackColor = true;
            // 
            // gbCmdAntenna
            // 
            this.gbCmdAntenna.Controls.Add(this.label107);
            this.gbCmdAntenna.Controls.Add(this.cmbWorkAnt);
            this.gbCmdAntenna.Controls.Add(this.btnGetWorkAntenna);
            this.gbCmdAntenna.Controls.Add(this.btnSetWorkAntenna);
            this.gbCmdAntenna.ForeColor = System.Drawing.Color.Black;
            this.gbCmdAntenna.Location = new System.Drawing.Point(15, 72);
            this.gbCmdAntenna.Name = "gbCmdAntenna";
            this.gbCmdAntenna.Size = new System.Drawing.Size(472, 50);
            this.gbCmdAntenna.TabIndex = 14;
            this.gbCmdAntenna.TabStop = false;
            this.gbCmdAntenna.Text = "Manual Switch Antenna";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(29, 24);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(63, 13);
            this.label107.TabIndex = 7;
            this.label107.Text = "Current Ant:";
            // 
            // cmbWorkAnt
            // 
            this.cmbWorkAnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkAnt.FormattingEnabled = true;
            this.cmbWorkAnt.Items.AddRange(new object[] {
            "天线 1",
            "天线 2",
            "天线 3",
            "天线 4"});
            this.cmbWorkAnt.Location = new System.Drawing.Point(112, 20);
            this.cmbWorkAnt.Name = "cmbWorkAnt";
            this.cmbWorkAnt.Size = new System.Drawing.Size(84, 21);
            this.cmbWorkAnt.TabIndex = 6;
            // 
            // btnGetWorkAntenna
            // 
            this.btnGetWorkAntenna.Location = new System.Drawing.Point(234, 17);
            this.btnGetWorkAntenna.Name = "btnGetWorkAntenna";
            this.btnGetWorkAntenna.Size = new System.Drawing.Size(90, 25);
            this.btnGetWorkAntenna.TabIndex = 5;
            this.btnGetWorkAntenna.Text = "Get";
            this.btnGetWorkAntenna.UseVisualStyleBackColor = true;
            this.btnGetWorkAntenna.Click += new System.EventHandler(this.btnGetWorkAntenna_Click);
            // 
            // btnSetWorkAntenna
            // 
            this.btnSetWorkAntenna.Location = new System.Drawing.Point(343, 17);
            this.btnSetWorkAntenna.Name = "btnSetWorkAntenna";
            this.btnSetWorkAntenna.Size = new System.Drawing.Size(90, 25);
            this.btnSetWorkAntenna.TabIndex = 4;
            this.btnSetWorkAntenna.Text = "Set";
            this.btnSetWorkAntenna.UseVisualStyleBackColor = true;
            this.btnSetWorkAntenna.Click += new System.EventHandler(this.btnSetWorkAntenna_Click);
            // 
            // gbCmdRegion
            // 
            this.gbCmdRegion.Controls.Add(this.cbUserDefineFreq);
            this.gbCmdRegion.Controls.Add(this.groupBox23);
            this.gbCmdRegion.Controls.Add(this.groupBox21);
            this.gbCmdRegion.Controls.Add(this.btnGetFrequencyRegion);
            this.gbCmdRegion.Controls.Add(this.btnSetFrequencyRegion);
            this.gbCmdRegion.ForeColor = System.Drawing.Color.Black;
            this.gbCmdRegion.Location = new System.Drawing.Point(15, 286);
            this.gbCmdRegion.Name = "gbCmdRegion";
            this.gbCmdRegion.Size = new System.Drawing.Size(967, 156);
            this.gbCmdRegion.TabIndex = 9;
            this.gbCmdRegion.TabStop = false;
            this.gbCmdRegion.Text = "RF Spectrum Setup";
            // 
            // cbUserDefineFreq
            // 
            this.cbUserDefineFreq.AutoSize = true;
            this.cbUserDefineFreq.Location = new System.Drawing.Point(9, 108);
            this.cbUserDefineFreq.Name = "cbUserDefineFreq";
            this.cbUserDefineFreq.Size = new System.Drawing.Size(82, 17);
            this.cbUserDefineFreq.TabIndex = 11;
            this.cbUserDefineFreq.Text = "User Define";
            this.cbUserDefineFreq.UseVisualStyleBackColor = true;
            this.cbUserDefineFreq.CheckedChanged += new System.EventHandler(this.cbUserDefineFreq_CheckedChanged);
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.label106);
            this.groupBox23.Controls.Add(this.label105);
            this.groupBox23.Controls.Add(this.label104);
            this.groupBox23.Controls.Add(this.label103);
            this.groupBox23.Controls.Add(this.label86);
            this.groupBox23.Controls.Add(this.label75);
            this.groupBox23.Controls.Add(this.textFreqQuantity);
            this.groupBox23.Controls.Add(this.TextFreqInterval);
            this.groupBox23.Controls.Add(this.textStartFreq);
            this.groupBox23.ForeColor = System.Drawing.Color.Black;
            this.groupBox23.Location = new System.Drawing.Point(103, 83);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(609, 60);
            this.groupBox23.TabIndex = 10;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "User Defined Frequencies";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(571, 26);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(0, 13);
            this.label106.TabIndex = 8;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(400, 26);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(27, 13);
            this.label105.TabIndex = 7;
            this.label105.Text = "KHz";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(213, 26);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(27, 13);
            this.label104.TabIndex = 6;
            this.label104.Text = "KHz";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(429, 26);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(49, 13);
            this.label103.TabIndex = 5;
            this.label103.Text = "Quantity:";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(260, 26);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(65, 13);
            this.label86.TabIndex = 4;
            this.label86.Text = "Freq Space:";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(34, 26);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(85, 13);
            this.label75.TabIndex = 3;
            this.label75.Text = "Start Frequency:";
            // 
            // textFreqQuantity
            // 
            this.textFreqQuantity.Location = new System.Drawing.Point(494, 22);
            this.textFreqQuantity.Name = "textFreqQuantity";
            this.textFreqQuantity.Size = new System.Drawing.Size(71, 20);
            this.textFreqQuantity.TabIndex = 2;
            this.textFreqQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextFreqInterval
            // 
            this.TextFreqInterval.Location = new System.Drawing.Point(325, 22);
            this.TextFreqInterval.Name = "TextFreqInterval";
            this.TextFreqInterval.Size = new System.Drawing.Size(71, 20);
            this.TextFreqInterval.TabIndex = 1;
            this.TextFreqInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textStartFreq
            // 
            this.textStartFreq.Location = new System.Drawing.Point(141, 22);
            this.textStartFreq.Name = "textStartFreq";
            this.textStartFreq.Size = new System.Drawing.Size(66, 20);
            this.textStartFreq.TabIndex = 0;
            this.textStartFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.label37);
            this.groupBox21.Controls.Add(this.label36);
            this.groupBox21.Controls.Add(this.cmbFrequencyEnd);
            this.groupBox21.Controls.Add(this.label13);
            this.groupBox21.Controls.Add(this.cmbFrequencyStart);
            this.groupBox21.Controls.Add(this.label12);
            this.groupBox21.Controls.Add(this.rdbRegionChn);
            this.groupBox21.Controls.Add(this.rdbRegionEtsi);
            this.groupBox21.Controls.Add(this.rdbRegionFcc);
            this.groupBox21.ForeColor = System.Drawing.Color.Black;
            this.groupBox21.Location = new System.Drawing.Point(103, 17);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(609, 60);
            this.groupBox21.TabIndex = 9;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "System Default Frequencies";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(570, 25);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(29, 13);
            this.label37.TabIndex = 17;
            this.label37.Text = "MHz";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(403, 26);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(29, 13);
            this.label36.TabIndex = 16;
            this.label36.Text = "MHz";
            // 
            // cmbFrequencyEnd
            // 
            this.cmbFrequencyEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrequencyEnd.FormattingEnabled = true;
            this.cmbFrequencyEnd.Location = new System.Drawing.Point(494, 21);
            this.cmbFrequencyEnd.Name = "cmbFrequencyEnd";
            this.cmbFrequencyEnd.Size = new System.Drawing.Size(71, 21);
            this.cmbFrequencyEnd.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(454, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "—";
            // 
            // cmbFrequencyStart
            // 
            this.cmbFrequencyStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrequencyStart.FormattingEnabled = true;
            this.cmbFrequencyStart.Location = new System.Drawing.Point(325, 21);
            this.cmbFrequencyStart.Name = "cmbFrequencyStart";
            this.cmbFrequencyStart.Size = new System.Drawing.Size(71, 21);
            this.cmbFrequencyStart.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Freq Range:";
            // 
            // rdbRegionChn
            // 
            this.rdbRegionChn.AutoSize = true;
            this.rdbRegionChn.Location = new System.Drawing.Point(195, 24);
            this.rdbRegionChn.Name = "rdbRegionChn";
            this.rdbRegionChn.Size = new System.Drawing.Size(48, 17);
            this.rdbRegionChn.TabIndex = 11;
            this.rdbRegionChn.TabStop = true;
            this.rdbRegionChn.Text = "CHN";
            this.rdbRegionChn.UseVisualStyleBackColor = true;
            this.rdbRegionChn.CheckedChanged += new System.EventHandler(this.rdbRegionChn_CheckedChanged);
            // 
            // rdbRegionEtsi
            // 
            this.rdbRegionEtsi.AutoSize = true;
            this.rdbRegionEtsi.Location = new System.Drawing.Point(116, 24);
            this.rdbRegionEtsi.Name = "rdbRegionEtsi";
            this.rdbRegionEtsi.Size = new System.Drawing.Size(49, 17);
            this.rdbRegionEtsi.TabIndex = 10;
            this.rdbRegionEtsi.TabStop = true;
            this.rdbRegionEtsi.Text = "ETSI";
            this.rdbRegionEtsi.UseVisualStyleBackColor = true;
            this.rdbRegionEtsi.CheckedChanged += new System.EventHandler(this.rdbRegionEtsi_CheckedChanged);
            // 
            // rdbRegionFcc
            // 
            this.rdbRegionFcc.AutoSize = true;
            this.rdbRegionFcc.Location = new System.Drawing.Point(43, 24);
            this.rdbRegionFcc.Name = "rdbRegionFcc";
            this.rdbRegionFcc.Size = new System.Drawing.Size(45, 17);
            this.rdbRegionFcc.TabIndex = 9;
            this.rdbRegionFcc.TabStop = true;
            this.rdbRegionFcc.Text = "FCC";
            this.rdbRegionFcc.UseVisualStyleBackColor = true;
            this.rdbRegionFcc.CheckedChanged += new System.EventHandler(this.rdbRegionFcc_CheckedChanged);
            // 
            // btnGetFrequencyRegion
            // 
            this.btnGetFrequencyRegion.Location = new System.Drawing.Point(734, 72);
            this.btnGetFrequencyRegion.Name = "btnGetFrequencyRegion";
            this.btnGetFrequencyRegion.Size = new System.Drawing.Size(90, 25);
            this.btnGetFrequencyRegion.TabIndex = 6;
            this.btnGetFrequencyRegion.Text = "Get";
            this.btnGetFrequencyRegion.UseVisualStyleBackColor = true;
            this.btnGetFrequencyRegion.Click += new System.EventHandler(this.btnGetFrequencyRegion_Click);
            // 
            // btnSetFrequencyRegion
            // 
            this.btnSetFrequencyRegion.Location = new System.Drawing.Point(859, 72);
            this.btnSetFrequencyRegion.Name = "btnSetFrequencyRegion";
            this.btnSetFrequencyRegion.Size = new System.Drawing.Size(90, 25);
            this.btnSetFrequencyRegion.TabIndex = 5;
            this.btnSetFrequencyRegion.Text = "Set";
            this.btnSetFrequencyRegion.UseVisualStyleBackColor = true;
            this.btnSetFrequencyRegion.Click += new System.EventHandler(this.btnSetFrequencyRegion_Click);
            // 
            // gbCmdOutputPower
            // 
            this.gbCmdOutputPower.Controls.Add(this.btnGetOutputPower);
            this.gbCmdOutputPower.Controls.Add(this.btnSetOutputPower);
            this.gbCmdOutputPower.Controls.Add(this.txtOutputPower);
            this.gbCmdOutputPower.Controls.Add(this.label9);
            this.gbCmdOutputPower.ForeColor = System.Drawing.Color.Black;
            this.gbCmdOutputPower.Location = new System.Drawing.Point(505, 9);
            this.gbCmdOutputPower.Name = "gbCmdOutputPower";
            this.gbCmdOutputPower.Size = new System.Drawing.Size(477, 53);
            this.gbCmdOutputPower.TabIndex = 8;
            this.gbCmdOutputPower.TabStop = false;
            this.gbCmdOutputPower.Text = "RF Output Power";
            // 
            // btnGetOutputPower
            // 
            this.btnGetOutputPower.Location = new System.Drawing.Point(244, 17);
            this.btnGetOutputPower.Name = "btnGetOutputPower";
            this.btnGetOutputPower.Size = new System.Drawing.Size(90, 25);
            this.btnGetOutputPower.TabIndex = 2;
            this.btnGetOutputPower.Text = "Get";
            this.btnGetOutputPower.UseVisualStyleBackColor = true;
            this.btnGetOutputPower.Click += new System.EventHandler(this.btnGetOutputPower_Click);
            // 
            // btnSetOutputPower
            // 
            this.btnSetOutputPower.Location = new System.Drawing.Point(369, 17);
            this.btnSetOutputPower.Name = "btnSetOutputPower";
            this.btnSetOutputPower.Size = new System.Drawing.Size(90, 25);
            this.btnSetOutputPower.TabIndex = 1;
            this.btnSetOutputPower.Text = "Set";
            this.btnSetOutputPower.UseVisualStyleBackColor = true;
            this.btnSetOutputPower.Click += new System.EventHandler(this.btnSetOutputPower_Click);
            // 
            // txtOutputPower
            // 
            this.txtOutputPower.Location = new System.Drawing.Point(79, 18);
            this.txtOutputPower.Name = "txtOutputPower";
            this.txtOutputPower.Size = new System.Drawing.Size(71, 20);
            this.txtOutputPower.TabIndex = 0;
            this.txtOutputPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "dBm";
            // 
            // pageEpcTest
            // 
            this.pageEpcTest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageEpcTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageEpcTest.Controls.Add(this.tabEpcTest);
            this.pageEpcTest.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageEpcTest.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pageEpcTest.Location = new System.Drawing.Point(4, 22);
            this.pageEpcTest.Name = "pageEpcTest";
            this.pageEpcTest.Size = new System.Drawing.Size(1010, 603);
            this.pageEpcTest.TabIndex = 5;
            this.pageEpcTest.Text = "18000-6C Tag Statistics";
            // 
            // tabEpcTest
            // 
            this.tabEpcTest.Controls.Add(this.pageRealMode);
            this.tabEpcTest.Controls.Add(this.pageBufferedMode);
            this.tabEpcTest.Controls.Add(this.pageFast4AntMode);
            this.tabEpcTest.Controls.Add(this.pageAcessTag);
            this.tabEpcTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabEpcTest.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabEpcTest.Location = new System.Drawing.Point(0, 7);
            this.tabEpcTest.Name = "tabEpcTest";
            this.tabEpcTest.SelectedIndex = 0;
            this.tabEpcTest.Size = new System.Drawing.Size(1008, 594);
            this.tabEpcTest.TabIndex = 0;
            // 
            // pageRealMode
            // 
            this.pageRealMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageRealMode.Controls.Add(this.tagsTextBox);
            this.pageRealMode.Controls.Add(this.groupBox20);
            this.pageRealMode.Controls.Add(this.tableLayoutPanel1);
            this.pageRealMode.Controls.Add(this.tbRealMinRssi);
            this.pageRealMode.Controls.Add(this.tbRealMaxRssi);
            this.pageRealMode.Controls.Add(this.btRealFresh);
            this.pageRealMode.Controls.Add(this.label70);
            this.pageRealMode.Controls.Add(this.label74);
            this.pageRealMode.Controls.Add(this.lbRealTagCount);
            this.pageRealMode.Controls.Add(this.groupBox1);
            this.pageRealMode.Controls.Add(this.lvRealList);
            this.pageRealMode.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageRealMode.Location = new System.Drawing.Point(4, 22);
            this.pageRealMode.Name = "pageRealMode";
            this.pageRealMode.Padding = new System.Windows.Forms.Padding(3);
            this.pageRealMode.Size = new System.Drawing.Size(1000, 568);
            this.pageRealMode.TabIndex = 1;
            this.pageRealMode.Text = "Tag Inventory(Real Time Mode)";
            // 
            // tagsTextBox
            // 
            this.tagsTextBox.Location = new System.Drawing.Point(584, 340);
            this.tagsTextBox.Multiline = true;
            this.tagsTextBox.Name = "tagsTextBox";
            this.tagsTextBox.Size = new System.Drawing.Size(413, 179);
            this.tagsTextBox.TabIndex = 52;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.cbRealWorkant1);
            this.groupBox20.Controls.Add(this.cbRealWorkant4);
            this.groupBox20.Controls.Add(this.cbRealWorkant3);
            this.groupBox20.Controls.Add(this.cbRealWorkant2);
            this.groupBox20.Controls.Add(this.label19);
            this.groupBox20.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox20.ForeColor = System.Drawing.Color.Black;
            this.groupBox20.Location = new System.Drawing.Point(3, 65);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(994, 57);
            this.groupBox20.TabIndex = 49;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Antenna Selection";
            // 
            // cbRealWorkant1
            // 
            this.cbRealWorkant1.AutoSize = true;
            this.cbRealWorkant1.Checked = true;
            this.cbRealWorkant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRealWorkant1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRealWorkant1.Location = new System.Drawing.Point(283, 24);
            this.cbRealWorkant1.Name = "cbRealWorkant1";
            this.cbRealWorkant1.Size = new System.Drawing.Size(48, 16);
            this.cbRealWorkant1.TabIndex = 68;
            this.cbRealWorkant1.Text = "Ant1";
            this.cbRealWorkant1.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant4
            // 
            this.cbRealWorkant4.AutoSize = true;
            this.cbRealWorkant4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRealWorkant4.Location = new System.Drawing.Point(649, 24);
            this.cbRealWorkant4.Name = "cbRealWorkant4";
            this.cbRealWorkant4.Size = new System.Drawing.Size(48, 16);
            this.cbRealWorkant4.TabIndex = 67;
            this.cbRealWorkant4.Text = "Ant4";
            this.cbRealWorkant4.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant3
            // 
            this.cbRealWorkant3.AutoSize = true;
            this.cbRealWorkant3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRealWorkant3.Location = new System.Drawing.Point(527, 24);
            this.cbRealWorkant3.Name = "cbRealWorkant3";
            this.cbRealWorkant3.Size = new System.Drawing.Size(48, 16);
            this.cbRealWorkant3.TabIndex = 66;
            this.cbRealWorkant3.Text = "Ant3";
            this.cbRealWorkant3.UseVisualStyleBackColor = true;
            // 
            // cbRealWorkant2
            // 
            this.cbRealWorkant2.AutoSize = true;
            this.cbRealWorkant2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRealWorkant2.Location = new System.Drawing.Point(405, 24);
            this.cbRealWorkant2.Name = "cbRealWorkant2";
            this.cbRealWorkant2.Size = new System.Drawing.Size(48, 16);
            this.cbRealWorkant2.TabIndex = 65;
            this.cbRealWorkant2.Text = "Ant2";
            this.cbRealWorkant2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(51, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 12);
            this.label19.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.7996F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.2004F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 60);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textRealRound);
            this.panel1.Controls.Add(this.label84);
            this.panel1.Controls.Add(this.btRealTimeInventory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 52);
            this.panel1.TabIndex = 0;
            // 
            // textRealRound
            // 
            this.textRealRound.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textRealRound.Location = new System.Drawing.Point(354, 16);
            this.textRealRound.Name = "textRealRound";
            this.textRealRound.Size = new System.Drawing.Size(28, 21);
            this.textRealRound.TabIndex = 48;
            this.textRealRound.Text = "1";
            this.textRealRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label84.Location = new System.Drawing.Point(231, 21);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(119, 12);
            this.label84.TabIndex = 2;
            this.label84.Text = "Repeat Per Command:";
            // 
            // btRealTimeInventory
            // 
            this.btRealTimeInventory.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRealTimeInventory.ForeColor = System.Drawing.Color.DarkBlue;
            this.btRealTimeInventory.Location = new System.Drawing.Point(75, 5);
            this.btRealTimeInventory.Name = "btRealTimeInventory";
            this.btRealTimeInventory.Size = new System.Drawing.Size(144, 41);
            this.btRealTimeInventory.TabIndex = 1;
            this.btRealTimeInventory.Text = "Inventory";
            this.btRealTimeInventory.UseVisualStyleBackColor = true;
            this.btRealTimeInventory.Click += new System.EventHandler(this.btRealTimeInventory_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbRealSession);
            this.panel5.Controls.Add(this.cmbTarget);
            this.panel5.Controls.Add(this.label98);
            this.panel5.Controls.Add(this.cmbSession);
            this.panel5.Controls.Add(this.label97);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(429, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(561, 52);
            this.panel5.TabIndex = 1;
            // 
            // cbRealSession
            // 
            this.cbRealSession.AutoSize = true;
            this.cbRealSession.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRealSession.Location = new System.Drawing.Point(29, 18);
            this.cbRealSession.Name = "cbRealSession";
            this.cbRealSession.Size = new System.Drawing.Size(138, 16);
            this.cbRealSession.TabIndex = 55;
            this.cbRealSession.Text = "User Define Session";
            this.cbRealSession.UseVisualStyleBackColor = true;
            this.cbRealSession.CheckedChanged += new System.EventHandler(this.cbRealSession_CheckedChanged);
            // 
            // cmbTarget
            // 
            this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarget.Enabled = false;
            this.cmbTarget.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbTarget.Location = new System.Drawing.Point(472, 16);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(62, 20);
            this.cmbTarget.TabIndex = 54;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Enabled = false;
            this.label98.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label98.Location = new System.Drawing.Point(359, 21);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(107, 12);
            this.label98.TabIndex = 53;
            this.label98.Text = "Inventoried Flag:";
            // 
            // cmbSession
            // 
            this.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSession.Enabled = false;
            this.cmbSession.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Items.AddRange(new object[] {
            "S0",
            "S1",
            "S2",
            "S3"});
            this.cmbSession.Location = new System.Drawing.Point(273, 16);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(62, 20);
            this.cmbSession.TabIndex = 52;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Enabled = false;
            this.label97.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label97.Location = new System.Drawing.Point(196, 21);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(71, 12);
            this.label97.TabIndex = 51;
            this.label97.Text = "Session ID:";
            // 
            // tbRealMinRssi
            // 
            this.tbRealMinRssi.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRealMinRssi.Location = new System.Drawing.Point(500, 311);
            this.tbRealMinRssi.Name = "tbRealMinRssi";
            this.tbRealMinRssi.ReadOnly = true;
            this.tbRealMinRssi.Size = new System.Drawing.Size(62, 21);
            this.tbRealMinRssi.TabIndex = 46;
            this.tbRealMinRssi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRealMaxRssi
            // 
            this.tbRealMaxRssi.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRealMaxRssi.Location = new System.Drawing.Point(705, 311);
            this.tbRealMaxRssi.Name = "tbRealMaxRssi";
            this.tbRealMaxRssi.ReadOnly = true;
            this.tbRealMaxRssi.Size = new System.Drawing.Size(62, 21);
            this.tbRealMaxRssi.TabIndex = 47;
            this.tbRealMaxRssi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btRealFresh
            // 
            this.btRealFresh.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRealFresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btRealFresh.Location = new System.Drawing.Point(908, 309);
            this.btRealFresh.Name = "btRealFresh";
            this.btRealFresh.Size = new System.Drawing.Size(89, 25);
            this.btRealFresh.TabIndex = 45;
            this.btRealFresh.Text = "Refresh";
            this.btRealFresh.UseVisualStyleBackColor = true;
            this.btRealFresh.Click += new System.EventHandler(this.btRealFresh_Click);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label70.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label70.Location = new System.Drawing.Point(634, 314);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(59, 12);
            this.label70.TabIndex = 43;
            this.label70.Text = "Max RSSI:";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label74.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label74.Location = new System.Drawing.Point(432, 315);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(59, 12);
            this.label74.TabIndex = 44;
            this.label74.Text = "Min RSSI:";
            // 
            // lbRealTagCount
            // 
            this.lbRealTagCount.AutoSize = true;
            this.lbRealTagCount.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRealTagCount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbRealTagCount.Location = new System.Drawing.Point(7, 314);
            this.lbRealTagCount.Name = "lbRealTagCount";
            this.lbRealTagCount.Size = new System.Drawing.Size(59, 12);
            this.lbRealTagCount.TabIndex = 42;
            this.lbRealTagCount.Text = "Tag List:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ledReal3);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.ledReal5);
            this.groupBox1.Controls.Add(this.ledReal2);
            this.groupBox1.Controls.Add(this.ledReal4);
            this.groupBox1.Controls.Add(this.label53);
            this.groupBox1.Controls.Add(this.label66);
            this.groupBox1.Controls.Add(this.label67);
            this.groupBox1.Controls.Add(this.label68);
            this.groupBox1.Controls.Add(this.label69);
            this.groupBox1.Controls.Add(this.ledReal1);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(1, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 176);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag Data";
            // 
            // ledReal3
            // 
            this.ledReal3.BackColor = System.Drawing.Color.Transparent;
            this.ledReal3.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal3.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal3.BevelRate = 0.1F;
            this.ledReal3.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal3.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal3.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledReal3.HighlightOpaque = ((byte)(20));
            this.ledReal3.Location = new System.Drawing.Point(702, 54);
            this.ledReal3.Name = "ledReal3";
            this.ledReal3.RoundCorner = true;
            this.ledReal3.SegmentIntervalRatio = 50;
            this.ledReal3.ShowHighlight = true;
            this.ledReal3.Size = new System.Drawing.Size(207, 38);
            this.ledReal3.TabIndex = 40;
            this.ledReal3.Text = "0";
            this.ledReal3.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledReal3.TotalCharCount = 10;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.comboBox6.Location = new System.Drawing.Point(-165, 120);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(55, 20);
            this.comboBox6.TabIndex = 39;
            // 
            // ledReal5
            // 
            this.ledReal5.BackColor = System.Drawing.Color.Transparent;
            this.ledReal5.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal5.BevelRate = 0.1F;
            this.ledReal5.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledReal5.HighlightOpaque = ((byte)(20));
            this.ledReal5.Location = new System.Drawing.Point(702, 128);
            this.ledReal5.Name = "ledReal5";
            this.ledReal5.RoundCorner = true;
            this.ledReal5.SegmentIntervalRatio = 50;
            this.ledReal5.ShowHighlight = true;
            this.ledReal5.Size = new System.Drawing.Size(207, 38);
            this.ledReal5.TabIndex = 35;
            this.ledReal5.Text = "0";
            this.ledReal5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledReal5.TotalCharCount = 10;
            // 
            // ledReal2
            // 
            this.ledReal2.BackColor = System.Drawing.Color.Transparent;
            this.ledReal2.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal2.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal2.BevelRate = 0.1F;
            this.ledReal2.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal2.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal2.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal2.ForeColor = System.Drawing.Color.Purple;
            this.ledReal2.HighlightOpaque = ((byte)(20));
            this.ledReal2.Location = new System.Drawing.Point(496, 38);
            this.ledReal2.Name = "ledReal2";
            this.ledReal2.RoundCorner = true;
            this.ledReal2.SegmentIntervalRatio = 50;
            this.ledReal2.ShowHighlight = true;
            this.ledReal2.Size = new System.Drawing.Size(175, 54);
            this.ledReal2.TabIndex = 34;
            this.ledReal2.Text = "0";
            this.ledReal2.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledReal2.TotalCharCount = 6;
            // 
            // ledReal4
            // 
            this.ledReal4.BackColor = System.Drawing.Color.Transparent;
            this.ledReal4.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal4.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal4.BevelRate = 0.1F;
            this.ledReal4.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal4.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal4.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal4.ForeColor = System.Drawing.Color.Purple;
            this.ledReal4.HighlightOpaque = ((byte)(20));
            this.ledReal4.Location = new System.Drawing.Point(497, 112);
            this.ledReal4.Name = "ledReal4";
            this.ledReal4.RoundCorner = true;
            this.ledReal4.SegmentIntervalRatio = 50;
            this.ledReal4.ShowHighlight = true;
            this.ledReal4.Size = new System.Drawing.Size(174, 54);
            this.ledReal4.TabIndex = 33;
            this.ledReal4.Text = "0";
            this.ledReal4.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledReal4.TotalCharCount = 6;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label53.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label53.Location = new System.Drawing.Point(700, 112);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(179, 12);
            this.label53.TabIndex = 30;
            this.label53.Text = "Total Inventory Duration(mS):";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label66.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label66.Location = new System.Drawing.Point(495, 18);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(95, 12);
            this.label66.TabIndex = 29;
            this.label66.Text = "Speed(Tag/Sec):";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label67.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label67.Location = new System.Drawing.Point(498, 95);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(131, 12);
            this.label67.TabIndex = 28;
            this.label67.Text = "Command Duration(mS):";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label68.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label68.Location = new System.Drawing.Point(700, 38);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(149, 12);
            this.label68.TabIndex = 27;
            this.label68.Text = "Total Tag Communication:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label69.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label69.Location = new System.Drawing.Point(104, 18);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(131, 12);
            this.label69.TabIndex = 26;
            this.label69.Text = "Inventoried Quantity:";
            // 
            // ledReal1
            // 
            this.ledReal1.BackColor = System.Drawing.Color.Transparent;
            this.ledReal1.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledReal1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledReal1.BevelRate = 0.1F;
            this.ledReal1.BorderColor = System.Drawing.Color.Lavender;
            this.ledReal1.BorderWidth = 3;
            this.ledReal1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledReal1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledReal1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledReal1.HighlightOpaque = ((byte)(20));
            this.ledReal1.Location = new System.Drawing.Point(106, 38);
            this.ledReal1.Name = "ledReal1";
            this.ledReal1.RoundCorner = true;
            this.ledReal1.SegmentIntervalRatio = 50;
            this.ledReal1.ShowHighlight = true;
            this.ledReal1.Size = new System.Drawing.Size(330, 128);
            this.ledReal1.TabIndex = 21;
            this.ledReal1.Text = "0";
            this.ledReal1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lvRealList
            // 
            this.lvRealList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader37,
            this.columnHeader38,
            this.columnHeader39,
            this.columnHeader40,
            this.columnHeader41,
            this.columnHeader42});
            this.lvRealList.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvRealList.GridLines = true;
            this.lvRealList.Location = new System.Drawing.Point(1, 340);
            this.lvRealList.Name = "lvRealList";
            this.lvRealList.Size = new System.Drawing.Size(577, 179);
            this.lvRealList.TabIndex = 23;
            this.lvRealList.UseCompatibleStateImageBehavior = false;
            this.lvRealList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "ID";
            this.columnHeader37.Width = 56;
            // 
            // columnHeader38
            // 
            this.columnHeader38.Text = "EPC";
            this.columnHeader38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader38.Width = 486;
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "PC";
            this.columnHeader39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader39.Width = 83;
            // 
            // columnHeader40
            // 
            this.columnHeader40.Text = "Identification Count";
            this.columnHeader40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader40.Width = 149;
            // 
            // columnHeader41
            // 
            this.columnHeader41.Text = "RSSI";
            this.columnHeader41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader41.Width = 95;
            // 
            // columnHeader42
            // 
            this.columnHeader42.Text = "Carrier Frequency";
            this.columnHeader42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader42.Width = 114;
            // 
            // pageBufferedMode
            // 
            this.pageBufferedMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageBufferedMode.Controls.Add(this.tableLayoutPanel4);
            this.pageBufferedMode.Controls.Add(this.groupBox3);
            this.pageBufferedMode.Controls.Add(this.btBufferFresh);
            this.pageBufferedMode.Controls.Add(this.labelBufferTagCount);
            this.pageBufferedMode.Controls.Add(this.lvBufferList);
            this.pageBufferedMode.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pageBufferedMode.Location = new System.Drawing.Point(4, 22);
            this.pageBufferedMode.Name = "pageBufferedMode";
            this.pageBufferedMode.Size = new System.Drawing.Size(1000, 568);
            this.pageBufferedMode.TabIndex = 2;
            this.pageBufferedMode.Text = "Tag Inventory(Buffer Mode)";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.22422F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.77578F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.tableLayoutPanel4.Controls.Add(this.panel9, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1000, 89);
            this.tableLayoutPanel4.TabIndex = 58;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btClearBuffer);
            this.panel9.Controls.Add(this.btQueryBuffer);
            this.panel9.Controls.Add(this.btGetClearBuffer);
            this.panel9.Controls.Add(this.btGetBuffer);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(631, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(365, 81);
            this.panel9.TabIndex = 1;
            // 
            // btClearBuffer
            // 
            this.btClearBuffer.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearBuffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClearBuffer.Location = new System.Drawing.Point(15, 44);
            this.btClearBuffer.Name = "btClearBuffer";
            this.btClearBuffer.Size = new System.Drawing.Size(135, 27);
            this.btClearBuffer.TabIndex = 8;
            this.btClearBuffer.Text = "Clear Buffer";
            this.btClearBuffer.UseVisualStyleBackColor = true;
            this.btClearBuffer.Click += new System.EventHandler(this.btClearBuffer_Click);
            // 
            // btQueryBuffer
            // 
            this.btQueryBuffer.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQueryBuffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btQueryBuffer.Location = new System.Drawing.Point(167, 44);
            this.btQueryBuffer.Name = "btQueryBuffer";
            this.btQueryBuffer.Size = new System.Drawing.Size(135, 27);
            this.btQueryBuffer.TabIndex = 7;
            this.btQueryBuffer.Text = "Query Tag Quantity";
            this.btQueryBuffer.UseVisualStyleBackColor = true;
            this.btQueryBuffer.Click += new System.EventHandler(this.btQueryBuffer_Click);
            // 
            // btGetClearBuffer
            // 
            this.btGetClearBuffer.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGetClearBuffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btGetClearBuffer.Location = new System.Drawing.Point(167, 11);
            this.btGetClearBuffer.Name = "btGetClearBuffer";
            this.btGetClearBuffer.Size = new System.Drawing.Size(135, 27);
            this.btGetClearBuffer.TabIndex = 6;
            this.btGetClearBuffer.Text = "Get and Clear Buffer";
            this.btGetClearBuffer.UseVisualStyleBackColor = true;
            this.btGetClearBuffer.Click += new System.EventHandler(this.btGetClearBuffer_Click);
            // 
            // btGetBuffer
            // 
            this.btGetBuffer.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGetBuffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btGetBuffer.Location = new System.Drawing.Point(15, 11);
            this.btGetBuffer.Name = "btGetBuffer";
            this.btGetBuffer.Size = new System.Drawing.Size(135, 27);
            this.btGetBuffer.TabIndex = 5;
            this.btGetBuffer.Text = "Get Buffer";
            this.btGetBuffer.UseVisualStyleBackColor = true;
            this.btGetBuffer.Click += new System.EventHandler(this.btGetBuffer_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btBufferInventory);
            this.panel10.Controls.Add(this.label85);
            this.panel10.Controls.Add(this.textReadRoundBuffer);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(308, 81);
            this.panel10.TabIndex = 0;
            // 
            // btBufferInventory
            // 
            this.btBufferInventory.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btBufferInventory.ForeColor = System.Drawing.Color.DarkBlue;
            this.btBufferInventory.Location = new System.Drawing.Point(7, 15);
            this.btBufferInventory.Name = "btBufferInventory";
            this.btBufferInventory.Size = new System.Drawing.Size(144, 41);
            this.btBufferInventory.TabIndex = 51;
            this.btBufferInventory.Text = "Inventory";
            this.btBufferInventory.UseVisualStyleBackColor = true;
            this.btBufferInventory.Click += new System.EventHandler(this.btBufferInventory_Click);
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label85.Location = new System.Drawing.Point(163, 31);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(119, 12);
            this.label85.TabIndex = 49;
            this.label85.Text = "Repeat Per Command:";
            // 
            // textReadRoundBuffer
            // 
            this.textReadRoundBuffer.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textReadRoundBuffer.Location = new System.Drawing.Point(288, 28);
            this.textReadRoundBuffer.Name = "textReadRoundBuffer";
            this.textReadRoundBuffer.Size = new System.Drawing.Size(28, 21);
            this.textReadRoundBuffer.TabIndex = 50;
            this.textReadRoundBuffer.Text = "1";
            this.textReadRoundBuffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbBufferWorkant1);
            this.panel8.Controls.Add(this.cbBufferWorkant4);
            this.panel8.Controls.Add(this.cbBufferWorkant2);
            this.panel8.Controls.Add(this.cbBufferWorkant3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(319, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(305, 81);
            this.panel8.TabIndex = 0;
            // 
            // cbBufferWorkant1
            // 
            this.cbBufferWorkant1.AutoSize = true;
            this.cbBufferWorkant1.Checked = true;
            this.cbBufferWorkant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBufferWorkant1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBufferWorkant1.Location = new System.Drawing.Point(28, 30);
            this.cbBufferWorkant1.Name = "cbBufferWorkant1";
            this.cbBufferWorkant1.Size = new System.Drawing.Size(48, 16);
            this.cbBufferWorkant1.TabIndex = 11;
            this.cbBufferWorkant1.Text = "Ant1";
            this.cbBufferWorkant1.UseVisualStyleBackColor = true;
            // 
            // cbBufferWorkant4
            // 
            this.cbBufferWorkant4.AutoSize = true;
            this.cbBufferWorkant4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBufferWorkant4.Location = new System.Drawing.Point(253, 31);
            this.cbBufferWorkant4.Name = "cbBufferWorkant4";
            this.cbBufferWorkant4.Size = new System.Drawing.Size(48, 16);
            this.cbBufferWorkant4.TabIndex = 10;
            this.cbBufferWorkant4.Text = "Ant4";
            this.cbBufferWorkant4.UseVisualStyleBackColor = true;
            // 
            // cbBufferWorkant2
            // 
            this.cbBufferWorkant2.AutoSize = true;
            this.cbBufferWorkant2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBufferWorkant2.Location = new System.Drawing.Point(103, 31);
            this.cbBufferWorkant2.Name = "cbBufferWorkant2";
            this.cbBufferWorkant2.Size = new System.Drawing.Size(48, 16);
            this.cbBufferWorkant2.TabIndex = 8;
            this.cbBufferWorkant2.Text = "Ant2";
            this.cbBufferWorkant2.UseVisualStyleBackColor = true;
            // 
            // cbBufferWorkant3
            // 
            this.cbBufferWorkant3.AutoSize = true;
            this.cbBufferWorkant3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBufferWorkant3.Location = new System.Drawing.Point(178, 31);
            this.cbBufferWorkant3.Name = "cbBufferWorkant3";
            this.cbBufferWorkant3.Size = new System.Drawing.Size(48, 16);
            this.cbBufferWorkant3.TabIndex = 9;
            this.cbBufferWorkant3.Text = "Ant3";
            this.cbBufferWorkant3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ledBuffer4);
            this.groupBox3.Controls.Add(this.comboBox11);
            this.groupBox3.Controls.Add(this.ledBuffer5);
            this.groupBox3.Controls.Add(this.ledBuffer2);
            this.groupBox3.Controls.Add(this.ledBuffer3);
            this.groupBox3.Controls.Add(this.label92);
            this.groupBox3.Controls.Add(this.label93);
            this.groupBox3.Controls.Add(this.label94);
            this.groupBox3.Controls.Add(this.label95);
            this.groupBox3.Controls.Add(this.label96);
            this.groupBox3.Controls.Add(this.ledBuffer1);
            this.groupBox3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(0, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(996, 176);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tag Data";
            // 
            // ledBuffer4
            // 
            this.ledBuffer4.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer4.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer4.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer4.BevelRate = 0.1F;
            this.ledBuffer4.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer4.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer4.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledBuffer4.HighlightOpaque = ((byte)(20));
            this.ledBuffer4.Location = new System.Drawing.Point(702, 54);
            this.ledBuffer4.Name = "ledBuffer4";
            this.ledBuffer4.RoundCorner = true;
            this.ledBuffer4.SegmentIntervalRatio = 50;
            this.ledBuffer4.ShowHighlight = true;
            this.ledBuffer4.Size = new System.Drawing.Size(201, 38);
            this.ledBuffer4.TabIndex = 40;
            this.ledBuffer4.Text = "0";
            this.ledBuffer4.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledBuffer4.TotalCharCount = 10;
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.comboBox11.Location = new System.Drawing.Point(-165, 120);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(55, 20);
            this.comboBox11.TabIndex = 39;
            // 
            // ledBuffer5
            // 
            this.ledBuffer5.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer5.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer5.BevelRate = 0.1F;
            this.ledBuffer5.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledBuffer5.HighlightOpaque = ((byte)(20));
            this.ledBuffer5.Location = new System.Drawing.Point(702, 128);
            this.ledBuffer5.Name = "ledBuffer5";
            this.ledBuffer5.RoundCorner = true;
            this.ledBuffer5.SegmentIntervalRatio = 50;
            this.ledBuffer5.ShowHighlight = true;
            this.ledBuffer5.Size = new System.Drawing.Size(201, 38);
            this.ledBuffer5.TabIndex = 35;
            this.ledBuffer5.Text = "0";
            this.ledBuffer5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledBuffer5.TotalCharCount = 10;
            // 
            // ledBuffer2
            // 
            this.ledBuffer2.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer2.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer2.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer2.BevelRate = 0.1F;
            this.ledBuffer2.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer2.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer2.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer2.ForeColor = System.Drawing.Color.Purple;
            this.ledBuffer2.HighlightOpaque = ((byte)(20));
            this.ledBuffer2.Location = new System.Drawing.Point(496, 38);
            this.ledBuffer2.Name = "ledBuffer2";
            this.ledBuffer2.RoundCorner = true;
            this.ledBuffer2.SegmentIntervalRatio = 50;
            this.ledBuffer2.ShowHighlight = true;
            this.ledBuffer2.Size = new System.Drawing.Size(176, 54);
            this.ledBuffer2.TabIndex = 34;
            this.ledBuffer2.Text = "0";
            this.ledBuffer2.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledBuffer2.TotalCharCount = 6;
            // 
            // ledBuffer3
            // 
            this.ledBuffer3.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer3.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer3.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer3.BevelRate = 0.1F;
            this.ledBuffer3.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer3.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer3.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer3.ForeColor = System.Drawing.Color.Purple;
            this.ledBuffer3.HighlightOpaque = ((byte)(20));
            this.ledBuffer3.Location = new System.Drawing.Point(497, 112);
            this.ledBuffer3.Name = "ledBuffer3";
            this.ledBuffer3.RoundCorner = true;
            this.ledBuffer3.SegmentIntervalRatio = 50;
            this.ledBuffer3.ShowHighlight = true;
            this.ledBuffer3.Size = new System.Drawing.Size(175, 54);
            this.ledBuffer3.TabIndex = 33;
            this.ledBuffer3.Text = "0";
            this.ledBuffer3.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledBuffer3.TotalCharCount = 6;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label92.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label92.Location = new System.Drawing.Point(700, 112);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(179, 12);
            this.label92.TabIndex = 30;
            this.label92.Text = "Total Inventory Duration(mS):";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label93.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label93.Location = new System.Drawing.Point(495, 18);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(95, 12);
            this.label93.TabIndex = 29;
            this.label93.Text = "Speed(Tag/Sec):";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label94.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label94.Location = new System.Drawing.Point(498, 95);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(131, 12);
            this.label94.TabIndex = 28;
            this.label94.Text = "Command Duration(mS):";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label95.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label95.Location = new System.Drawing.Point(700, 38);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(149, 12);
            this.label95.TabIndex = 27;
            this.label95.Text = "Total Tag Communication:";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label96.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label96.Location = new System.Drawing.Point(104, 18);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(131, 12);
            this.label96.TabIndex = 26;
            this.label96.Text = "Inventoried Quantity:";
            // 
            // ledBuffer1
            // 
            this.ledBuffer1.BackColor = System.Drawing.Color.Transparent;
            this.ledBuffer1.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledBuffer1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledBuffer1.BevelRate = 0.1F;
            this.ledBuffer1.BorderColor = System.Drawing.Color.Lavender;
            this.ledBuffer1.BorderWidth = 3;
            this.ledBuffer1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledBuffer1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledBuffer1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledBuffer1.HighlightOpaque = ((byte)(20));
            this.ledBuffer1.Location = new System.Drawing.Point(106, 38);
            this.ledBuffer1.Name = "ledBuffer1";
            this.ledBuffer1.RoundCorner = true;
            this.ledBuffer1.SegmentIntervalRatio = 50;
            this.ledBuffer1.ShowHighlight = true;
            this.ledBuffer1.Size = new System.Drawing.Size(333, 128);
            this.ledBuffer1.TabIndex = 21;
            this.ledBuffer1.Text = "0";
            this.ledBuffer1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // btBufferFresh
            // 
            this.btBufferFresh.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btBufferFresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btBufferFresh.Location = new System.Drawing.Point(907, 277);
            this.btBufferFresh.Name = "btBufferFresh";
            this.btBufferFresh.Size = new System.Drawing.Size(89, 25);
            this.btBufferFresh.TabIndex = 52;
            this.btBufferFresh.Text = "Refresh";
            this.btBufferFresh.UseVisualStyleBackColor = true;
            this.btBufferFresh.Click += new System.EventHandler(this.btBufferFresh_Click);
            // 
            // labelBufferTagCount
            // 
            this.labelBufferTagCount.AutoSize = true;
            this.labelBufferTagCount.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBufferTagCount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelBufferTagCount.Location = new System.Drawing.Point(6, 283);
            this.labelBufferTagCount.Name = "labelBufferTagCount";
            this.labelBufferTagCount.Size = new System.Drawing.Size(59, 12);
            this.labelBufferTagCount.TabIndex = 49;
            this.labelBufferTagCount.Text = "Tag List:";
            // 
            // lvBufferList
            // 
            this.lvBufferList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader49,
            this.columnHeader50,
            this.columnHeader51,
            this.columnHeader52,
            this.columnHeader53,
            this.columnHeader54,
            this.columnHeader16});
            this.lvBufferList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvBufferList.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvBufferList.GridLines = true;
            this.lvBufferList.Location = new System.Drawing.Point(0, 310);
            this.lvBufferList.Name = "lvBufferList";
            this.lvBufferList.Size = new System.Drawing.Size(1000, 258);
            this.lvBufferList.TabIndex = 48;
            this.lvBufferList.UseCompatibleStateImageBehavior = false;
            this.lvBufferList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader49
            // 
            this.columnHeader49.Text = "ID";
            this.columnHeader49.Width = 56;
            // 
            // columnHeader50
            // 
            this.columnHeader50.Text = "PC";
            this.columnHeader50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader50.Width = 64;
            // 
            // columnHeader51
            // 
            this.columnHeader51.Text = "CRC";
            this.columnHeader51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader51.Width = 74;
            // 
            // columnHeader52
            // 
            this.columnHeader52.Text = "EPC";
            this.columnHeader52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader52.Width = 492;
            // 
            // columnHeader53
            // 
            this.columnHeader53.Text = "Ant ID";
            this.columnHeader53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader53.Width = 95;
            // 
            // columnHeader54
            // 
            this.columnHeader54.Text = "RSSI";
            this.columnHeader54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader54.Width = 71;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Identification Count";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 135;
            // 
            // pageFast4AntMode
            // 
            this.pageFast4AntMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageFast4AntMode.Controls.Add(this.groupBox2);
            this.pageFast4AntMode.Controls.Add(this.txtFastMaxRssi);
            this.pageFast4AntMode.Controls.Add(this.txtFastMinRssi);
            this.pageFast4AntMode.Controls.Add(this.buttonFastFresh);
            this.pageFast4AntMode.Controls.Add(this.tableLayoutPanel2);
            this.pageFast4AntMode.Controls.Add(this.label22);
            this.pageFast4AntMode.Controls.Add(this.lvFastList);
            this.pageFast4AntMode.Controls.Add(this.label49);
            this.pageFast4AntMode.Controls.Add(this.txtFastTagList);
            this.pageFast4AntMode.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pageFast4AntMode.Location = new System.Drawing.Point(4, 22);
            this.pageFast4AntMode.Name = "pageFast4AntMode";
            this.pageFast4AntMode.Padding = new System.Windows.Forms.Padding(3);
            this.pageFast4AntMode.Size = new System.Drawing.Size(1000, 568);
            this.pageFast4AntMode.TabIndex = 0;
            this.pageFast4AntMode.Text = "Tag Inventory(Fast Switch Antenna Mode)";
            this.pageFast4AntMode.Enter += new System.EventHandler(this.pageFast4AntMode_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ledFast4);
            this.groupBox2.Controls.Add(this.comboBox7);
            this.groupBox2.Controls.Add(this.ledFast5);
            this.groupBox2.Controls.Add(this.ledFast2);
            this.groupBox2.Controls.Add(this.ledFast3);
            this.groupBox2.Controls.Add(this.label54);
            this.groupBox2.Controls.Add(this.label55);
            this.groupBox2.Controls.Add(this.label56);
            this.groupBox2.Controls.Add(this.label57);
            this.groupBox2.Controls.Add(this.label58);
            this.groupBox2.Controls.Add(this.ledFast1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(3, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(994, 176);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tag Data";
            // 
            // ledFast4
            // 
            this.ledFast4.BackColor = System.Drawing.Color.Transparent;
            this.ledFast4.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast4.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast4.BevelRate = 0.1F;
            this.ledFast4.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast4.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast4.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledFast4.HighlightOpaque = ((byte)(20));
            this.ledFast4.Location = new System.Drawing.Point(702, 54);
            this.ledFast4.Name = "ledFast4";
            this.ledFast4.RoundCorner = true;
            this.ledFast4.SegmentIntervalRatio = 50;
            this.ledFast4.ShowHighlight = true;
            this.ledFast4.Size = new System.Drawing.Size(201, 38);
            this.ledFast4.TabIndex = 40;
            this.ledFast4.Text = "0";
            this.ledFast4.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledFast4.TotalCharCount = 10;
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.comboBox7.Location = new System.Drawing.Point(-165, 120);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(55, 20);
            this.comboBox7.TabIndex = 39;
            // 
            // ledFast5
            // 
            this.ledFast5.BackColor = System.Drawing.Color.Transparent;
            this.ledFast5.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast5.BevelRate = 0.1F;
            this.ledFast5.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledFast5.HighlightOpaque = ((byte)(20));
            this.ledFast5.Location = new System.Drawing.Point(702, 128);
            this.ledFast5.Name = "ledFast5";
            this.ledFast5.RoundCorner = true;
            this.ledFast5.SegmentIntervalRatio = 50;
            this.ledFast5.ShowHighlight = true;
            this.ledFast5.Size = new System.Drawing.Size(201, 38);
            this.ledFast5.TabIndex = 35;
            this.ledFast5.Text = "0";
            this.ledFast5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledFast5.TotalCharCount = 10;
            // 
            // ledFast2
            // 
            this.ledFast2.BackColor = System.Drawing.Color.Transparent;
            this.ledFast2.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast2.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast2.BevelRate = 0.1F;
            this.ledFast2.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast2.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast2.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast2.ForeColor = System.Drawing.Color.Purple;
            this.ledFast2.HighlightOpaque = ((byte)(20));
            this.ledFast2.Location = new System.Drawing.Point(496, 38);
            this.ledFast2.Name = "ledFast2";
            this.ledFast2.RoundCorner = true;
            this.ledFast2.SegmentIntervalRatio = 50;
            this.ledFast2.ShowHighlight = true;
            this.ledFast2.Size = new System.Drawing.Size(174, 54);
            this.ledFast2.TabIndex = 34;
            this.ledFast2.Text = "0";
            this.ledFast2.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledFast2.TotalCharCount = 6;
            // 
            // ledFast3
            // 
            this.ledFast3.BackColor = System.Drawing.Color.Transparent;
            this.ledFast3.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast3.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast3.BevelRate = 0.1F;
            this.ledFast3.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast3.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast3.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast3.ForeColor = System.Drawing.Color.Purple;
            this.ledFast3.HighlightOpaque = ((byte)(20));
            this.ledFast3.Location = new System.Drawing.Point(497, 112);
            this.ledFast3.Name = "ledFast3";
            this.ledFast3.RoundCorner = true;
            this.ledFast3.SegmentIntervalRatio = 50;
            this.ledFast3.ShowHighlight = true;
            this.ledFast3.Size = new System.Drawing.Size(173, 54);
            this.ledFast3.TabIndex = 33;
            this.ledFast3.Text = "0";
            this.ledFast3.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.ledFast3.TotalCharCount = 6;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label54.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label54.Location = new System.Drawing.Point(700, 112);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(179, 12);
            this.label54.TabIndex = 30;
            this.label54.Text = "Total Inventory Duration(mS):";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label55.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label55.Location = new System.Drawing.Point(495, 18);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(95, 12);
            this.label55.TabIndex = 29;
            this.label55.Text = "Speed(Tag/Sec):";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label56.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label56.Location = new System.Drawing.Point(498, 95);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(131, 12);
            this.label56.TabIndex = 28;
            this.label56.Text = "Command Duration(mS):";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label57.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label57.Location = new System.Drawing.Point(700, 38);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(149, 12);
            this.label57.TabIndex = 27;
            this.label57.Text = "Total Tag Communication:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label58.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label58.Location = new System.Drawing.Point(104, 18);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(125, 12);
            this.label58.TabIndex = 26;
            this.label58.Text = "Inventoried Quantity";
            // 
            // ledFast1
            // 
            this.ledFast1.BackColor = System.Drawing.Color.Transparent;
            this.ledFast1.BackColor_1 = System.Drawing.Color.Transparent;
            this.ledFast1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.ledFast1.BevelRate = 0.1F;
            this.ledFast1.BorderColor = System.Drawing.Color.Lavender;
            this.ledFast1.BorderWidth = 3;
            this.ledFast1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.ledFast1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.ledFast1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ledFast1.HighlightOpaque = ((byte)(20));
            this.ledFast1.Location = new System.Drawing.Point(106, 38);
            this.ledFast1.Name = "ledFast1";
            this.ledFast1.RoundCorner = true;
            this.ledFast1.SegmentIntervalRatio = 50;
            this.ledFast1.ShowHighlight = true;
            this.ledFast1.Size = new System.Drawing.Size(328, 128);
            this.ledFast1.TabIndex = 21;
            this.ledFast1.Text = "0";
            this.ledFast1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // txtFastMaxRssi
            // 
            this.txtFastMaxRssi.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFastMaxRssi.Location = new System.Drawing.Point(705, 271);
            this.txtFastMaxRssi.Name = "txtFastMaxRssi";
            this.txtFastMaxRssi.Size = new System.Drawing.Size(62, 21);
            this.txtFastMaxRssi.TabIndex = 40;
            // 
            // txtFastMinRssi
            // 
            this.txtFastMinRssi.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFastMinRssi.Location = new System.Drawing.Point(499, 271);
            this.txtFastMinRssi.Name = "txtFastMinRssi";
            this.txtFastMinRssi.Size = new System.Drawing.Size(62, 21);
            this.txtFastMinRssi.TabIndex = 41;
            // 
            // buttonFastFresh
            // 
            this.buttonFastFresh.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFastFresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonFastFresh.Location = new System.Drawing.Point(905, 271);
            this.buttonFastFresh.Name = "buttonFastFresh";
            this.buttonFastFresh.Size = new System.Drawing.Size(89, 25);
            this.buttonFastFresh.TabIndex = 28;
            this.buttonFastFresh.Text = "Refresh";
            this.buttonFastFresh.UseVisualStyleBackColor = true;
            this.buttonFastFresh.Click += new System.EventHandler(this.buttonFastFresh_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.20588F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.79412F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 317F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(994, 86);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDStay);
            this.panel2.Controls.Add(this.txtCStay);
            this.panel2.Controls.Add(this.txtBStay);
            this.panel2.Controls.Add(this.txtAStay);
            this.panel2.Controls.Add(this.label64);
            this.panel2.Controls.Add(this.label65);
            this.panel2.Controls.Add(this.cmbAntSelect1);
            this.panel2.Controls.Add(this.label62);
            this.panel2.Controls.Add(this.cmbAntSelect2);
            this.panel2.Controls.Add(this.label63);
            this.panel2.Controls.Add(this.cmbAntSelect3);
            this.panel2.Controls.Add(this.label60);
            this.panel2.Controls.Add(this.cmbAntSelect4);
            this.panel2.Controls.Add(this.label61);
            this.panel2.Controls.Add(this.label59);
            this.panel2.Controls.Add(this.label48);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(189, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 76);
            this.panel2.TabIndex = 0;
            // 
            // txtDStay
            // 
            this.txtDStay.AcceptsReturn = true;
            this.txtDStay.Location = new System.Drawing.Point(462, 29);
            this.txtDStay.Name = "txtDStay";
            this.txtDStay.Size = new System.Drawing.Size(42, 21);
            this.txtDStay.TabIndex = 59;
            this.txtDStay.Text = "1";
            this.txtDStay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCStay
            // 
            this.txtCStay.Location = new System.Drawing.Point(336, 29);
            this.txtCStay.Name = "txtCStay";
            this.txtCStay.Size = new System.Drawing.Size(42, 21);
            this.txtCStay.TabIndex = 58;
            this.txtCStay.Text = "1";
            this.txtCStay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBStay
            // 
            this.txtBStay.Location = new System.Drawing.Point(206, 28);
            this.txtBStay.Name = "txtBStay";
            this.txtBStay.Size = new System.Drawing.Size(42, 21);
            this.txtBStay.TabIndex = 57;
            this.txtBStay.Text = "1";
            this.txtBStay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAStay
            // 
            this.txtAStay.Location = new System.Drawing.Point(79, 28);
            this.txtAStay.Name = "txtAStay";
            this.txtAStay.Size = new System.Drawing.Size(42, 21);
            this.txtAStay.TabIndex = 56;
            this.txtAStay.Text = "1";
            this.txtAStay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label64.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label64.Location = new System.Drawing.Point(466, 13);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(35, 12);
            this.label64.TabIndex = 39;
            this.label64.Text = "Round";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label65.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label65.Location = new System.Drawing.Point(416, 13);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(11, 12);
            this.label65.TabIndex = 38;
            this.label65.Text = "D";
            // 
            // cmbAntSelect1
            // 
            this.cmbAntSelect1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAntSelect1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAntSelect1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAntSelect1.FormattingEnabled = true;
            this.cmbAntSelect1.Items.AddRange(new object[] {
            "ANT1",
            "ANT2",
            "ANT3",
            "ANT4",
            "Unselect"});
            this.cmbAntSelect1.Location = new System.Drawing.Point(5, 29);
            this.cmbAntSelect1.Name = "cmbAntSelect1";
            this.cmbAntSelect1.Size = new System.Drawing.Size(68, 20);
            this.cmbAntSelect1.TabIndex = 13;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label62.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label62.Location = new System.Drawing.Point(334, 13);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(35, 12);
            this.label62.TabIndex = 37;
            this.label62.Text = "Round";
            // 
            // cmbAntSelect2
            // 
            this.cmbAntSelect2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAntSelect2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAntSelect2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAntSelect2.FormattingEnabled = true;
            this.cmbAntSelect2.Items.AddRange(new object[] {
            "ANT1",
            "ANT2",
            "ANT3",
            "ANT4",
            "Unselect"});
            this.cmbAntSelect2.Location = new System.Drawing.Point(134, 30);
            this.cmbAntSelect2.Name = "cmbAntSelect2";
            this.cmbAntSelect2.Size = new System.Drawing.Size(67, 20);
            this.cmbAntSelect2.TabIndex = 14;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label63.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label63.Location = new System.Drawing.Point(292, 13);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(11, 12);
            this.label63.TabIndex = 36;
            this.label63.Text = "C";
            // 
            // cmbAntSelect3
            // 
            this.cmbAntSelect3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAntSelect3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAntSelect3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAntSelect3.FormattingEnabled = true;
            this.cmbAntSelect3.Items.AddRange(new object[] {
            "ANT1",
            "ANT2",
            "ANT3",
            "ANT4",
            "Unselect"});
            this.cmbAntSelect3.Location = new System.Drawing.Point(262, 29);
            this.cmbAntSelect3.Name = "cmbAntSelect3";
            this.cmbAntSelect3.Size = new System.Drawing.Size(68, 20);
            this.cmbAntSelect3.TabIndex = 15;
            this.cmbAntSelect3.SelectedIndexChanged += new System.EventHandler(this.cmbAntSelect3_SelectedIndexChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label60.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label60.Location = new System.Drawing.Point(201, 13);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(35, 12);
            this.label60.TabIndex = 35;
            this.label60.Text = "Round";
            // 
            // cmbAntSelect4
            // 
            this.cmbAntSelect4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAntSelect4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAntSelect4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAntSelect4.FormattingEnabled = true;
            this.cmbAntSelect4.Items.AddRange(new object[] {
            "ANT1",
            "ANT2",
            "ANT3",
            "ANT4",
            "Unselect"});
            this.cmbAntSelect4.Location = new System.Drawing.Point(389, 29);
            this.cmbAntSelect4.Name = "cmbAntSelect4";
            this.cmbAntSelect4.Size = new System.Drawing.Size(67, 20);
            this.cmbAntSelect4.TabIndex = 16;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label61.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label61.Location = new System.Drawing.Point(164, 13);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(11, 12);
            this.label61.TabIndex = 34;
            this.label61.Text = "B";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label59.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label59.Location = new System.Drawing.Point(80, 13);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(35, 12);
            this.label59.TabIndex = 33;
            this.label59.Text = "Round";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label48.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label48.Location = new System.Drawing.Point(34, 13);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(11, 12);
            this.label48.TabIndex = 32;
            this.label48.Text = "A";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btFastInventory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 76);
            this.panel3.TabIndex = 1;
            // 
            // btFastInventory
            // 
            this.btFastInventory.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFastInventory.ForeColor = System.Drawing.Color.DarkBlue;
            this.btFastInventory.Location = new System.Drawing.Point(28, 17);
            this.btFastInventory.Name = "btFastInventory";
            this.btFastInventory.Size = new System.Drawing.Size(144, 41);
            this.btFastInventory.TabIndex = 52;
            this.btFastInventory.Text = "Inventory";
            this.btFastInventory.UseVisualStyleBackColor = true;
            this.btFastInventory.Click += new System.EventHandler(this.btFastInventory_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtRepeat);
            this.panel4.Controls.Add(this.txtInterval);
            this.panel4.Controls.Add(this.label73);
            this.panel4.Controls.Add(this.label72);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(677, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(312, 76);
            this.panel4.TabIndex = 2;
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(187, 28);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(42, 21);
            this.txtRepeat.TabIndex = 58;
            this.txtRepeat.Text = "10";
            this.txtRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(65, 28);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(42, 21);
            this.txtInterval.TabIndex = 57;
            this.txtInterval.Text = "0";
            this.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label73.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label73.Location = new System.Drawing.Point(11, 13);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(149, 12);
            this.label73.TabIndex = 36;
            this.label73.Text = "Interval Between Ant(mS)";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label72.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label72.Location = new System.Drawing.Point(188, 13);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(41, 12);
            this.label72.TabIndex = 37;
            this.label72.Text = "Repeat";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(634, 276);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 26;
            this.label22.Text = "Max RSSI:";
            // 
            // lvFastList
            // 
            this.lvFastList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader33,
            this.columnHeader34,
            this.columnHeader35,
            this.columnHeader36});
            this.lvFastList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvFastList.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvFastList.GridLines = true;
            this.lvFastList.Location = new System.Drawing.Point(3, 304);
            this.lvFastList.Name = "lvFastList";
            this.lvFastList.Size = new System.Drawing.Size(994, 261);
            this.lvFastList.TabIndex = 24;
            this.lvFastList.UseCompatibleStateImageBehavior = false;
            this.lvFastList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "ID";
            this.columnHeader31.Width = 52;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "EPC";
            this.columnHeader32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader32.Width = 428;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "PC";
            this.columnHeader33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader33.Width = 65;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "Identification Count(ANT1/ANT2/ANT3/ANT4)";
            this.columnHeader34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader34.Width = 261;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "RSSI";
            this.columnHeader35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader35.Width = 86;
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "Carrier Freq";
            this.columnHeader36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader36.Width = 92;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label49.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label49.Location = new System.Drawing.Point(428, 276);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(59, 12);
            this.label49.TabIndex = 27;
            this.label49.Text = "Min RSSI:";
            // 
            // txtFastTagList
            // 
            this.txtFastTagList.AutoSize = true;
            this.txtFastTagList.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFastTagList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtFastTagList.Location = new System.Drawing.Point(6, 276);
            this.txtFastTagList.Name = "txtFastTagList";
            this.txtFastTagList.Size = new System.Drawing.Size(59, 12);
            this.txtFastTagList.TabIndex = 23;
            this.txtFastTagList.Text = "Tag List:";
            // 
            // pageAcessTag
            // 
            this.pageAcessTag.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageAcessTag.Controls.Add(this.ltvOperate);
            this.pageAcessTag.Controls.Add(this.gbCmdOperateTag);
            this.pageAcessTag.Location = new System.Drawing.Point(4, 22);
            this.pageAcessTag.Name = "pageAcessTag";
            this.pageAcessTag.Size = new System.Drawing.Size(1000, 568);
            this.pageAcessTag.TabIndex = 3;
            this.pageAcessTag.Text = "Access Tag";
            this.pageAcessTag.UseVisualStyleBackColor = true;
            // 
            // ltvOperate
            // 
            this.ltvOperate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.ltvOperate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltvOperate.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ltvOperate.GridLines = true;
            this.ltvOperate.Location = new System.Drawing.Point(0, 348);
            this.ltvOperate.Name = "ltvOperate";
            this.ltvOperate.Size = new System.Drawing.Size(1000, 220);
            this.ltvOperate.TabIndex = 10;
            this.ltvOperate.UseCompatibleStateImageBehavior = false;
            this.ltvOperate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "PC";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "CRC";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "EPC";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 260;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Data";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 334;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Data Len";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 73;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Ant ID";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 49;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Operated Count";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 98;
            // 
            // gbCmdOperateTag
            // 
            this.gbCmdOperateTag.Controls.Add(this.groupBox16);
            this.gbCmdOperateTag.Controls.Add(this.groupBox15);
            this.gbCmdOperateTag.Controls.Add(this.groupBox14);
            this.gbCmdOperateTag.Controls.Add(this.groupBox13);
            this.gbCmdOperateTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCmdOperateTag.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbCmdOperateTag.Location = new System.Drawing.Point(0, 0);
            this.gbCmdOperateTag.Name = "gbCmdOperateTag";
            this.gbCmdOperateTag.Size = new System.Drawing.Size(1000, 348);
            this.gbCmdOperateTag.TabIndex = 8;
            this.gbCmdOperateTag.TabStop = false;
            this.gbCmdOperateTag.Text = "Tag Access";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.btnKillTag);
            this.groupBox16.Controls.Add(this.htxtKillPwd);
            this.groupBox16.Controls.Add(this.label29);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox16.Location = new System.Drawing.Point(3, 277);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(994, 54);
            this.groupBox16.TabIndex = 4;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Kill Tag";
            // 
            // btnKillTag
            // 
            this.btnKillTag.Location = new System.Drawing.Point(888, 21);
            this.btnKillTag.Name = "btnKillTag";
            this.btnKillTag.Size = new System.Drawing.Size(90, 25);
            this.btnKillTag.TabIndex = 14;
            this.btnKillTag.Text = "Kill";
            this.btnKillTag.UseVisualStyleBackColor = true;
            this.btnKillTag.Click += new System.EventHandler(this.btnKillTag_Click);
            // 
            // htxtKillPwd
            // 
            this.htxtKillPwd.Location = new System.Drawing.Point(402, 23);
            this.htxtKillPwd.Name = "htxtKillPwd";
            this.htxtKillPwd.Size = new System.Drawing.Size(120, 21);
            this.htxtKillPwd.TabIndex = 13;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(307, 27);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(119, 12);
            this.label29.TabIndex = 13;
            this.label29.Text = "Kill Password(HEX):";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.htxtLockPwd);
            this.groupBox15.Controls.Add(this.label28);
            this.groupBox15.Controls.Add(this.groupBox19);
            this.groupBox15.Controls.Add(this.groupBox18);
            this.groupBox15.Controls.Add(this.btnLockTag);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox15.Location = new System.Drawing.Point(3, 174);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(994, 103);
            this.groupBox15.TabIndex = 3;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Lock Tag";
            // 
            // htxtLockPwd
            // 
            this.htxtLockPwd.Location = new System.Drawing.Point(742, 49);
            this.htxtLockPwd.Name = "htxtLockPwd";
            this.htxtLockPwd.Size = new System.Drawing.Size(114, 21);
            this.htxtLockPwd.TabIndex = 12;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(606, 53);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(131, 12);
            this.label28.TabIndex = 12;
            this.label28.Text = "Access Password(HEX):";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.rdbUserMemory);
            this.groupBox19.Controls.Add(this.rdbTidMemory);
            this.groupBox19.Controls.Add(this.rdbEpcMermory);
            this.groupBox19.Controls.Add(this.rdbKillPwd);
            this.groupBox19.Controls.Add(this.rdbAccessPwd);
            this.groupBox19.Location = new System.Drawing.Point(16, 15);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(578, 43);
            this.groupBox19.TabIndex = 2;
            this.groupBox19.TabStop = false;
            // 
            // rdbUserMemory
            // 
            this.rdbUserMemory.AutoSize = true;
            this.rdbUserMemory.Location = new System.Drawing.Point(464, 16);
            this.rdbUserMemory.Name = "rdbUserMemory";
            this.rdbUserMemory.Size = new System.Drawing.Size(47, 16);
            this.rdbUserMemory.TabIndex = 4;
            this.rdbUserMemory.TabStop = true;
            this.rdbUserMemory.Text = "USER";
            this.rdbUserMemory.UseVisualStyleBackColor = true;
            // 
            // rdbTidMemory
            // 
            this.rdbTidMemory.AutoSize = true;
            this.rdbTidMemory.Location = new System.Drawing.Point(375, 16);
            this.rdbTidMemory.Name = "rdbTidMemory";
            this.rdbTidMemory.Size = new System.Drawing.Size(41, 16);
            this.rdbTidMemory.TabIndex = 3;
            this.rdbTidMemory.TabStop = true;
            this.rdbTidMemory.Text = "TID";
            this.rdbTidMemory.UseVisualStyleBackColor = true;
            // 
            // rdbEpcMermory
            // 
            this.rdbEpcMermory.AutoSize = true;
            this.rdbEpcMermory.Location = new System.Drawing.Point(269, 16);
            this.rdbEpcMermory.Name = "rdbEpcMermory";
            this.rdbEpcMermory.Size = new System.Drawing.Size(41, 16);
            this.rdbEpcMermory.TabIndex = 2;
            this.rdbEpcMermory.TabStop = true;
            this.rdbEpcMermory.Text = "EPC";
            this.rdbEpcMermory.UseVisualStyleBackColor = true;
            // 
            // rdbKillPwd
            // 
            this.rdbKillPwd.AutoSize = true;
            this.rdbKillPwd.Location = new System.Drawing.Point(142, 16);
            this.rdbKillPwd.Name = "rdbKillPwd";
            this.rdbKillPwd.Size = new System.Drawing.Size(101, 16);
            this.rdbKillPwd.TabIndex = 1;
            this.rdbKillPwd.TabStop = true;
            this.rdbKillPwd.Text = "Kill Password";
            this.rdbKillPwd.UseVisualStyleBackColor = true;
            // 
            // rdbAccessPwd
            // 
            this.rdbAccessPwd.AutoSize = true;
            this.rdbAccessPwd.Location = new System.Drawing.Point(9, 16);
            this.rdbAccessPwd.Name = "rdbAccessPwd";
            this.rdbAccessPwd.Size = new System.Drawing.Size(113, 16);
            this.rdbAccessPwd.TabIndex = 0;
            this.rdbAccessPwd.TabStop = true;
            this.rdbAccessPwd.Text = "Access Password";
            this.rdbAccessPwd.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.rdbLockEver);
            this.groupBox18.Controls.Add(this.rdbFreeEver);
            this.groupBox18.Controls.Add(this.rdbLock);
            this.groupBox18.Controls.Add(this.rdbFree);
            this.groupBox18.Location = new System.Drawing.Point(16, 55);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(578, 43);
            this.groupBox18.TabIndex = 1;
            this.groupBox18.TabStop = false;
            // 
            // rdbLockEver
            // 
            this.rdbLockEver.AutoSize = true;
            this.rdbLockEver.Location = new System.Drawing.Point(464, 15);
            this.rdbLockEver.Name = "rdbLockEver";
            this.rdbLockEver.Size = new System.Drawing.Size(107, 16);
            this.rdbLockEver.TabIndex = 3;
            this.rdbLockEver.TabStop = true;
            this.rdbLockEver.Text = "Permanent Lock";
            this.rdbLockEver.UseVisualStyleBackColor = true;
            // 
            // rdbFreeEver
            // 
            this.rdbFreeEver.AutoSize = true;
            this.rdbFreeEver.Location = new System.Drawing.Point(293, 15);
            this.rdbFreeEver.Name = "rdbFreeEver";
            this.rdbFreeEver.Size = new System.Drawing.Size(107, 16);
            this.rdbFreeEver.TabIndex = 2;
            this.rdbFreeEver.TabStop = true;
            this.rdbFreeEver.Text = "Permanent Open";
            this.rdbFreeEver.UseVisualStyleBackColor = true;
            // 
            // rdbLock
            // 
            this.rdbLock.AutoSize = true;
            this.rdbLock.Location = new System.Drawing.Point(144, 15);
            this.rdbLock.Name = "rdbLock";
            this.rdbLock.Size = new System.Drawing.Size(47, 16);
            this.rdbLock.TabIndex = 1;
            this.rdbLock.TabStop = true;
            this.rdbLock.Text = "Lock";
            this.rdbLock.UseVisualStyleBackColor = true;
            // 
            // rdbFree
            // 
            this.rdbFree.AutoSize = true;
            this.rdbFree.Location = new System.Drawing.Point(9, 15);
            this.rdbFree.Name = "rdbFree";
            this.rdbFree.Size = new System.Drawing.Size(47, 16);
            this.rdbFree.TabIndex = 0;
            this.rdbFree.TabStop = true;
            this.rdbFree.Text = "Open";
            this.rdbFree.UseVisualStyleBackColor = true;
            // 
            // btnLockTag
            // 
            this.btnLockTag.Location = new System.Drawing.Point(888, 48);
            this.btnLockTag.Name = "btnLockTag";
            this.btnLockTag.Size = new System.Drawing.Size(90, 25);
            this.btnLockTag.TabIndex = 0;
            this.btnLockTag.Text = "Lock";
            this.btnLockTag.UseVisualStyleBackColor = true;
            this.btnLockTag.Click += new System.EventHandler(this.btnLockTag_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.htxtWriteData);
            this.groupBox14.Controls.Add(this.txtWordCnt);
            this.groupBox14.Controls.Add(this.label27);
            this.groupBox14.Controls.Add(this.btnWriteTag);
            this.groupBox14.Controls.Add(this.btnReadTag);
            this.groupBox14.Controls.Add(this.txtWordAdd);
            this.groupBox14.Controls.Add(this.label26);
            this.groupBox14.Controls.Add(this.htxtReadAndWritePwd);
            this.groupBox14.Controls.Add(this.label25);
            this.groupBox14.Controls.Add(this.groupBox17);
            this.groupBox14.Controls.Add(this.label24);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox14.Location = new System.Drawing.Point(3, 71);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(994, 103);
            this.groupBox14.TabIndex = 2;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Read/Write Tag";
            // 
            // htxtWriteData
            // 
            this.htxtWriteData.Location = new System.Drawing.Point(171, 74);
            this.htxtWriteData.Name = "htxtWriteData";
            this.htxtWriteData.Size = new System.Drawing.Size(685, 21);
            this.htxtWriteData.TabIndex = 10;
            // 
            // txtWordCnt
            // 
            this.txtWordCnt.Location = new System.Drawing.Point(808, 25);
            this.txtWordCnt.Name = "txtWordCnt";
            this.txtWordCnt.Size = new System.Drawing.Size(48, 21);
            this.txtWordCnt.TabIndex = 9;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(719, 29);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 12);
            this.label27.TabIndex = 8;
            this.label27.Text = "Length(WORD):";
            // 
            // btnWriteTag
            // 
            this.btnWriteTag.Location = new System.Drawing.Point(888, 73);
            this.btnWriteTag.Name = "btnWriteTag";
            this.btnWriteTag.Size = new System.Drawing.Size(90, 25);
            this.btnWriteTag.TabIndex = 7;
            this.btnWriteTag.Text = "Write";
            this.btnWriteTag.UseVisualStyleBackColor = true;
            this.btnWriteTag.Click += new System.EventHandler(this.btnWriteTag_Click);
            // 
            // btnReadTag
            // 
            this.btnReadTag.Location = new System.Drawing.Point(888, 24);
            this.btnReadTag.Name = "btnReadTag";
            this.btnReadTag.Size = new System.Drawing.Size(90, 25);
            this.btnReadTag.TabIndex = 6;
            this.btnReadTag.Text = "Read";
            this.btnReadTag.UseVisualStyleBackColor = true;
            this.btnReadTag.Click += new System.EventHandler(this.btnReadTag_Click);
            // 
            // txtWordAdd
            // 
            this.txtWordAdd.Location = new System.Drawing.Point(655, 25);
            this.txtWordAdd.Name = "txtWordAdd";
            this.txtWordAdd.Size = new System.Drawing.Size(48, 21);
            this.txtWordAdd.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(548, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 12);
            this.label26.TabIndex = 4;
            this.label26.Text = "Start Add(WORD):";
            // 
            // htxtReadAndWritePwd
            // 
            this.htxtReadAndWritePwd.Location = new System.Drawing.Point(410, 25);
            this.htxtReadAndWritePwd.Name = "htxtReadAndWritePwd";
            this.htxtReadAndWritePwd.Size = new System.Drawing.Size(120, 21);
            this.htxtReadAndWritePwd.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(273, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(131, 12);
            this.label25.TabIndex = 2;
            this.label25.Text = "Access Password(HEX):";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.rdbUser);
            this.groupBox17.Controls.Add(this.rdbTid);
            this.groupBox17.Controls.Add(this.rdbEpc);
            this.groupBox17.Controls.Add(this.rdbReserved);
            this.groupBox17.Location = new System.Drawing.Point(18, 13);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(242, 43);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            // 
            // rdbUser
            // 
            this.rdbUser.AutoSize = true;
            this.rdbUser.Location = new System.Drawing.Point(189, 14);
            this.rdbUser.Name = "rdbUser";
            this.rdbUser.Size = new System.Drawing.Size(47, 16);
            this.rdbUser.TabIndex = 3;
            this.rdbUser.TabStop = true;
            this.rdbUser.Text = "USER";
            this.rdbUser.UseVisualStyleBackColor = true;
            // 
            // rdbTid
            // 
            this.rdbTid.AutoSize = true;
            this.rdbTid.Location = new System.Drawing.Point(130, 14);
            this.rdbTid.Name = "rdbTid";
            this.rdbTid.Size = new System.Drawing.Size(41, 16);
            this.rdbTid.TabIndex = 2;
            this.rdbTid.TabStop = true;
            this.rdbTid.Text = "TID";
            this.rdbTid.UseVisualStyleBackColor = true;
            // 
            // rdbEpc
            // 
            this.rdbEpc.AutoSize = true;
            this.rdbEpc.Location = new System.Drawing.Point(83, 14);
            this.rdbEpc.Name = "rdbEpc";
            this.rdbEpc.Size = new System.Drawing.Size(41, 16);
            this.rdbEpc.TabIndex = 1;
            this.rdbEpc.TabStop = true;
            this.rdbEpc.Text = "EPC";
            this.rdbEpc.UseVisualStyleBackColor = true;
            // 
            // rdbReserved
            // 
            this.rdbReserved.AutoSize = true;
            this.rdbReserved.Location = new System.Drawing.Point(6, 14);
            this.rdbReserved.Name = "rdbReserved";
            this.rdbReserved.Size = new System.Drawing.Size(71, 16);
            this.rdbReserved.TabIndex = 0;
            this.rdbReserved.TabStop = true;
            this.rdbReserved.Text = "Password";
            this.rdbReserved.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 78);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(149, 12);
            this.label24.TabIndex = 0;
            this.label24.Text = "Data to be written(HEX):";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label23);
            this.groupBox13.Controls.Add(this.btnSetAccessEpcMatch);
            this.groupBox13.Controls.Add(this.cmbSetAccessEpcMatch);
            this.groupBox13.Controls.Add(this.txtAccessEpcMatch);
            this.groupBox13.Controls.Add(this.ckAccessEpcMatch);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox13.Location = new System.Drawing.Point(3, 17);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(994, 54);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Tag Selection";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(468, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 12);
            this.label23.TabIndex = 4;
            this.label23.Text = "Tag List:";
            // 
            // btnSetAccessEpcMatch
            // 
            this.btnSetAccessEpcMatch.Location = new System.Drawing.Point(888, 18);
            this.btnSetAccessEpcMatch.Name = "btnSetAccessEpcMatch";
            this.btnSetAccessEpcMatch.Size = new System.Drawing.Size(90, 25);
            this.btnSetAccessEpcMatch.TabIndex = 3;
            this.btnSetAccessEpcMatch.Text = "Select";
            this.btnSetAccessEpcMatch.UseVisualStyleBackColor = true;
            this.btnSetAccessEpcMatch.Click += new System.EventHandler(this.btnSetAccessEpcMatch_Click);
            // 
            // cmbSetAccessEpcMatch
            // 
            this.cmbSetAccessEpcMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetAccessEpcMatch.FormattingEnabled = true;
            this.cmbSetAccessEpcMatch.Location = new System.Drawing.Point(533, 20);
            this.cmbSetAccessEpcMatch.Name = "cmbSetAccessEpcMatch";
            this.cmbSetAccessEpcMatch.Size = new System.Drawing.Size(323, 20);
            this.cmbSetAccessEpcMatch.TabIndex = 2;
            this.cmbSetAccessEpcMatch.DropDown += new System.EventHandler(this.cmbSetAccessEpcMatch_DropDown);
            // 
            // txtAccessEpcMatch
            // 
            this.txtAccessEpcMatch.Location = new System.Drawing.Point(123, 18);
            this.txtAccessEpcMatch.Name = "txtAccessEpcMatch";
            this.txtAccessEpcMatch.ReadOnly = true;
            this.txtAccessEpcMatch.Size = new System.Drawing.Size(320, 21);
            this.txtAccessEpcMatch.TabIndex = 1;
            // 
            // ckAccessEpcMatch
            // 
            this.ckAccessEpcMatch.AutoSize = true;
            this.ckAccessEpcMatch.Location = new System.Drawing.Point(16, 22);
            this.ckAccessEpcMatch.Name = "ckAccessEpcMatch";
            this.ckAccessEpcMatch.Size = new System.Drawing.Size(102, 16);
            this.ckAccessEpcMatch.TabIndex = 0;
            this.ckAccessEpcMatch.Text = "Selected Tag:";
            this.ckAccessEpcMatch.UseVisualStyleBackColor = true;
            this.ckAccessEpcMatch.CheckedChanged += new System.EventHandler(this.cbAccessEpcMatch_CheckedChanged);
            // 
            // PagISO18000
            // 
            this.PagISO18000.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PagISO18000.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PagISO18000.Controls.Add(this.btnClear);
            this.PagISO18000.Controls.Add(this.btnInventoryISO18000);
            this.PagISO18000.Controls.Add(this.ltvTagISO18000);
            this.PagISO18000.Controls.Add(this.gbISO1800LockQuery);
            this.PagISO18000.Controls.Add(this.gbISO1800ReadWrite);
            this.PagISO18000.Controls.Add(this.label41);
            this.PagISO18000.Controls.Add(this.htxtReadUID);
            this.PagISO18000.Location = new System.Drawing.Point(4, 22);
            this.PagISO18000.Name = "PagISO18000";
            this.PagISO18000.Size = new System.Drawing.Size(1010, 603);
            this.PagISO18000.TabIndex = 4;
            this.PagISO18000.Text = "ISO 18000-6B Tag Test";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(887, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Refresh";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInventoryISO18000
            // 
            this.btnInventoryISO18000.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInventoryISO18000.ForeColor = System.Drawing.Color.Indigo;
            this.btnInventoryISO18000.Location = new System.Drawing.Point(8, 11);
            this.btnInventoryISO18000.Name = "btnInventoryISO18000";
            this.btnInventoryISO18000.Size = new System.Drawing.Size(120, 38);
            this.btnInventoryISO18000.TabIndex = 3;
            this.btnInventoryISO18000.Text = "Inventory";
            this.btnInventoryISO18000.UseVisualStyleBackColor = true;
            this.btnInventoryISO18000.Click += new System.EventHandler(this.btnInventoryISO18000_Click);
            // 
            // ltvTagISO18000
            // 
            this.ltvTagISO18000.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader27,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader28});
            this.ltvTagISO18000.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ltvTagISO18000.FullRowSelect = true;
            this.ltvTagISO18000.GridLines = true;
            this.ltvTagISO18000.Location = new System.Drawing.Point(3, 55);
            this.ltvTagISO18000.Name = "ltvTagISO18000";
            this.ltvTagISO18000.Size = new System.Drawing.Size(458, 544);
            this.ltvTagISO18000.TabIndex = 9;
            this.ltvTagISO18000.UseCompatibleStateImageBehavior = false;
            this.ltvTagISO18000.View = System.Windows.Forms.View.Details;
            this.ltvTagISO18000.Click += new System.EventHandler(this.ltvTagISO18000_Click);
            this.ltvTagISO18000.DoubleClick += new System.EventHandler(this.ltvTagISO18000_DoubleClick);
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "ID";
            this.columnHeader27.Width = 38;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "UID";
            this.columnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader25.Width = 201;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Ant ID";
            this.columnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader26.Width = 58;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Identification Count";
            this.columnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader28.Width = 153;
            // 
            // gbISO1800LockQuery
            // 
            this.gbISO1800LockQuery.Controls.Add(this.txtStatus);
            this.gbISO1800LockQuery.Controls.Add(this.htxtQueryAdd);
            this.gbISO1800LockQuery.Controls.Add(this.label46);
            this.gbISO1800LockQuery.Controls.Add(this.htxtLockAdd);
            this.gbISO1800LockQuery.Controls.Add(this.label47);
            this.gbISO1800LockQuery.Controls.Add(this.btnQueryTagISO18000);
            this.gbISO1800LockQuery.Controls.Add(this.btnLockTagISO18000);
            this.gbISO1800LockQuery.Location = new System.Drawing.Point(487, 506);
            this.gbISO1800LockQuery.Name = "gbISO1800LockQuery";
            this.gbISO1800LockQuery.Size = new System.Drawing.Size(515, 93);
            this.gbISO1800LockQuery.TabIndex = 7;
            this.gbISO1800LockQuery.TabStop = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(263, 63);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(128, 20);
            this.txtStatus.TabIndex = 9;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // htxtQueryAdd
            // 
            this.htxtQueryAdd.Location = new System.Drawing.Point(210, 63);
            this.htxtQueryAdd.MaxLength = 2;
            this.htxtQueryAdd.Name = "htxtQueryAdd";
            this.htxtQueryAdd.Size = new System.Drawing.Size(39, 20);
            this.htxtQueryAdd.TabIndex = 8;
            this.htxtQueryAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(13, 67);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(167, 13);
            this.label46.TabIndex = 5;
            this.label46.Text = "Query Lock Status Address(HEX):";
            // 
            // htxtLockAdd
            // 
            this.htxtLockAdd.Location = new System.Drawing.Point(210, 27);
            this.htxtLockAdd.MaxLength = 2;
            this.htxtLockAdd.Name = "htxtLockAdd";
            this.htxtLockAdd.Size = new System.Drawing.Size(39, 20);
            this.htxtLockAdd.TabIndex = 8;
            this.htxtLockAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(31, 31);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(157, 13);
            this.label47.TabIndex = 5;
            this.label47.Text = "Permanent Lock Address(HEX):";
            // 
            // btnQueryTagISO18000
            // 
            this.btnQueryTagISO18000.Location = new System.Drawing.Point(400, 59);
            this.btnQueryTagISO18000.Name = "btnQueryTagISO18000";
            this.btnQueryTagISO18000.Size = new System.Drawing.Size(100, 30);
            this.btnQueryTagISO18000.TabIndex = 3;
            this.btnQueryTagISO18000.Text = "Query";
            this.btnQueryTagISO18000.UseVisualStyleBackColor = true;
            this.btnQueryTagISO18000.Click += new System.EventHandler(this.btnQueryTagISO18000_Click);
            // 
            // btnLockTagISO18000
            // 
            this.btnLockTagISO18000.Location = new System.Drawing.Point(400, 23);
            this.btnLockTagISO18000.Name = "btnLockTagISO18000";
            this.btnLockTagISO18000.Size = new System.Drawing.Size(100, 30);
            this.btnLockTagISO18000.TabIndex = 3;
            this.btnLockTagISO18000.Text = "Lock";
            this.btnLockTagISO18000.UseVisualStyleBackColor = true;
            this.btnLockTagISO18000.Click += new System.EventHandler(this.btnLockTagISO18000_Click);
            // 
            // gbISO1800ReadWrite
            // 
            this.gbISO1800ReadWrite.Controls.Add(this.txtLoopTimes);
            this.gbISO1800ReadWrite.Controls.Add(this.label44);
            this.gbISO1800ReadWrite.Controls.Add(this.txtLoop);
            this.gbISO1800ReadWrite.Controls.Add(this.label40);
            this.gbISO1800ReadWrite.Controls.Add(this.htxtWriteData18000);
            this.gbISO1800ReadWrite.Controls.Add(this.txtWriteLength);
            this.gbISO1800ReadWrite.Controls.Add(this.htxtReadData18000);
            this.gbISO1800ReadWrite.Controls.Add(this.label45);
            this.gbISO1800ReadWrite.Controls.Add(this.btnWriteTagISO18000);
            this.gbISO1800ReadWrite.Controls.Add(this.label51);
            this.gbISO1800ReadWrite.Controls.Add(this.label52);
            this.gbISO1800ReadWrite.Controls.Add(this.txtReadLength);
            this.gbISO1800ReadWrite.Controls.Add(this.htxtWriteStartAdd);
            this.gbISO1800ReadWrite.Controls.Add(this.label50);
            this.gbISO1800ReadWrite.Controls.Add(this.htxtReadStartAdd);
            this.gbISO1800ReadWrite.Controls.Add(this.label42);
            this.gbISO1800ReadWrite.Controls.Add(this.label43);
            this.gbISO1800ReadWrite.Controls.Add(this.btnReadTagISO18000);
            this.gbISO1800ReadWrite.Location = new System.Drawing.Point(487, 61);
            this.gbISO1800ReadWrite.Name = "gbISO1800ReadWrite";
            this.gbISO1800ReadWrite.Size = new System.Drawing.Size(515, 445);
            this.gbISO1800ReadWrite.TabIndex = 4;
            this.gbISO1800ReadWrite.TabStop = false;
            this.gbISO1800ReadWrite.Text = "Read/Write Tag with Unlimited Length";
            // 
            // txtLoopTimes
            // 
            this.txtLoopTimes.Location = new System.Drawing.Point(274, 237);
            this.txtLoopTimes.Name = "txtLoopTimes";
            this.txtLoopTimes.ReadOnly = true;
            this.txtLoopTimes.Size = new System.Drawing.Size(41, 20);
            this.txtLoopTimes.TabIndex = 15;
            this.txtLoopTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(203, 242);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(65, 13);
            this.label44.TabIndex = 14;
            this.label44.Text = "Succeeded:";
            // 
            // txtLoop
            // 
            this.txtLoop.Location = new System.Drawing.Point(117, 237);
            this.txtLoop.Name = "txtLoop";
            this.txtLoop.Size = new System.Drawing.Size(39, 20);
            this.txtLoop.TabIndex = 13;
            this.txtLoop.Text = "1";
            this.txtLoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(16, 242);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(98, 13);
            this.label40.TabIndex = 12;
            this.label40.Text = "Command Repead:";
            // 
            // htxtWriteData18000
            // 
            this.htxtWriteData18000.Location = new System.Drawing.Point(117, 268);
            this.htxtWriteData18000.Multiline = true;
            this.htxtWriteData18000.Name = "htxtWriteData18000";
            this.htxtWriteData18000.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.htxtWriteData18000.Size = new System.Drawing.Size(383, 171);
            this.htxtWriteData18000.TabIndex = 9;
            // 
            // txtWriteLength
            // 
            this.txtWriteLength.Location = new System.Drawing.Point(274, 208);
            this.txtWriteLength.MaxLength = 2;
            this.txtWriteLength.Name = "txtWriteLength";
            this.txtWriteLength.ReadOnly = true;
            this.txtWriteLength.Size = new System.Drawing.Size(41, 20);
            this.txtWriteLength.TabIndex = 11;
            this.txtWriteLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // htxtReadData18000
            // 
            this.htxtReadData18000.Location = new System.Drawing.Point(117, 53);
            this.htxtReadData18000.Multiline = true;
            this.htxtReadData18000.Name = "htxtReadData18000";
            this.htxtReadData18000.ReadOnly = true;
            this.htxtReadData18000.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.htxtReadData18000.Size = new System.Drawing.Size(383, 144);
            this.htxtReadData18000.TabIndex = 11;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(46, 271);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(61, 13);
            this.label45.TabIndex = 6;
            this.label45.Text = "Data(HEX):";
            // 
            // btnWriteTagISO18000
            // 
            this.btnWriteTagISO18000.Location = new System.Drawing.Point(400, 233);
            this.btnWriteTagISO18000.Name = "btnWriteTagISO18000";
            this.btnWriteTagISO18000.Size = new System.Drawing.Size(100, 30);
            this.btnWriteTagISO18000.TabIndex = 3;
            this.btnWriteTagISO18000.Text = "Write";
            this.btnWriteTagISO18000.UseVisualStyleBackColor = true;
            this.btnWriteTagISO18000.Click += new System.EventHandler(this.btnWriteTagISO18000_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(191, 212);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(71, 13);
            this.label51.TabIndex = 10;
            this.label51.Text = "Length(HEX):";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(46, 56);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(61, 13);
            this.label52.TabIndex = 10;
            this.label52.Text = "Data(HEX):";
            // 
            // txtReadLength
            // 
            this.txtReadLength.Location = new System.Drawing.Point(274, 21);
            this.txtReadLength.MaxLength = 2;
            this.txtReadLength.Name = "txtReadLength";
            this.txtReadLength.Size = new System.Drawing.Size(41, 20);
            this.txtReadLength.TabIndex = 9;
            this.txtReadLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // htxtWriteStartAdd
            // 
            this.htxtWriteStartAdd.Location = new System.Drawing.Point(117, 208);
            this.htxtWriteStartAdd.MaxLength = 2;
            this.htxtWriteStartAdd.Name = "htxtWriteStartAdd";
            this.htxtWriteStartAdd.Size = new System.Drawing.Size(39, 20);
            this.htxtWriteStartAdd.TabIndex = 8;
            this.htxtWriteStartAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(191, 25);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(71, 13);
            this.label50.TabIndex = 8;
            this.label50.Text = "Length(HEX):";
            // 
            // htxtReadStartAdd
            // 
            this.htxtReadStartAdd.Location = new System.Drawing.Point(117, 21);
            this.htxtReadStartAdd.MaxLength = 2;
            this.htxtReadStartAdd.Name = "htxtReadStartAdd";
            this.htxtReadStartAdd.Size = new System.Drawing.Size(39, 20);
            this.htxtReadStartAdd.TabIndex = 7;
            this.htxtReadStartAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(16, 25);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(82, 13);
            this.label42.TabIndex = 5;
            this.label42.Text = "Start Add(HEX):";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(16, 212);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(82, 13);
            this.label43.TabIndex = 5;
            this.label43.Text = "Start Add(HEX):";
            // 
            // btnReadTagISO18000
            // 
            this.btnReadTagISO18000.Location = new System.Drawing.Point(400, 16);
            this.btnReadTagISO18000.Name = "btnReadTagISO18000";
            this.btnReadTagISO18000.Size = new System.Drawing.Size(100, 30);
            this.btnReadTagISO18000.TabIndex = 3;
            this.btnReadTagISO18000.Text = "Read";
            this.btnReadTagISO18000.UseVisualStyleBackColor = true;
            this.btnReadTagISO18000.Click += new System.EventHandler(this.btnReadTagISO18000_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(503, 33);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(74, 13);
            this.label41.TabIndex = 4;
            this.label41.Text = "Selected UID:";
            // 
            // htxtReadUID
            // 
            this.htxtReadUID.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.htxtReadUID.Location = new System.Drawing.Point(604, 29);
            this.htxtReadUID.Name = "htxtReadUID";
            this.htxtReadUID.ReadOnly = true;
            this.htxtReadUID.Size = new System.Drawing.Size(195, 21);
            this.htxtReadUID.TabIndex = 6;
            this.htxtReadUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PagTranDataLog
            // 
            this.PagTranDataLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PagTranDataLog.Controls.Add(this.gbCmdManual);
            this.PagTranDataLog.Controls.Add(this.lrtxtDataTran);
            this.PagTranDataLog.Location = new System.Drawing.Point(4, 22);
            this.PagTranDataLog.Name = "PagTranDataLog";
            this.PagTranDataLog.Size = new System.Drawing.Size(1010, 603);
            this.PagTranDataLog.TabIndex = 2;
            this.PagTranDataLog.Text = "Serial Port Monitor";
            this.PagTranDataLog.UseVisualStyleBackColor = true;
            // 
            // gbCmdManual
            // 
            this.gbCmdManual.Controls.Add(this.label16);
            this.gbCmdManual.Controls.Add(this.htxtSendData);
            this.gbCmdManual.Controls.Add(this.btnClearData);
            this.gbCmdManual.Controls.Add(this.label17);
            this.gbCmdManual.Controls.Add(this.btnSendData);
            this.gbCmdManual.Controls.Add(this.htxtCheckData);
            this.gbCmdManual.Location = new System.Drawing.Point(2, 516);
            this.gbCmdManual.Name = "gbCmdManual";
            this.gbCmdManual.Size = new System.Drawing.Size(1002, 55);
            this.gbCmdManual.TabIndex = 8;
            this.gbCmdManual.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Input Command:";
            // 
            // htxtSendData
            // 
            this.htxtSendData.Location = new System.Drawing.Point(95, 17);
            this.htxtSendData.Name = "htxtSendData";
            this.htxtSendData.Size = new System.Drawing.Size(515, 20);
            this.htxtSendData.TabIndex = 2;
            this.htxtSendData.Leave += new System.EventHandler(this.htxtSendData_Leave);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(906, 15);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(90, 25);
            this.btnClearData.TabIndex = 6;
            this.btnClearData.Text = "Clear";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(629, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Check Sum:";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(810, 15);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(90, 25);
            this.btnSendData.TabIndex = 5;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // htxtCheckData
            // 
            this.htxtCheckData.Location = new System.Drawing.Point(700, 17);
            this.htxtCheckData.Name = "htxtCheckData";
            this.htxtCheckData.ReadOnly = true;
            this.htxtCheckData.Size = new System.Drawing.Size(47, 20);
            this.htxtCheckData.TabIndex = 4;
            // 
            // lrtxtDataTran
            // 
            this.lrtxtDataTran.Dock = System.Windows.Forms.DockStyle.Top;
            this.lrtxtDataTran.Location = new System.Drawing.Point(0, 0);
            this.lrtxtDataTran.Name = "lrtxtDataTran";
            this.lrtxtDataTran.Size = new System.Drawing.Size(1010, 510);
            this.lrtxtDataTran.TabIndex = 0;
            this.lrtxtDataTran.Text = "";
            this.lrtxtDataTran.DoubleClick += new System.EventHandler(this.lrtxtDataTran_DoubleClick);
            // 
            // pagKimlikDemo
            // 
            this.pagKimlikDemo.Controls.Add(this.kimlikTabControl);
            this.pagKimlikDemo.Controls.Add(this.panel11);
            this.pagKimlikDemo.Location = new System.Drawing.Point(4, 22);
            this.pagKimlikDemo.Name = "pagKimlikDemo";
            this.pagKimlikDemo.Padding = new System.Windows.Forms.Padding(3);
            this.pagKimlikDemo.Size = new System.Drawing.Size(1010, 603);
            this.pagKimlikDemo.TabIndex = 6;
            this.pagKimlikDemo.Text = "RFID KIMLIK Demo";
            this.pagKimlikDemo.UseVisualStyleBackColor = true;
            // 
            // kimlikTabControl
            // 
            this.kimlikTabControl.Controls.Add(this.kimlikImageTabPage);
            this.kimlikTabControl.Controls.Add(this.kimlikListTabPage);
            this.kimlikTabControl.Location = new System.Drawing.Point(3, 56);
            this.kimlikTabControl.Name = "kimlikTabControl";
            this.kimlikTabControl.SelectedIndex = 0;
            this.kimlikTabControl.Size = new System.Drawing.Size(1006, 544);
            this.kimlikTabControl.TabIndex = 3;
            // 
            // kimlikImageTabPage
            // 
            this.kimlikImageTabPage.Controls.Add(this.panel12);
            this.kimlikImageTabPage.Location = new System.Drawing.Point(4, 22);
            this.kimlikImageTabPage.Name = "kimlikImageTabPage";
            this.kimlikImageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.kimlikImageTabPage.Size = new System.Drawing.Size(998, 518);
            this.kimlikImageTabPage.TabIndex = 0;
            this.kimlikImageTabPage.Text = "Image";
            this.kimlikImageTabPage.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel12.Controls.Add(this.backKimlikPanel);
            this.panel12.Controls.Add(this.kimlikFrontPanel);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(992, 512);
            this.panel12.TabIndex = 1;
            // 
            // backKimlikPanel
            // 
            this.backKimlikPanel.Controls.Add(this.medeniLabel);
            this.backKimlikPanel.Controls.Add(this.nufusSerfiLabel);
            this.backKimlikPanel.Controls.Add(this.diniLabel);
            this.backKimlikPanel.Controls.Add(this.vhkiLabel);
            this.backKimlikPanel.Controls.Add(this.kanLabel);
            this.backKimlikPanel.Controls.Add(this.verilisTarihiLabel);
            this.backKimlikPanel.Controls.Add(this.ilLabel);
            this.backKimlikPanel.Controls.Add(this.verilisNedeniLabel);
            this.backKimlikPanel.Controls.Add(this.ilceLabel);
            this.backKimlikPanel.Controls.Add(this.kayitNoLabel);
            this.backKimlikPanel.Controls.Add(this.mahLabel);
            this.backKimlikPanel.Controls.Add(this.verildigiLabel);
            this.backKimlikPanel.Controls.Add(this.ciltLabel);
            this.backKimlikPanel.Controls.Add(this.siraNoLabel);
            this.backKimlikPanel.Controls.Add(this.aileSiraNoLabel);
            this.backKimlikPanel.Controls.Add(this.backKimlikPicBox);
            this.backKimlikPanel.Location = new System.Drawing.Point(550, 10);
            this.backKimlikPanel.Name = "backKimlikPanel";
            this.backKimlikPanel.Size = new System.Drawing.Size(400, 480);
            this.backKimlikPanel.TabIndex = 30;
            // 
            // medeniLabel
            // 
            this.medeniLabel.AutoSize = true;
            this.medeniLabel.BackColor = System.Drawing.Color.Transparent;
            this.medeniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medeniLabel.Location = new System.Drawing.Point(71, 35);
            this.medeniLabel.Name = "medeniLabel";
            this.medeniLabel.Size = new System.Drawing.Size(13, 17);
            this.medeniLabel.TabIndex = 14;
            this.medeniLabel.Text = "-";
            // 
            // nufusSerfiLabel
            // 
            this.nufusSerfiLabel.AutoSize = true;
            this.nufusSerfiLabel.BackColor = System.Drawing.Color.Transparent;
            this.nufusSerfiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nufusSerfiLabel.Location = new System.Drawing.Point(189, 338);
            this.nufusSerfiLabel.Name = "nufusSerfiLabel";
            this.nufusSerfiLabel.Size = new System.Drawing.Size(13, 17);
            this.nufusSerfiLabel.TabIndex = 28;
            this.nufusSerfiLabel.Text = "-";
            // 
            // diniLabel
            // 
            this.diniLabel.AutoSize = true;
            this.diniLabel.BackColor = System.Drawing.Color.Transparent;
            this.diniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diniLabel.Location = new System.Drawing.Point(177, 35);
            this.diniLabel.Name = "diniLabel";
            this.diniLabel.Size = new System.Drawing.Size(13, 17);
            this.diniLabel.TabIndex = 15;
            this.diniLabel.Text = "-";
            // 
            // vhkiLabel
            // 
            this.vhkiLabel.AutoSize = true;
            this.vhkiLabel.BackColor = System.Drawing.Color.Transparent;
            this.vhkiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vhkiLabel.Location = new System.Drawing.Point(73, 285);
            this.vhkiLabel.Name = "vhkiLabel";
            this.vhkiLabel.Size = new System.Drawing.Size(13, 17);
            this.vhkiLabel.TabIndex = 27;
            this.vhkiLabel.Text = "-";
            // 
            // kanLabel
            // 
            this.kanLabel.AutoSize = true;
            this.kanLabel.BackColor = System.Drawing.Color.Transparent;
            this.kanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kanLabel.Location = new System.Drawing.Point(287, 35);
            this.kanLabel.Name = "kanLabel";
            this.kanLabel.Size = new System.Drawing.Size(13, 17);
            this.kanLabel.TabIndex = 16;
            this.kanLabel.Text = "-";
            // 
            // verilisTarihiLabel
            // 
            this.verilisTarihiLabel.AutoSize = true;
            this.verilisTarihiLabel.BackColor = System.Drawing.Color.Transparent;
            this.verilisTarihiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verilisTarihiLabel.Location = new System.Drawing.Point(235, 231);
            this.verilisTarihiLabel.Name = "verilisTarihiLabel";
            this.verilisTarihiLabel.Size = new System.Drawing.Size(13, 17);
            this.verilisTarihiLabel.TabIndex = 26;
            this.verilisTarihiLabel.Text = "-";
            // 
            // ilLabel
            // 
            this.ilLabel.AutoSize = true;
            this.ilLabel.BackColor = System.Drawing.Color.Transparent;
            this.ilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilLabel.Location = new System.Drawing.Point(86, 75);
            this.ilLabel.Name = "ilLabel";
            this.ilLabel.Size = new System.Drawing.Size(13, 17);
            this.ilLabel.TabIndex = 17;
            this.ilLabel.Text = "-";
            // 
            // verilisNedeniLabel
            // 
            this.verilisNedeniLabel.AutoSize = true;
            this.verilisNedeniLabel.BackColor = System.Drawing.Color.Transparent;
            this.verilisNedeniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verilisNedeniLabel.Location = new System.Drawing.Point(235, 192);
            this.verilisNedeniLabel.Name = "verilisNedeniLabel";
            this.verilisNedeniLabel.Size = new System.Drawing.Size(13, 17);
            this.verilisNedeniLabel.TabIndex = 25;
            this.verilisNedeniLabel.Text = "-";
            // 
            // ilceLabel
            // 
            this.ilceLabel.AutoSize = true;
            this.ilceLabel.BackColor = System.Drawing.Color.Transparent;
            this.ilceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilceLabel.Location = new System.Drawing.Point(235, 75);
            this.ilceLabel.Name = "ilceLabel";
            this.ilceLabel.Size = new System.Drawing.Size(13, 17);
            this.ilceLabel.TabIndex = 18;
            this.ilceLabel.Text = "-";
            // 
            // kayitNoLabel
            // 
            this.kayitNoLabel.AutoSize = true;
            this.kayitNoLabel.BackColor = System.Drawing.Color.Transparent;
            this.kayitNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitNoLabel.Location = new System.Drawing.Point(85, 231);
            this.kayitNoLabel.Name = "kayitNoLabel";
            this.kayitNoLabel.Size = new System.Drawing.Size(13, 17);
            this.kayitNoLabel.TabIndex = 24;
            this.kayitNoLabel.Text = "-";
            // 
            // mahLabel
            // 
            this.mahLabel.AutoSize = true;
            this.mahLabel.BackColor = System.Drawing.Color.Transparent;
            this.mahLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mahLabel.Location = new System.Drawing.Point(111, 115);
            this.mahLabel.Name = "mahLabel";
            this.mahLabel.Size = new System.Drawing.Size(13, 17);
            this.mahLabel.TabIndex = 19;
            this.mahLabel.Text = "-";
            // 
            // verildigiLabel
            // 
            this.verildigiLabel.AutoSize = true;
            this.verildigiLabel.BackColor = System.Drawing.Color.Transparent;
            this.verildigiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verildigiLabel.Location = new System.Drawing.Point(86, 192);
            this.verildigiLabel.Name = "verildigiLabel";
            this.verildigiLabel.Size = new System.Drawing.Size(13, 17);
            this.verildigiLabel.TabIndex = 23;
            this.verildigiLabel.Text = "-";
            // 
            // ciltLabel
            // 
            this.ciltLabel.AutoSize = true;
            this.ciltLabel.BackColor = System.Drawing.Color.Transparent;
            this.ciltLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciltLabel.Location = new System.Drawing.Point(79, 154);
            this.ciltLabel.Name = "ciltLabel";
            this.ciltLabel.Size = new System.Drawing.Size(13, 17);
            this.ciltLabel.TabIndex = 20;
            this.ciltLabel.Text = "-";
            // 
            // siraNoLabel
            // 
            this.siraNoLabel.AutoSize = true;
            this.siraNoLabel.BackColor = System.Drawing.Color.Transparent;
            this.siraNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siraNoLabel.Location = new System.Drawing.Point(287, 154);
            this.siraNoLabel.Name = "siraNoLabel";
            this.siraNoLabel.Size = new System.Drawing.Size(13, 17);
            this.siraNoLabel.TabIndex = 22;
            this.siraNoLabel.Text = "-";
            // 
            // aileSiraNoLabel
            // 
            this.aileSiraNoLabel.AutoSize = true;
            this.aileSiraNoLabel.BackColor = System.Drawing.Color.Transparent;
            this.aileSiraNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aileSiraNoLabel.Location = new System.Drawing.Point(177, 154);
            this.aileSiraNoLabel.Name = "aileSiraNoLabel";
            this.aileSiraNoLabel.Size = new System.Drawing.Size(13, 17);
            this.aileSiraNoLabel.TabIndex = 21;
            this.aileSiraNoLabel.Text = "-";
            // 
            // backKimlikPicBox
            // 
            this.backKimlikPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backKimlikPicBox.Image = global::UHFDemo.Properties.Resources.kimlik_back_Female;
            this.backKimlikPicBox.Location = new System.Drawing.Point(0, 0);
            this.backKimlikPicBox.Name = "backKimlikPicBox";
            this.backKimlikPicBox.Size = new System.Drawing.Size(400, 480);
            this.backKimlikPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backKimlikPicBox.TabIndex = 1;
            this.backKimlikPicBox.TabStop = false;
            // 
            // kimlikFrontPanel
            // 
            this.kimlikFrontPanel.Controls.Add(this.wantedPicBox);
            this.kimlikFrontPanel.Controls.Add(this.seriLabel);
            this.kimlikFrontPanel.Controls.Add(this.adiLabel);
            this.kimlikFrontPanel.Controls.Add(this.tcKimLabel);
            this.kimlikFrontPanel.Controls.Add(this.soyadiLabel);
            this.kimlikFrontPanel.Controls.Add(this.doguTarihLabel);
            this.kimlikFrontPanel.Controls.Add(this.anaAdiLabel);
            this.kimlikFrontPanel.Controls.Add(this.numberLabel);
            this.kimlikFrontPanel.Controls.Add(this.babaAdiLabel);
            this.kimlikFrontPanel.Controls.Add(this.doguYeriLabel);
            this.kimlikFrontPanel.Controls.Add(this.imagePicBox);
            this.kimlikFrontPanel.Controls.Add(this.kimlikPicBox);
            this.kimlikFrontPanel.Location = new System.Drawing.Point(50, 10);
            this.kimlikFrontPanel.Name = "kimlikFrontPanel";
            this.kimlikFrontPanel.Size = new System.Drawing.Size(400, 480);
            this.kimlikFrontPanel.TabIndex = 29;
            // 
            // wantedPicBox
            // 
            this.wantedPicBox.BackColor = System.Drawing.Color.Transparent;
            this.wantedPicBox.BackgroundImage = global::UHFDemo.Properties.Resources.wanted;
            this.wantedPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wantedPicBox.Location = new System.Drawing.Point(209, 261);
            this.wantedPicBox.Name = "wantedPicBox";
            this.wantedPicBox.Size = new System.Drawing.Size(149, 140);
            this.wantedPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wantedPicBox.TabIndex = 31;
            this.wantedPicBox.TabStop = false;
            // 
            // seriLabel
            // 
            this.seriLabel.AutoSize = true;
            this.seriLabel.BackColor = System.Drawing.Color.Transparent;
            this.seriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriLabel.Location = new System.Drawing.Point(115, 221);
            this.seriLabel.Name = "seriLabel";
            this.seriLabel.Size = new System.Drawing.Size(13, 17);
            this.seriLabel.TabIndex = 9;
            this.seriLabel.Text = "-";
            // 
            // adiLabel
            // 
            this.adiLabel.AutoSize = true;
            this.adiLabel.BackColor = System.Drawing.Color.Transparent;
            this.adiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adiLabel.Location = new System.Drawing.Point(115, 327);
            this.adiLabel.Name = "adiLabel";
            this.adiLabel.Size = new System.Drawing.Size(13, 17);
            this.adiLabel.TabIndex = 3;
            this.adiLabel.Text = "-";
            // 
            // tcKimLabel
            // 
            this.tcKimLabel.AutoSize = true;
            this.tcKimLabel.BackColor = System.Drawing.Color.Transparent;
            this.tcKimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcKimLabel.Location = new System.Drawing.Point(115, 261);
            this.tcKimLabel.Name = "tcKimLabel";
            this.tcKimLabel.Size = new System.Drawing.Size(13, 17);
            this.tcKimLabel.TabIndex = 4;
            this.tcKimLabel.Text = "-";
            // 
            // soyadiLabel
            // 
            this.soyadiLabel.AutoSize = true;
            this.soyadiLabel.BackColor = System.Drawing.Color.Transparent;
            this.soyadiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyadiLabel.Location = new System.Drawing.Point(115, 292);
            this.soyadiLabel.Name = "soyadiLabel";
            this.soyadiLabel.Size = new System.Drawing.Size(13, 17);
            this.soyadiLabel.TabIndex = 5;
            this.soyadiLabel.Text = "-";
            // 
            // doguTarihLabel
            // 
            this.doguTarihLabel.AutoSize = true;
            this.doguTarihLabel.BackColor = System.Drawing.Color.Transparent;
            this.doguTarihLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doguTarihLabel.Location = new System.Drawing.Point(239, 432);
            this.doguTarihLabel.Name = "doguTarihLabel";
            this.doguTarihLabel.Size = new System.Drawing.Size(13, 17);
            this.doguTarihLabel.TabIndex = 7;
            this.doguTarihLabel.Text = "-";
            // 
            // anaAdiLabel
            // 
            this.anaAdiLabel.AutoSize = true;
            this.anaAdiLabel.BackColor = System.Drawing.Color.Transparent;
            this.anaAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anaAdiLabel.Location = new System.Drawing.Point(115, 396);
            this.anaAdiLabel.Name = "anaAdiLabel";
            this.anaAdiLabel.Size = new System.Drawing.Size(13, 17);
            this.anaAdiLabel.TabIndex = 8;
            this.anaAdiLabel.Text = "-";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(268, 224);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(13, 17);
            this.numberLabel.TabIndex = 10;
            this.numberLabel.Text = "-";
            // 
            // babaAdiLabel
            // 
            this.babaAdiLabel.AutoSize = true;
            this.babaAdiLabel.BackColor = System.Drawing.Color.Transparent;
            this.babaAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaAdiLabel.Location = new System.Drawing.Point(115, 364);
            this.babaAdiLabel.Name = "babaAdiLabel";
            this.babaAdiLabel.Size = new System.Drawing.Size(13, 17);
            this.babaAdiLabel.TabIndex = 11;
            this.babaAdiLabel.Text = "-";
            // 
            // doguYeriLabel
            // 
            this.doguYeriLabel.AutoSize = true;
            this.doguYeriLabel.BackColor = System.Drawing.Color.Transparent;
            this.doguYeriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doguYeriLabel.Location = new System.Drawing.Point(79, 431);
            this.doguYeriLabel.Name = "doguYeriLabel";
            this.doguYeriLabel.Size = new System.Drawing.Size(13, 17);
            this.doguYeriLabel.TabIndex = 12;
            this.doguYeriLabel.Text = "-";
            // 
            // imagePicBox
            // 
            this.imagePicBox.BackColor = System.Drawing.Color.Transparent;
            this.imagePicBox.Image = global::UHFDemo.Properties.Resources.none;
            this.imagePicBox.Location = new System.Drawing.Point(227, 61);
            this.imagePicBox.Name = "imagePicBox";
            this.imagePicBox.Size = new System.Drawing.Size(124, 155);
            this.imagePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePicBox.TabIndex = 13;
            this.imagePicBox.TabStop = false;
            // 
            // kimlikPicBox
            // 
            this.kimlikPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kimlikPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kimlikPicBox.Image = global::UHFDemo.Properties.Resources.kimF;
            this.kimlikPicBox.Location = new System.Drawing.Point(0, 0);
            this.kimlikPicBox.Name = "kimlikPicBox";
            this.kimlikPicBox.Size = new System.Drawing.Size(400, 480);
            this.kimlikPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kimlikPicBox.TabIndex = 0;
            this.kimlikPicBox.TabStop = false;
            // 
            // kimlikListTabPage
            // 
            this.kimlikListTabPage.Controls.Add(this.kimlikListPanel);
            this.kimlikListTabPage.Location = new System.Drawing.Point(4, 22);
            this.kimlikListTabPage.Name = "kimlikListTabPage";
            this.kimlikListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.kimlikListTabPage.Size = new System.Drawing.Size(998, 518);
            this.kimlikListTabPage.TabIndex = 1;
            this.kimlikListTabPage.Text = "List";
            this.kimlikListTabPage.UseVisualStyleBackColor = true;
            // 
            // kimlikListPanel
            // 
            this.kimlikListPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kimlikListPanel.Controls.Add(this.kimlikDetailsButton);
            this.kimlikListPanel.Controls.Add(this.kimlikListDataGridView);
            this.kimlikListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kimlikListPanel.Location = new System.Drawing.Point(3, 3);
            this.kimlikListPanel.Name = "kimlikListPanel";
            this.kimlikListPanel.Size = new System.Drawing.Size(992, 512);
            this.kimlikListPanel.TabIndex = 2;
            // 
            // kimlikDetailsButton
            // 
            this.kimlikDetailsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.kimlikDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kimlikDetailsButton.Font = new System.Drawing.Font("SimSun", 7F, System.Drawing.FontStyle.Bold);
            this.kimlikDetailsButton.ForeColor = System.Drawing.Color.White;
            this.kimlikDetailsButton.Location = new System.Drawing.Point(3, 3);
            this.kimlikDetailsButton.Name = "kimlikDetailsButton";
            this.kimlikDetailsButton.Size = new System.Drawing.Size(143, 41);
            this.kimlikDetailsButton.TabIndex = 1;
            this.kimlikDetailsButton.Text = "Details";
            this.kimlikDetailsButton.UseVisualStyleBackColor = false;
            this.kimlikDetailsButton.Click += new System.EventHandler(this.kimlikDetailsButton_Click);
            // 
            // kimlikListDataGridView
            // 
            this.kimlikListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kimlikListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kimlikListDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kimlikListDataGridView.Location = new System.Drawing.Point(0, 50);
            this.kimlikListDataGridView.Name = "kimlikListDataGridView";
            this.kimlikListDataGridView.ReadOnly = true;
            this.kimlikListDataGridView.Size = new System.Drawing.Size(992, 462);
            this.kimlikListDataGridView.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Controls.Add(this.getAllKimlikFromDbButton);
            this.panel11.Controls.Add(this.clearKimlikButton);
            this.panel11.Controls.Add(this.btnStartKimlik);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1004, 50);
            this.panel11.TabIndex = 0;
            // 
            // getAllKimlikFromDbButton
            // 
            this.getAllKimlikFromDbButton.BackColor = System.Drawing.Color.SteelBlue;
            this.getAllKimlikFromDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getAllKimlikFromDbButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Bold);
            this.getAllKimlikFromDbButton.ForeColor = System.Drawing.Color.White;
            this.getAllKimlikFromDbButton.Location = new System.Drawing.Point(639, 3);
            this.getAllKimlikFromDbButton.Name = "getAllKimlikFromDbButton";
            this.getAllKimlikFromDbButton.Size = new System.Drawing.Size(206, 44);
            this.getAllKimlikFromDbButton.TabIndex = 8;
            this.getAllKimlikFromDbButton.Text = "Get All From Database";
            this.getAllKimlikFromDbButton.UseVisualStyleBackColor = false;
            this.getAllKimlikFromDbButton.Click += new System.EventHandler(this.getAllKimlikFromDbButton_Click);
            // 
            // clearKimlikButton
            // 
            this.clearKimlikButton.BackColor = System.Drawing.Color.IndianRed;
            this.clearKimlikButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearKimlikButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Bold);
            this.clearKimlikButton.ForeColor = System.Drawing.Color.White;
            this.clearKimlikButton.Location = new System.Drawing.Point(851, 3);
            this.clearKimlikButton.Name = "clearKimlikButton";
            this.clearKimlikButton.Size = new System.Drawing.Size(150, 44);
            this.clearKimlikButton.TabIndex = 7;
            this.clearKimlikButton.Text = "Clear";
            this.clearKimlikButton.UseVisualStyleBackColor = false;
            this.clearKimlikButton.Click += new System.EventHandler(this.clearKimlikTableButton_Click);
            // 
            // btnStartKimlik
            // 
            this.btnStartKimlik.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStartKimlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartKimlik.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartKimlik.ForeColor = System.Drawing.Color.White;
            this.btnStartKimlik.Location = new System.Drawing.Point(3, 3);
            this.btnStartKimlik.Name = "btnStartKimlik";
            this.btnStartKimlik.Size = new System.Drawing.Size(150, 44);
            this.btnStartKimlik.TabIndex = 2;
            this.btnStartKimlik.Text = "Start";
            this.btnStartKimlik.UseVisualStyleBackColor = false;
            this.btnStartKimlik.Click += new System.EventHandler(this.btnStartKimlik_Click);
            // 
            // pagInvDemo
            // 
            this.pagInvDemo.Controls.Add(this.panel13);
            this.pagInvDemo.Controls.Add(this.panel14);
            this.pagInvDemo.Location = new System.Drawing.Point(4, 22);
            this.pagInvDemo.Name = "pagInvDemo";
            this.pagInvDemo.Size = new System.Drawing.Size(1010, 603);
            this.pagInvDemo.TabIndex = 7;
            this.pagInvDemo.Text = "RFID Inventory Demo";
            this.pagInvDemo.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.pckgPanel);
            this.panel13.Controls.Add(this.itemPanel);
            this.panel13.Controls.Add(this.boxPanel);
            this.panel13.Location = new System.Drawing.Point(4, 56);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1003, 544);
            this.panel13.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.label15);
            this.panel15.Location = new System.Drawing.Point(766, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(232, 536);
            this.panel15.TabIndex = 6;
            // 
            // panel16
            // 
            this.panel16.AutoScroll = true;
            this.panel16.Controls.Add(this.inventoryMsgsListView);
            this.panel16.Location = new System.Drawing.Point(3, 27);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(224, 504);
            this.panel16.TabIndex = 2;
            // 
            // inventoryMsgsListView
            // 
            this.inventoryMsgsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.inventoryMsgsListView.HideSelection = false;
            this.inventoryMsgsListView.Location = new System.Drawing.Point(6, 9);
            this.inventoryMsgsListView.MultiSelect = false;
            this.inventoryMsgsListView.Name = "inventoryMsgsListView";
            this.inventoryMsgsListView.ShowGroups = false;
            this.inventoryMsgsListView.ShowItemToolTips = true;
            this.inventoryMsgsListView.Size = new System.Drawing.Size(210, 477);
            this.inventoryMsgsListView.TabIndex = 1;
            this.inventoryMsgsListView.TabStop = false;
            this.inventoryMsgsListView.TileSize = new System.Drawing.Size(200, 30);
            this.inventoryMsgsListView.UseCompatibleStateImageBehavior = false;
            this.inventoryMsgsListView.View = System.Windows.Forms.View.Tile;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Updates";
            // 
            // pckgPanel
            // 
            this.pckgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pckgPanel.Controls.Add(this.pckgDataGridView);
            this.pckgPanel.Controls.Add(this.pckgTitleLabel);
            this.pckgPanel.Location = new System.Drawing.Point(0, 3);
            this.pckgPanel.Name = "pckgPanel";
            this.pckgPanel.Size = new System.Drawing.Size(759, 163);
            this.pckgPanel.TabIndex = 4;
            // 
            // pckgDataGridView
            // 
            this.pckgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pckgDataGridView.Location = new System.Drawing.Point(3, 27);
            this.pckgDataGridView.Name = "pckgDataGridView";
            this.pckgDataGridView.ReadOnly = true;
            this.pckgDataGridView.Size = new System.Drawing.Size(751, 131);
            this.pckgDataGridView.TabIndex = 1;
            // 
            // pckgTitleLabel
            // 
            this.pckgTitleLabel.AutoSize = true;
            this.pckgTitleLabel.Location = new System.Drawing.Point(3, 11);
            this.pckgTitleLabel.Name = "pckgTitleLabel";
            this.pckgTitleLabel.Size = new System.Drawing.Size(50, 13);
            this.pckgTitleLabel.TabIndex = 0;
            this.pckgTitleLabel.Text = "Package";
            // 
            // itemPanel
            // 
            this.itemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanel.Controls.Add(this.itemDataGridView);
            this.itemPanel.Controls.Add(this.itemTitleLabel);
            this.itemPanel.Location = new System.Drawing.Point(0, 329);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(759, 210);
            this.itemPanel.TabIndex = 5;
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Location = new System.Drawing.Point(3, 32);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.ReadOnly = true;
            this.itemDataGridView.Size = new System.Drawing.Size(751, 173);
            this.itemDataGridView.TabIndex = 3;
            // 
            // itemTitleLabel
            // 
            this.itemTitleLabel.AutoSize = true;
            this.itemTitleLabel.Location = new System.Drawing.Point(3, 16);
            this.itemTitleLabel.Name = "itemTitleLabel";
            this.itemTitleLabel.Size = new System.Drawing.Size(32, 13);
            this.itemTitleLabel.TabIndex = 0;
            this.itemTitleLabel.Text = "Items";
            // 
            // boxPanel
            // 
            this.boxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxPanel.Controls.Add(this.boxDataGridView);
            this.boxPanel.Controls.Add(this.boxTitleLabel);
            this.boxPanel.Location = new System.Drawing.Point(0, 172);
            this.boxPanel.Name = "boxPanel";
            this.boxPanel.Size = new System.Drawing.Size(759, 151);
            this.boxPanel.TabIndex = 5;
            // 
            // boxDataGridView
            // 
            this.boxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boxDataGridView.Location = new System.Drawing.Point(3, 22);
            this.boxDataGridView.Name = "boxDataGridView";
            this.boxDataGridView.ReadOnly = true;
            this.boxDataGridView.Size = new System.Drawing.Size(751, 124);
            this.boxDataGridView.TabIndex = 2;
            // 
            // boxTitleLabel
            // 
            this.boxTitleLabel.AutoSize = true;
            this.boxTitleLabel.Location = new System.Drawing.Point(3, 6);
            this.boxTitleLabel.Name = "boxTitleLabel";
            this.boxTitleLabel.Size = new System.Drawing.Size(36, 13);
            this.boxTitleLabel.TabIndex = 0;
            this.boxTitleLabel.Text = "Boxes";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel14.Controls.Add(this.btnStartExitInventory);
            this.panel14.Controls.Add(this.chkIntegrityButton);
            this.panel14.Controls.Add(this.clearInventoryTablesButton);
            this.panel14.Controls.Add(this.btnStartInventory);
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1004, 50);
            this.panel14.TabIndex = 0;
            // 
            // btnStartExitInventory
            // 
            this.btnStartExitInventory.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStartExitInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartExitInventory.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartExitInventory.ForeColor = System.Drawing.Color.White;
            this.btnStartExitInventory.Location = new System.Drawing.Point(183, 3);
            this.btnStartExitInventory.Name = "btnStartExitInventory";
            this.btnStartExitInventory.Size = new System.Drawing.Size(150, 44);
            this.btnStartExitInventory.TabIndex = 8;
            this.btnStartExitInventory.Text = "Start Out";
            this.btnStartExitInventory.UseVisualStyleBackColor = false;
            this.btnStartExitInventory.Click += new System.EventHandler(this.btnStartExitInventory_Click);
            // 
            // chkIntegrityButton
            // 
            this.chkIntegrityButton.BackColor = System.Drawing.Color.SteelBlue;
            this.chkIntegrityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkIntegrityButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Bold);
            this.chkIntegrityButton.ForeColor = System.Drawing.Color.White;
            this.chkIntegrityButton.Location = new System.Drawing.Point(669, 3);
            this.chkIntegrityButton.Name = "chkIntegrityButton";
            this.chkIntegrityButton.Size = new System.Drawing.Size(150, 44);
            this.chkIntegrityButton.TabIndex = 7;
            this.chkIntegrityButton.Text = "Check Integrity";
            this.chkIntegrityButton.UseVisualStyleBackColor = false;
            this.chkIntegrityButton.Click += new System.EventHandler(this.chkIntegrityButton_Click);
            // 
            // clearInventoryTablesButton
            // 
            this.clearInventoryTablesButton.BackColor = System.Drawing.Color.IndianRed;
            this.clearInventoryTablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearInventoryTablesButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Bold);
            this.clearInventoryTablesButton.ForeColor = System.Drawing.Color.White;
            this.clearInventoryTablesButton.Location = new System.Drawing.Point(825, 3);
            this.clearInventoryTablesButton.Name = "clearInventoryTablesButton";
            this.clearInventoryTablesButton.Size = new System.Drawing.Size(176, 44);
            this.clearInventoryTablesButton.TabIndex = 6;
            this.clearInventoryTablesButton.Text = "Clear Warehouse";
            this.clearInventoryTablesButton.UseVisualStyleBackColor = false;
            this.clearInventoryTablesButton.Click += new System.EventHandler(this.clearTablesButton_Click);
            // 
            // btnStartInventory
            // 
            this.btnStartInventory.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStartInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartInventory.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartInventory.ForeColor = System.Drawing.Color.White;
            this.btnStartInventory.Location = new System.Drawing.Point(3, 3);
            this.btnStartInventory.Name = "btnStartInventory";
            this.btnStartInventory.Size = new System.Drawing.Size(174, 44);
            this.btnStartInventory.TabIndex = 3;
            this.btnStartInventory.Text = "Start In";
            this.btnStartInventory.UseVisualStyleBackColor = false;
            this.btnStartInventory.Click += new System.EventHandler(this.btnStartInventory_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(2, 637);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(91, 13);
            this.label35.TabIndex = 13;
            this.label35.Text = "Operation History:";
            // 
            // ckDisplayLog
            // 
            this.ckDisplayLog.AutoSize = true;
            this.ckDisplayLog.ForeColor = System.Drawing.Color.Black;
            this.ckDisplayLog.Location = new System.Drawing.Point(811, 635);
            this.ckDisplayLog.Name = "ckDisplayLog";
            this.ckDisplayLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckDisplayLog.Size = new System.Drawing.Size(154, 17);
            this.ckDisplayLog.TabIndex = 16;
            this.ckDisplayLog.Text = "Activate Serial Port Monitor";
            this.ckDisplayLog.UseVisualStyleBackColor = true;
            this.ckDisplayLog.CheckedChanged += new System.EventHandler(this.ckDisplayLog_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.66265F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.33735F));
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(996, 55);
            this.tableLayoutPanel3.TabIndex = 48;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(397, 47);
            this.panel6.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(126, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "开始盘存";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.checkBox5);
            this.panel7.Controls.Add(this.checkBox6);
            this.panel7.Controls.Add(this.checkBox7);
            this.panel7.Controls.Add(this.checkBox8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(408, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 47);
            this.panel7.TabIndex = 1;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox5.Location = new System.Drawing.Point(64, 17);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(57, 16);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "天线1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox6.Location = new System.Drawing.Point(436, 17);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(57, 16);
            this.checkBox6.TabIndex = 2;
            this.checkBox6.Text = "天线4";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox7.Location = new System.Drawing.Point(312, 17);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(57, 16);
            this.checkBox7.TabIndex = 1;
            this.checkBox7.Text = "天线3";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox8.Location = new System.Drawing.Point(188, 17);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(57, 16);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "天线2";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(704, 234);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(89, 20);
            this.textBox5.TabIndex = 46;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(502, 234);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(89, 20);
            this.textBox6.TabIndex = 47;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(907, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 23);
            this.button5.TabIndex = 45;
            this.button5.Text = "刷新界面";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label76.Location = new System.Drawing.Point(633, 237);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(65, 12);
            this.label76.TabIndex = 43;
            this.label76.Text = "Max RSSI：";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label77.Location = new System.Drawing.Point(431, 238);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(65, 12);
            this.label77.TabIndex = 44;
            this.label77.Text = "Min RSSI：";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label78.Location = new System.Drawing.Point(6, 237);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(71, 12);
            this.label78.TabIndex = 42;
            this.label78.Text = "标签列表： ";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboBox9);
            this.groupBox8.Controls.Add(this.lxLedControl9);
            this.groupBox8.Controls.Add(this.lxLedControl10);
            this.groupBox8.Controls.Add(this.lxLedControl11);
            this.groupBox8.Controls.Add(this.lxLedControl12);
            this.groupBox8.Controls.Add(this.label79);
            this.groupBox8.Controls.Add(this.label80);
            this.groupBox8.Controls.Add(this.label81);
            this.groupBox8.Controls.Add(this.label82);
            this.groupBox8.Controls.Add(this.label83);
            this.groupBox8.Controls.Add(this.lxLedControl13);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox8.Location = new System.Drawing.Point(2, 64);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(996, 162);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "数据";
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.comboBox9.Location = new System.Drawing.Point(-165, 111);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(55, 21);
            this.comboBox9.TabIndex = 39;
            // 
            // lxLedControl9
            // 
            this.lxLedControl9.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl9.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl9.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl9.BevelRate = 0.1F;
            this.lxLedControl9.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl9.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl9.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl9.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl9.HighlightOpaque = ((byte)(20));
            this.lxLedControl9.Location = new System.Drawing.Point(702, 118);
            this.lxLedControl9.Name = "lxLedControl9";
            this.lxLedControl9.RoundCorner = true;
            this.lxLedControl9.SegmentIntervalRatio = 50;
            this.lxLedControl9.ShowHighlight = true;
            this.lxLedControl9.Size = new System.Drawing.Size(183, 35);
            this.lxLedControl9.TabIndex = 35;
            this.lxLedControl9.Text = "0";
            this.lxLedControl9.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl9.TotalCharCount = 10;
            // 
            // lxLedControl10
            // 
            this.lxLedControl10.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl10.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl10.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl10.BevelRate = 0.1F;
            this.lxLedControl10.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl10.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl10.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl10.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl10.HighlightOpaque = ((byte)(20));
            this.lxLedControl10.Location = new System.Drawing.Point(496, 35);
            this.lxLedControl10.Name = "lxLedControl10";
            this.lxLedControl10.RoundCorner = true;
            this.lxLedControl10.SegmentIntervalRatio = 50;
            this.lxLedControl10.ShowHighlight = true;
            this.lxLedControl10.Size = new System.Drawing.Size(140, 50);
            this.lxLedControl10.TabIndex = 34;
            this.lxLedControl10.Text = "0";
            this.lxLedControl10.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl11
            // 
            this.lxLedControl11.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl11.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl11.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl11.BevelRate = 0.1F;
            this.lxLedControl11.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl11.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl11.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl11.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl11.HighlightOpaque = ((byte)(20));
            this.lxLedControl11.Location = new System.Drawing.Point(497, 103);
            this.lxLedControl11.Name = "lxLedControl11";
            this.lxLedControl11.RoundCorner = true;
            this.lxLedControl11.SegmentIntervalRatio = 50;
            this.lxLedControl11.ShowHighlight = true;
            this.lxLedControl11.Size = new System.Drawing.Size(140, 50);
            this.lxLedControl11.TabIndex = 33;
            this.lxLedControl11.Text = "0";
            this.lxLedControl11.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl12
            // 
            this.lxLedControl12.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl12.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl12.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl12.BevelRate = 0.1F;
            this.lxLedControl12.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl12.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl12.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl12.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl12.HighlightOpaque = ((byte)(20));
            this.lxLedControl12.Location = new System.Drawing.Point(702, 35);
            this.lxLedControl12.Name = "lxLedControl12";
            this.lxLedControl12.RoundCorner = true;
            this.lxLedControl12.SegmentIntervalRatio = 50;
            this.lxLedControl12.ShowHighlight = true;
            this.lxLedControl12.Size = new System.Drawing.Size(140, 50);
            this.lxLedControl12.TabIndex = 32;
            this.lxLedControl12.Text = "0";
            this.lxLedControl12.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label79.Location = new System.Drawing.Point(700, 103);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(127, 13);
            this.label79.TabIndex = 30;
            this.label79.Text = "累计运行的时间(毫秒)：";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label80.Location = new System.Drawing.Point(495, 17);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(120, 13);
            this.label80.TabIndex = 29;
            this.label80.Text = "命令识别速度(个/秒)：";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label81.Location = new System.Drawing.Point(498, 88);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(115, 13);
            this.label81.TabIndex = 28;
            this.label81.Text = "命令执行时间(毫秒)：";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label82.Location = new System.Drawing.Point(700, 17);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(103, 13);
            this.label82.TabIndex = 27;
            this.label82.Text = "命令返回数据(条)：";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label83.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label83.Location = new System.Drawing.Point(104, 17);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(149, 12);
            this.label83.TabIndex = 26;
            this.label83.Text = "已盘存的标签总数量(个)：";
            // 
            // lxLedControl13
            // 
            this.lxLedControl13.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl13.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl13.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl13.BevelRate = 0.1F;
            this.lxLedControl13.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl13.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl13.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl13.ForeColor = System.Drawing.Color.Purple;
            this.lxLedControl13.HighlightOpaque = ((byte)(20));
            this.lxLedControl13.Location = new System.Drawing.Point(106, 35);
            this.lxLedControl13.Name = "lxLedControl13";
            this.lxLedControl13.RoundCorner = true;
            this.lxLedControl13.SegmentIntervalRatio = 50;
            this.lxLedControl13.ShowHighlight = true;
            this.lxLedControl13.Size = new System.Drawing.Size(310, 118);
            this.lxLedControl13.TabIndex = 21;
            this.lxLedControl13.Text = "0";
            this.lxLedControl13.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader43,
            this.columnHeader44,
            this.columnHeader45,
            this.columnHeader46,
            this.columnHeader47,
            this.columnHeader48});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Location = new System.Drawing.Point(3, 261);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(996, 267);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "ID";
            this.columnHeader43.Width = 56;
            // 
            // columnHeader44
            // 
            this.columnHeader44.Text = "EPC";
            this.columnHeader44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader44.Width = 486;
            // 
            // columnHeader45
            // 
            this.columnHeader45.Text = "PC";
            this.columnHeader45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader45.Width = 83;
            // 
            // columnHeader46
            // 
            this.columnHeader46.Text = "识别次数";
            this.columnHeader46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader46.Width = 129;
            // 
            // columnHeader47
            // 
            this.columnHeader47.Text = "RSSI";
            this.columnHeader47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader47.Width = 95;
            // 
            // columnHeader48
            // 
            this.columnHeader48.Text = "载波频率";
            this.columnHeader48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader48.Width = 92;
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "天线1",
            "天线2",
            "天线3",
            "天线4",
            "不选"});
            this.comboBox10.Location = new System.Drawing.Point(-165, 111);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(55, 21);
            this.comboBox10.TabIndex = 39;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label87.Location = new System.Drawing.Point(700, 103);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(137, 12);
            this.label87.TabIndex = 30;
            this.label87.Text = "累计运行的时间(毫秒)：";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label88.Location = new System.Drawing.Point(495, 17);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(131, 12);
            this.label88.TabIndex = 29;
            this.label88.Text = "命令识别速度(个/秒)：";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label89.Location = new System.Drawing.Point(498, 88);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(125, 12);
            this.label89.TabIndex = 28;
            this.label89.Text = "命令执行时间(毫秒)：";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label90.Location = new System.Drawing.Point(700, 17);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(113, 12);
            this.label90.TabIndex = 27;
            this.label90.Text = "命令返回数据(条)：";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label91.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label91.Location = new System.Drawing.Point(104, 17);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(149, 12);
            this.label91.TabIndex = 26;
            this.label91.Text = "已盘存的标签总数量(个)：";
            // 
            // ckClearOperationRec
            // 
            this.ckClearOperationRec.AutoSize = true;
            this.ckClearOperationRec.Checked = true;
            this.ckClearOperationRec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckClearOperationRec.ForeColor = System.Drawing.Color.Black;
            this.ckClearOperationRec.Location = new System.Drawing.Point(135, 636);
            this.ckClearOperationRec.Name = "ckClearOperationRec";
            this.ckClearOperationRec.Size = new System.Drawing.Size(75, 17);
            this.ckClearOperationRec.TabIndex = 17;
            this.ckClearOperationRec.Text = "Auto Clear";
            this.ckClearOperationRec.UseVisualStyleBackColor = true;
            // 
            // lrtxtLog
            // 
            this.lrtxtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lrtxtLog.ForeColor = System.Drawing.Color.Black;
            this.lrtxtLog.Location = new System.Drawing.Point(0, 660);
            this.lrtxtLog.Name = "lrtxtLog";
            this.lrtxtLog.Size = new System.Drawing.Size(1018, 41);
            this.lrtxtLog.TabIndex = 1;
            this.lrtxtLog.Text = "";
            this.lrtxtLog.DoubleClick += new System.EventHandler(this.lrtxtLog_DoubleClick);
            // 
            // lxLedControl14
            // 
            this.lxLedControl14.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl14.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl14.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl14.BevelRate = 0.1F;
            this.lxLedControl14.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl14.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl14.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl14.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl14.HighlightOpaque = ((byte)(20));
            this.lxLedControl14.Location = new System.Drawing.Point(702, 118);
            this.lxLedControl14.Name = "lxLedControl14";
            this.lxLedControl14.RoundCorner = true;
            this.lxLedControl14.SegmentIntervalRatio = 50;
            this.lxLedControl14.ShowHighlight = true;
            this.lxLedControl14.Size = new System.Drawing.Size(183, 35);
            this.lxLedControl14.TabIndex = 35;
            this.lxLedControl14.Text = "0";
            this.lxLedControl14.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl14.TotalCharCount = 10;
            // 
            // lxLedControl15
            // 
            this.lxLedControl15.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl15.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl15.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl15.BevelRate = 0.1F;
            this.lxLedControl15.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl15.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl15.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl15.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl15.HighlightOpaque = ((byte)(20));
            this.lxLedControl15.Location = new System.Drawing.Point(496, 35);
            this.lxLedControl15.Name = "lxLedControl15";
            this.lxLedControl15.RoundCorner = true;
            this.lxLedControl15.SegmentIntervalRatio = 50;
            this.lxLedControl15.ShowHighlight = true;
            this.lxLedControl15.Size = new System.Drawing.Size(140, 50);
            this.lxLedControl15.TabIndex = 34;
            this.lxLedControl15.Text = "0";
            this.lxLedControl15.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl16
            // 
            this.lxLedControl16.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl16.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl16.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl16.BevelRate = 0.1F;
            this.lxLedControl16.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl16.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl16.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl16.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl16.HighlightOpaque = ((byte)(20));
            this.lxLedControl16.Location = new System.Drawing.Point(497, 103);
            this.lxLedControl16.Name = "lxLedControl16";
            this.lxLedControl16.RoundCorner = true;
            this.lxLedControl16.SegmentIntervalRatio = 50;
            this.lxLedControl16.ShowHighlight = true;
            this.lxLedControl16.Size = new System.Drawing.Size(140, 50);
            this.lxLedControl16.TabIndex = 33;
            this.lxLedControl16.Text = "0";
            this.lxLedControl16.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl17
            // 
            this.lxLedControl17.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl17.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl17.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl17.BevelRate = 0.1F;
            this.lxLedControl17.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl17.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl17.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl17.ForeColor = System.Drawing.Color.Black;
            this.lxLedControl17.HighlightOpaque = ((byte)(20));
            this.lxLedControl17.Location = new System.Drawing.Point(702, 35);
            this.lxLedControl17.Name = "lxLedControl17";
            this.lxLedControl17.RoundCorner = true;
            this.lxLedControl17.SegmentIntervalRatio = 50;
            this.lxLedControl17.ShowHighlight = true;
            this.lxLedControl17.Size = new System.Drawing.Size(140, 50);
            this.lxLedControl17.TabIndex = 32;
            this.lxLedControl17.Text = "0";
            this.lxLedControl17.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // lxLedControl18
            // 
            this.lxLedControl18.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl18.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl18.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl18.BevelRate = 0.1F;
            this.lxLedControl18.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl18.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl18.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl18.ForeColor = System.Drawing.Color.Purple;
            this.lxLedControl18.HighlightOpaque = ((byte)(20));
            this.lxLedControl18.Location = new System.Drawing.Point(106, 35);
            this.lxLedControl18.Name = "lxLedControl18";
            this.lxLedControl18.RoundCorner = true;
            this.lxLedControl18.SegmentIntervalRatio = 50;
            this.lxLedControl18.ShowHighlight = true;
            this.lxLedControl18.Size = new System.Drawing.Size(310, 118);
            this.lxLedControl18.TabIndex = 21;
            this.lxLedControl18.Text = "0";
            this.lxLedControl18.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // timerInventory
            // 
            this.timerInventory.Interval = 500;
            this.timerInventory.Tick += new System.EventHandler(this.timerInventory_Tick);
            // 
            // R2000UartDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1018, 701);
            this.Controls.Add(this.ckClearOperationRec);
            this.Controls.Add(this.ckDisplayLog);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.lrtxtLog);
            this.Controls.Add(this.tabCtrMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "R2000UartDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W";
            this.Load += new System.EventHandler(this.R2000UartDemo_Load);
            this.tabCtrMain.ResumeLayout(false);
            this.PagReaderSetting.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbCmdReadGpio.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbCmdBeeper.ResumeLayout(false);
            this.gbCmdBeeper.PerformLayout();
            this.gbCmdTemperature.ResumeLayout(false);
            this.gbCmdTemperature.PerformLayout();
            this.gbCmdVersion.ResumeLayout(false);
            this.gbCmdVersion.PerformLayout();
            this.gbCmdBaudrate.ResumeLayout(false);
            this.gbCmdBaudrate.PerformLayout();
            this.gbCmdReaderAddress.ResumeLayout(false);
            this.gbCmdReaderAddress.PerformLayout();
            this.gbTcpIp.ResumeLayout(false);
            this.gbTcpIp.PerformLayout();
            this.gbRS232.ResumeLayout(false);
            this.gbRS232.PerformLayout();
            this.gbConnectType.ResumeLayout(false);
            this.gbConnectType.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbReturnLoss.ResumeLayout(false);
            this.gbReturnLoss.PerformLayout();
            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            this.gbMonza.ResumeLayout(false);
            this.gbMonza.PerformLayout();
            this.gbCmdAntDetector.ResumeLayout(false);
            this.gbCmdAntDetector.PerformLayout();
            this.gbCmdDrm.ResumeLayout(false);
            this.gbCmdDrm.PerformLayout();
            this.gbCmdAntenna.ResumeLayout(false);
            this.gbCmdAntenna.PerformLayout();
            this.gbCmdRegion.ResumeLayout(false);
            this.gbCmdRegion.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.gbCmdOutputPower.ResumeLayout(false);
            this.gbCmdOutputPower.PerformLayout();
            this.pageEpcTest.ResumeLayout(false);
            this.tabEpcTest.ResumeLayout(false);
            this.pageRealMode.ResumeLayout(false);
            this.pageRealMode.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReal1)).EndInit();
            this.pageBufferedMode.ResumeLayout(false);
            this.pageBufferedMode.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledBuffer1)).EndInit();
            this.pageFast4AntMode.ResumeLayout(false);
            this.pageFast4AntMode.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFast1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pageAcessTag.ResumeLayout(false);
            this.gbCmdOperateTag.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.PagISO18000.ResumeLayout(false);
            this.PagISO18000.PerformLayout();
            this.gbISO1800LockQuery.ResumeLayout(false);
            this.gbISO1800LockQuery.PerformLayout();
            this.gbISO1800ReadWrite.ResumeLayout(false);
            this.gbISO1800ReadWrite.PerformLayout();
            this.PagTranDataLog.ResumeLayout(false);
            this.gbCmdManual.ResumeLayout(false);
            this.gbCmdManual.PerformLayout();
            this.pagKimlikDemo.ResumeLayout(false);
            this.kimlikTabControl.ResumeLayout(false);
            this.kimlikImageTabPage.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.backKimlikPanel.ResumeLayout(false);
            this.backKimlikPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backKimlikPicBox)).EndInit();
            this.kimlikFrontPanel.ResumeLayout(false);
            this.kimlikFrontPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wantedPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kimlikPicBox)).EndInit();
            this.kimlikListTabPage.ResumeLayout(false);
            this.kimlikListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kimlikListDataGridView)).EndInit();
            this.panel11.ResumeLayout(false);
            this.pagInvDemo.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.pckgPanel.ResumeLayout(false);
            this.pckgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pckgDataGridView)).EndInit();
            this.itemPanel.ResumeLayout(false);
            this.itemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.boxPanel.ResumeLayout(false);
            this.boxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxDataGridView)).EndInit();
            this.panel14.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrMain;
        private System.Windows.Forms.TabPage PagReaderSetting;
        private CustomControl.LogRichTextBox lrtxtLog;
        private System.Windows.Forms.TabPage PagTranDataLog;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label label17;
        private CustomControl.HexTextBox htxtSendData;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbCmdManual;
        private CustomControl.LogRichTextBox lrtxtDataTran;
        private CustomControl.HexTextBox htxtCheckData;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.TabPage PagISO18000;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btnWriteTagISO18000;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private CustomControl.HexTextBox htxtReadUID;
        private CustomControl.HexTextBox htxtQueryAdd;
        private CustomControl.HexTextBox htxtWriteStartAdd;
        private System.Windows.Forms.Button btnInventoryISO18000;
        private System.Windows.Forms.Button btnReadTagISO18000;
        private System.Windows.Forms.Button btnLockTagISO18000;
        private System.Windows.Forms.Button btnQueryTagISO18000;
        private System.Windows.Forms.Label label50;
        private CustomControl.HexTextBox htxtReadStartAdd;
        private CustomControl.HexTextBox htxtWriteData18000;
        private CustomControl.HexTextBox htxtLockAdd;
        private System.Windows.Forms.ListView ltvTagISO18000;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtReadLength;
        private System.Windows.Forms.TextBox txtWriteLength;
        private CustomControl.HexTextBox htxtReadData18000;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox gbISO1800ReadWrite;
        private System.Windows.Forms.GroupBox gbISO1800LockQuery;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox ckDisplayLog;
        private System.Windows.Forms.TextBox txtLoopTimes;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtLoop;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TabPage pageEpcTest;
        private System.Windows.Forms.TabControl tabEpcTest;
        private System.Windows.Forms.TabPage pageFast4AntMode;
        private System.Windows.Forms.TabPage pageRealMode;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private System.Windows.Forms.ColumnHeader columnHeader38;
        private System.Windows.Forms.ColumnHeader columnHeader39;
        private System.Windows.Forms.ColumnHeader columnHeader40;
        private System.Windows.Forms.ColumnHeader columnHeader41;
        private System.Windows.Forms.ColumnHeader columnHeader42;
        private System.Windows.Forms.ComboBox cmbAntSelect4;
        private System.Windows.Forms.ComboBox cmbAntSelect3;
        private System.Windows.Forms.ComboBox cmbAntSelect2;
        private System.Windows.Forms.ComboBox cmbAntSelect1;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TabPage pageBufferedMode;
        private System.Windows.Forms.TabPage pageAcessTag;
        private System.Windows.Forms.Label txtFastTagList;
        private System.Windows.Forms.ListView lvFastList;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonFastFresh;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtFastMinRssi;
        private System.Windows.Forms.TextBox txtFastMaxRssi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbRealMinRssi;
        private System.Windows.Forms.TextBox tbRealMaxRssi;
        private System.Windows.Forms.Button btRealFresh;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label lbRealTagCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private LxControl.LxLedControl ledReal5;
        private LxControl.LxLedControl ledReal2;
        private LxControl.LxLedControl ledReal4;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private LxControl.LxLedControl ledReal1;
        private System.Windows.Forms.Button btRealTimeInventory;
        private System.Windows.Forms.Button btGetBuffer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btBufferFresh;
        private System.Windows.Forms.Label labelBufferTagCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private LxControl.LxLedControl lxLedControl9;
        private LxControl.LxLedControl lxLedControl10;
        private LxControl.LxLedControl lxLedControl11;
        private LxControl.LxLedControl lxLedControl12;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private LxControl.LxLedControl lxLedControl13;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.ColumnHeader columnHeader44;
        private System.Windows.Forms.ColumnHeader columnHeader45;
        private System.Windows.Forms.ColumnHeader columnHeader46;
        private System.Windows.Forms.ColumnHeader columnHeader47;
        private System.Windows.Forms.ColumnHeader columnHeader48;
        private System.Windows.Forms.ComboBox comboBox10;
        private LxControl.LxLedControl lxLedControl14;
        private LxControl.LxLedControl lxLedControl15;
        private LxControl.LxLedControl lxLedControl16;
        private LxControl.LxLedControl lxLedControl17;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private LxControl.LxLedControl lxLedControl18;
        private System.Windows.Forms.Button btQueryBuffer;
        private System.Windows.Forms.Button btGetClearBuffer;
        private System.Windows.Forms.Button btClearBuffer;
        private System.Windows.Forms.ListView lvBufferList;
        private System.Windows.Forms.ColumnHeader columnHeader49;
        private System.Windows.Forms.ColumnHeader columnHeader50;
        private System.Windows.Forms.ColumnHeader columnHeader51;
        private System.Windows.Forms.ColumnHeader columnHeader52;
        private System.Windows.Forms.ColumnHeader columnHeader53;
        private System.Windows.Forms.ColumnHeader columnHeader54;
        private System.Windows.Forms.GroupBox gbCmdOperateTag;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button btnKillTag;
        private CustomControl.HexTextBox htxtKillPwd;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox15;
        private CustomControl.HexTextBox htxtLockPwd;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.RadioButton rdbUserMemory;
        private System.Windows.Forms.RadioButton rdbTidMemory;
        private System.Windows.Forms.RadioButton rdbEpcMermory;
        private System.Windows.Forms.RadioButton rdbKillPwd;
        private System.Windows.Forms.RadioButton rdbAccessPwd;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.RadioButton rdbLockEver;
        private System.Windows.Forms.RadioButton rdbFreeEver;
        private System.Windows.Forms.RadioButton rdbLock;
        private System.Windows.Forms.RadioButton rdbFree;
        private System.Windows.Forms.Button btnLockTag;
        private System.Windows.Forms.GroupBox groupBox14;
        private CustomControl.HexTextBox htxtWriteData;
        private System.Windows.Forms.TextBox txtWordCnt;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnWriteTag;
        private System.Windows.Forms.Button btnReadTag;
        private System.Windows.Forms.TextBox txtWordAdd;
        private System.Windows.Forms.Label label26;
        private CustomControl.HexTextBox htxtReadAndWritePwd;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.RadioButton rdbUser;
        private System.Windows.Forms.RadioButton rdbTid;
        private System.Windows.Forms.RadioButton rdbEpc;
        private System.Windows.Forms.RadioButton rdbReserved;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnSetAccessEpcMatch;
        private System.Windows.Forms.ComboBox cmbSetAccessEpcMatch;
        private System.Windows.Forms.TextBox txtAccessEpcMatch;
        private System.Windows.Forms.CheckBox ckAccessEpcMatch;
        private System.Windows.Forms.TextBox textRealRound;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TextBox textReadRoundBuffer;
        private System.Windows.Forms.ListView ltvOperate;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ListView lvRealList;
        private LxControl.LxLedControl ledReal3;
        private System.Windows.Forms.GroupBox groupBox3;
        private LxControl.LxLedControl ledBuffer4;
        private System.Windows.Forms.ComboBox comboBox11;
        private LxControl.LxLedControl ledBuffer5;
        private LxControl.LxLedControl ledBuffer2;
        private LxControl.LxLedControl ledBuffer3;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private LxControl.LxLedControl ledBuffer1;
        private System.Windows.Forms.Button btBufferInventory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button btFastInventory;
        private System.Windows.Forms.GroupBox groupBox2;
        private LxControl.LxLedControl ledFast4;
        private System.Windows.Forms.ComboBox comboBox7;
        private LxControl.LxLedControl ledFast5;
        private LxControl.LxLedControl ledFast2;
        private LxControl.LxLedControl ledFast3;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private LxControl.LxLedControl ledFast1;
        private System.Windows.Forms.TextBox txtDStay;
        private System.Windows.Forms.TextBox txtCStay;
        private System.Windows.Forms.TextBox txtBStay;
        private System.Windows.Forms.TextBox txtAStay;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbCmdReadGpio;
        private System.Windows.Forms.Button btnWriteGpio4Value;
        private System.Windows.Forms.Button btnWriteGpio3Value;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.RadioButton rdbGpio4High;
        private System.Windows.Forms.RadioButton rdbGpio4Low;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RadioButton rdbGpio3High;
        private System.Windows.Forms.RadioButton rdbGpio3Low;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.RadioButton rdbGpio2High;
        private System.Windows.Forms.RadioButton rdbGpio2Low;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.RadioButton rdbGpio1High;
        private System.Windows.Forms.RadioButton rdbGpio1Low;
        private System.Windows.Forms.Button btnReadGpioValue;
        private System.Windows.Forms.GroupBox gbCmdBeeper;
        private System.Windows.Forms.Button btnSetBeeperMode;
        private System.Windows.Forms.RadioButton rdbBeeperModeTag;
        private System.Windows.Forms.RadioButton rdbBeeperModeInventory;
        private System.Windows.Forms.RadioButton rdbBeeperModeSlient;
        private System.Windows.Forms.GroupBox gbCmdTemperature;
        private System.Windows.Forms.Button btnGetReaderTemperature;
        private System.Windows.Forms.TextBox txtReaderTemperature;
        private System.Windows.Forms.GroupBox gbCmdVersion;
        private System.Windows.Forms.Button btnGetFirmwareVersion;
        private System.Windows.Forms.TextBox txtFirmwareVersion;
        private System.Windows.Forms.Button btnResetReader;
        public System.Windows.Forms.GroupBox gbCmdBaudrate;
        private CustomControl.HexTextBox htbGetIdentifier;
        private CustomControl.HexTextBox htbSetIdentifier;
        private System.Windows.Forms.Button btSetIdentifier;
        private System.Windows.Forms.Button btGetIdentifier;
        private System.Windows.Forms.GroupBox gbCmdReaderAddress;
        private CustomControl.HexTextBox htxtReadId;
        private System.Windows.Forms.Button btnSetReadAddress;
        private System.Windows.Forms.GroupBox gbTcpIp;
        private System.Windows.Forms.Button btnDisconnectTcp;
        private System.Windows.Forms.TextBox txtTcpPort;
        private System.Windows.Forms.Button btnConnectTcp;
        private CustomControl.IpAddressTextBox ipIpServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbRS232;
        private System.Windows.Forms.Button btnSetUartBaudrate;
        private System.Windows.Forms.Button btnDisconnectRs232;
        private System.Windows.Forms.ComboBox cmbSetBaudrate;
        private System.Windows.Forms.Label lbChangeBaudrate;
        private System.Windows.Forms.Button btnConnectRs232;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbConnectType;
        private System.Windows.Forms.RadioButton rdbTcpIp;
        private System.Windows.Forms.RadioButton rdbRS232;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbMonza;
        private System.Windows.Forms.RadioButton rdbMonzaOff;
        private System.Windows.Forms.Button btSetMonzaStatus;
        private System.Windows.Forms.Button btGetMonzaStatus;
        private System.Windows.Forms.RadioButton rdbMonzaOn;
        private System.Windows.Forms.GroupBox gbCmdAntenna;
        private System.Windows.Forms.Button btnGetWorkAntenna;
        private System.Windows.Forms.Button btnSetWorkAntenna;
        private System.Windows.Forms.GroupBox gbCmdAntDetector;
        private System.Windows.Forms.Button btnGetAntDetector;
        private System.Windows.Forms.Button btnSetAntDetector;
        private System.Windows.Forms.GroupBox gbCmdDrm;
        private System.Windows.Forms.Button btnGetDrmMode;
        private System.Windows.Forms.Button btnSetDrmMode;
        private System.Windows.Forms.RadioButton rdbDrmModeClose;
        private System.Windows.Forms.RadioButton rdbDrmModeOpen;
        private System.Windows.Forms.GroupBox gbCmdRegion;
        private System.Windows.Forms.Button btnGetFrequencyRegion;
        private System.Windows.Forms.Button btnSetFrequencyRegion;
        private System.Windows.Forms.GroupBox gbCmdOutputPower;
        private System.Windows.Forms.Button btnGetOutputPower;
        private System.Windows.Forms.Button btnSetOutputPower;
        private System.Windows.Forms.TextBox txtOutputPower;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btReaderSetupRefresh;
        private System.Windows.Forms.Button btRfSetup;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox tbAntDectector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.CheckBox cbRealWorkant1;
        private System.Windows.Forms.CheckBox cbRealWorkant4;
        private System.Windows.Forms.CheckBox cbRealWorkant3;
        private System.Windows.Forms.CheckBox cbRealWorkant2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox cbRealSession;
        private System.Windows.Forms.ComboBox cmbTarget;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.GroupBox gbProfile;
        private System.Windows.Forms.Button btGetProfile;
        private System.Windows.Forms.Button btSetProfile;
        private System.Windows.Forms.RadioButton rdbProfile3;
        private System.Windows.Forms.RadioButton rdbProfile2;
        private System.Windows.Forms.RadioButton rdbProfile1;
        private System.Windows.Forms.RadioButton rdbProfile0;
        private System.Windows.Forms.CheckBox cbBufferWorkant1;
        private System.Windows.Forms.CheckBox cbBufferWorkant4;
        private System.Windows.Forms.CheckBox cbBufferWorkant2;
        private System.Windows.Forms.CheckBox cbBufferWorkant3;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TextBox textFreqQuantity;
        private System.Windows.Forms.TextBox TextFreqInterval;
        private System.Windows.Forms.TextBox textStartFreq;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cmbFrequencyEnd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbFrequencyStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdbRegionChn;
        private System.Windows.Forms.RadioButton rdbRegionEtsi;
        private System.Windows.Forms.RadioButton rdbRegionFcc;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.GroupBox gbReturnLoss;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.TextBox textReturnLoss;
        private System.Windows.Forms.Button btReturnLoss;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.ComboBox cmbWorkAnt;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.ComboBox cmbReturnLossFreq;
        private System.Windows.Forms.CheckBox ckClearOperationRec;
        private System.Windows.Forms.CheckBox cbUserDefineFreq;
        private System.Windows.Forms.Timer timerInventory;
        private System.Windows.Forms.TabPage pagKimlikDemo;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnStartKimlik;
        private System.Windows.Forms.TextBox tagsTextBox;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox kimlikPicBox;
        private System.Windows.Forms.PictureBox backKimlikPicBox;
        private System.Windows.Forms.Label adiLabel;
        private System.Windows.Forms.Label doguYeriLabel;
        private System.Windows.Forms.Label babaAdiLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label seriLabel;
        private System.Windows.Forms.Label anaAdiLabel;
        private System.Windows.Forms.Label doguTarihLabel;
        private System.Windows.Forms.Label soyadiLabel;
        private System.Windows.Forms.Label tcKimLabel;
        private System.Windows.Forms.PictureBox imagePicBox;
        private System.Windows.Forms.Label verilisTarihiLabel;
        private System.Windows.Forms.Label verilisNedeniLabel;
        private System.Windows.Forms.Label kayitNoLabel;
        private System.Windows.Forms.Label verildigiLabel;
        private System.Windows.Forms.Label siraNoLabel;
        private System.Windows.Forms.Label aileSiraNoLabel;
        private System.Windows.Forms.Label ciltLabel;
        private System.Windows.Forms.Label mahLabel;
        private System.Windows.Forms.Label ilceLabel;
        private System.Windows.Forms.Label ilLabel;
        private System.Windows.Forms.Label kanLabel;
        private System.Windows.Forms.Label diniLabel;
        private System.Windows.Forms.Label medeniLabel;
        private System.Windows.Forms.Label nufusSerfiLabel;
        private System.Windows.Forms.Label vhkiLabel;
        private System.Windows.Forms.Panel kimlikFrontPanel;
        private System.Windows.Forms.Panel backKimlikPanel;
        private System.Windows.Forms.TabPage pagInvDemo;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnStartInventory;
        private System.Windows.Forms.Panel itemPanel;
        private System.Windows.Forms.Panel boxPanel;
        private System.Windows.Forms.Panel pckgPanel;
        private System.Windows.Forms.Label itemTitleLabel;
        private System.Windows.Forms.Label boxTitleLabel;
        private System.Windows.Forms.Label pckgTitleLabel;
        private System.Windows.Forms.DataGridView pckgDataGridView;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridView boxDataGridView;
        private System.Windows.Forms.Button clearInventoryTablesButton;
        private System.Windows.Forms.Panel kimlikListPanel;
        private System.Windows.Forms.DataGridView kimlikListDataGridView;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button kimlikDetailsButton;
        private System.Windows.Forms.TabControl kimlikTabControl;
        private System.Windows.Forms.TabPage kimlikImageTabPage;
        private System.Windows.Forms.TabPage kimlikListTabPage;
        private System.Windows.Forms.Button chkIntegrityButton;
        private System.Windows.Forms.Button clearKimlikButton;
        private System.Windows.Forms.Button getAllKimlikFromDbButton;
        private System.Windows.Forms.PictureBox wantedPicBox;
        private System.Windows.Forms.Button btnStartExitInventory;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.ListView inventoryMsgsListView;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel16;
    }
}

