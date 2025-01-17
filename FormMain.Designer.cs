﻿namespace SCJMapper_V2
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      timer1.Stop( );
      // Unacquire all DirectInput objects.
      foreach ( Joystick.JoystickCls js in m_Joystick ) js.FinishDX( );
      m_Joystick.Clear( );

      if ( disposing && ( components != null ) ) {
        components.Dispose( );
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( )
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.btDumpList = new System.Windows.Forms.Button();
      this.rtb = new System.Windows.Forms.RichTextBox();
      this.cmCopyPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tsiCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiPaste = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiPReplace = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiSelAll = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsiOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.tsiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.btGrab = new System.Windows.Forms.Button();
      this.btDump = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btMakeMod = new System.Windows.Forms.Button();
      this.btJsKbd = new System.Windows.Forms.Button();
      this.IL = new System.Windows.Forms.ImageList(this.components);
      this.btBlend = new System.Windows.Forms.Button();
      this.lblLastJ = new System.Windows.Forms.TextBox();
      this.cmMouseEntry = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tmeK_Tab = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.tmeXAxis = new System.Windows.Forms.ToolStripMenuItem();
      this.tmeYAxis = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.tmeWUp = new System.Windows.Forms.ToolStripMenuItem();
      this.tmeWDown = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.cbxThrottle = new System.Windows.Forms.CheckBox();
      this.btFind = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.btClear = new System.Windows.Forms.Button();
      this.lblAction = new System.Windows.Forms.Label();
      this.btAssign = new System.Windows.Forms.Button();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.cmAddDel = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tdiCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
      this.tdiExpandAll = new System.Windows.Forms.ToolStripMenuItem();
      this.tdiSGroup1 = new System.Windows.Forms.ToolStripSeparator();
      this.tdiAssignBinding = new System.Windows.Forms.ToolStripMenuItem();
      this.tdiBlendBinding = new System.Windows.Forms.ToolStripMenuItem();
      this.tdiClearBinding = new System.Windows.Forms.ToolStripMenuItem();
      this.tdiSGroup2 = new System.Windows.Forms.ToolStripSeparator();
      this.tdiAddBinding = new System.Windows.Forms.ToolStripMenuItem();
      this.tdiDelBinding = new System.Windows.Forms.ToolStripMenuItem();
      this.tdiSGroup3 = new System.Windows.Forms.ToolStripSeparator();
      this.tdiTxDefActivationMode = new System.Windows.Forms.ToolStripTextBox();
      this.tdiCbxActivation = new System.Windows.Forms.ToolStripComboBox();
      this.tdiSGroup4 = new System.Windows.Forms.ToolStripSeparator();
      this.tdiAddMod1 = new System.Windows.Forms.ToolStripMenuItem();
      this.tdiAddMod2 = new System.Windows.Forms.ToolStripMenuItem();
      this.tdiAddMod3 = new System.Windows.Forms.ToolStripMenuItem();
      this.tc1 = new System.Windows.Forms.TabControl();
      this.tabJS1 = new System.Windows.Forms.TabPage();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btClip = new System.Windows.Forms.Button();
      this.txRebind = new System.Windows.Forms.TextBox();
      this.linkLblReleases = new System.Windows.Forms.LinkLabel();
      this.label8 = new System.Windows.Forms.Label();
      this.lblTitle = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.buttonExit = new System.Windows.Forms.Button();
      this.OFD = new System.Windows.Forms.OpenFileDialog();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SFD = new System.Windows.Forms.SaveFileDialog();
      this.tlpanel = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.btOptions = new System.Windows.Forms.Button();
      this.btDumpLog = new System.Windows.Forms.Button();
      this.btJSTuning = new System.Windows.Forms.Button();
      this.btDumpProfile = new System.Windows.Forms.Button();
      this.btTable = new System.Windows.Forms.Button();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btSettings = new System.Windows.Forms.Button();
      this.btJsReassign = new System.Windows.Forms.Button();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.btSaveMyMapping = new System.Windows.Forms.Button();
      this.txMappingName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblPTU = new System.Windows.Forms.Label();
      this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      this.cbxShowJoystick = new System.Windows.Forms.CheckBox();
      this.cbxShowGamepad = new System.Windows.Forms.CheckBox();
      this.cbxShowKeyboard = new System.Windows.Forms.CheckBox();
      this.cbxShowMouse = new System.Windows.Forms.CheckBox();
      this.cbxShowMappedOnly = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txFilter = new System.Windows.Forms.TextBox();
      this.btClearFilter = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.lblProfileUsed = new System.Windows.Forms.Label();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsBtReset = new System.Windows.Forms.ToolStripDropDownButton();
      this.resetDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.resetEmptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsDDbtMappings = new System.Windows.Forms.ToolStripDropDownButton();
      this.tsBtLoad = new System.Windows.Forms.ToolStripDropDownButton();
      this.defaultsLoadAndGrabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.resetLoadAndGrabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadAndGrabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.label5 = new System.Windows.Forms.Label();
      this.lblAssigned = new System.Windows.Forms.Label();
      this.UC_JoyPanel = new SCJMapper_V2.Joystick.UC_JoyPanel();
      this.cmCopyPaste.SuspendLayout();
      this.panel2.SuspendLayout();
      this.cmMouseEntry.SuspendLayout();
      this.cmAddDel.SuspendLayout();
      this.tc1.SuspendLayout();
      this.tabJS1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tlpanel.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.flowLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btDumpList
      // 
      this.btDumpList.Location = new System.Drawing.Point(3, 33);
      this.btDumpList.Name = "btDumpList";
      this.btDumpList.Size = new System.Drawing.Size(120, 24);
      this.btDumpList.TabIndex = 24;
      this.btDumpList.Text = "Dump List-->";
      this.btDumpList.UseVisualStyleBackColor = true;
      this.btDumpList.Click += new System.EventHandler(this.btDumpList_Click);
      // 
      // rtb
      // 
      this.rtb.AcceptsTab = true;
      this.rtb.ContextMenuStrip = this.cmCopyPaste;
      this.rtb.DetectUrls = false;
      this.rtb.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtb.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtb.Location = new System.Drawing.Point(686, 81);
      this.rtb.Name = "rtb";
      this.tlpanel.SetRowSpan(this.rtb, 2);
      this.rtb.Size = new System.Drawing.Size(362, 686);
      this.rtb.TabIndex = 21;
      this.rtb.Text = "";
      this.rtb.WordWrap = false;
      // 
      // cmCopyPaste
      // 
      this.cmCopyPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiCopy,
            this.tsiPaste,
            this.tsiPReplace,
            this.tsiSelAll,
            this.toolStripSeparator1,
            this.tsiOpen,
            this.tsiSaveAs});
      this.cmCopyPaste.Name = "cmCopyPaste";
      this.cmCopyPaste.Size = new System.Drawing.Size(170, 142);
      // 
      // tsiCopy
      // 
      this.tsiCopy.Name = "tsiCopy";
      this.tsiCopy.Size = new System.Drawing.Size(169, 22);
      this.tsiCopy.Text = "Copy";
      this.tsiCopy.Click += new System.EventHandler(this.tsiCopy_Click);
      // 
      // tsiPaste
      // 
      this.tsiPaste.Name = "tsiPaste";
      this.tsiPaste.Size = new System.Drawing.Size(169, 22);
      this.tsiPaste.Text = "Paste";
      this.tsiPaste.Click += new System.EventHandler(this.tsiPaste_Click);
      // 
      // tsiPReplace
      // 
      this.tsiPReplace.Name = "tsiPReplace";
      this.tsiPReplace.Size = new System.Drawing.Size(169, 22);
      this.tsiPReplace.Text = "Paste (Replace all)";
      this.tsiPReplace.Click += new System.EventHandler(this.tsiPReplace_Click);
      // 
      // tsiSelAll
      // 
      this.tsiSelAll.Name = "tsiSelAll";
      this.tsiSelAll.Size = new System.Drawing.Size(169, 22);
      this.tsiSelAll.Text = "Select All";
      this.tsiSelAll.Click += new System.EventHandler(this.tsiSelAll_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
      // 
      // tsiOpen
      // 
      this.tsiOpen.Name = "tsiOpen";
      this.tsiOpen.Size = new System.Drawing.Size(169, 22);
      this.tsiOpen.Text = "Open...";
      this.tsiOpen.Click += new System.EventHandler(this.tsiOpen_Click);
      // 
      // tsiSaveAs
      // 
      this.tsiSaveAs.Name = "tsiSaveAs";
      this.tsiSaveAs.Size = new System.Drawing.Size(169, 22);
      this.tsiSaveAs.Text = "Save as...";
      this.tsiSaveAs.Click += new System.EventHandler(this.tsiSaveAs_Click);
      // 
      // btGrab
      // 
      this.btGrab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btGrab.Location = new System.Drawing.Point(181, 3);
      this.btGrab.Name = "btGrab";
      this.btGrab.Size = new System.Drawing.Size(120, 24);
      this.btGrab.TabIndex = 19;
      this.btGrab.Text = "<-- Grab XML";
      this.btGrab.UseVisualStyleBackColor = true;
      this.btGrab.Click += new System.EventHandler(this.btGrab_Click);
      // 
      // btDump
      // 
      this.btDump.Location = new System.Drawing.Point(3, 3);
      this.btDump.Name = "btDump";
      this.btDump.Size = new System.Drawing.Size(120, 24);
      this.btDump.TabIndex = 20;
      this.btDump.Text = "Dump XML-->";
      this.btDump.UseVisualStyleBackColor = true;
      this.btDump.Click += new System.EventHandler(this.btDump_Click);
      // 
      // panel2
      // 
      this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.lblAssigned);
      this.panel2.Controls.Add(this.btJsKbd);
      this.panel2.Controls.Add(this.btBlend);
      this.panel2.Controls.Add(this.lblLastJ);
      this.panel2.Controls.Add(this.cbxThrottle);
      this.panel2.Controls.Add(this.btFind);
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.btClear);
      this.panel2.Controls.Add(this.lblAction);
      this.panel2.Controls.Add(this.btAssign);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(3, 379);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(298, 167);
      this.panel2.TabIndex = 17;
      // 
      // btMakeMod
      // 
      this.btMakeMod.Location = new System.Drawing.Point(155, 3);
      this.btMakeMod.Name = "btMakeMod";
      this.btMakeMod.Size = new System.Drawing.Size(73, 25);
      this.btMakeMod.TabIndex = 17;
      this.btMakeMod.Text = "Make MOD";
      this.btMakeMod.UseVisualStyleBackColor = true;
      this.btMakeMod.Visible = false;
      this.btMakeMod.Click += new System.EventHandler(this.btMakeMod_Click);
      // 
      // btJsKbd
      // 
      this.btJsKbd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btJsKbd.ImageKey = "J";
      this.btJsKbd.ImageList = this.IL;
      this.btJsKbd.Location = new System.Drawing.Point(107, 134);
      this.btJsKbd.Name = "btJsKbd";
      this.btJsKbd.Size = new System.Drawing.Size(79, 25);
      this.btJsKbd.TabIndex = 16;
      this.btJsKbd.Text = "JS / Kbd";
      this.btJsKbd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btJsKbd.UseVisualStyleBackColor = true;
      this.btJsKbd.Click += new System.EventHandler(this.btJsKbd_Click);
      // 
      // IL
      // 
      this.IL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL.ImageStream")));
      this.IL.TransparentColor = System.Drawing.Color.Transparent;
      this.IL.Images.SetKeyName(0, "Map");
      this.IL.Images.SetKeyName(1, "Selected");
      this.IL.Images.SetKeyName(2, "J");
      this.IL.Images.SetKeyName(3, "K");
      this.IL.Images.SetKeyName(4, "M");
      this.IL.Images.SetKeyName(5, "X");
      this.IL.Images.SetKeyName(6, "P");
      this.IL.Images.SetKeyName(7, "Z");
      this.IL.Images.SetKeyName(8, "Add");
      // 
      // btBlend
      // 
      this.btBlend.Location = new System.Drawing.Point(9, 134);
      this.btBlend.Name = "btBlend";
      this.btBlend.Size = new System.Drawing.Size(73, 25);
      this.btBlend.TabIndex = 16;
      this.btBlend.Text = "Disable";
      this.btBlend.UseVisualStyleBackColor = true;
      this.btBlend.Click += new System.EventHandler(this.btBlend_Click);
      // 
      // lblLastJ
      // 
      this.lblLastJ.CausesValidation = false;
      this.lblLastJ.ContextMenuStrip = this.cmMouseEntry;
      this.lblLastJ.Location = new System.Drawing.Point(64, 74);
      this.lblLastJ.Name = "lblLastJ";
      this.lblLastJ.Size = new System.Drawing.Size(224, 22);
      this.lblLastJ.TabIndex = 14;
      this.lblLastJ.Text = "...";
      this.lblLastJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblLastJ_KeyDown);
      // 
      // cmMouseEntry
      // 
      this.cmMouseEntry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmeK_Tab,
            this.toolStripSeparator7,
            this.tmeXAxis,
            this.tmeYAxis,
            this.toolStripSeparator3,
            this.tmeWUp,
            this.tmeWDown,
            this.toolStripSeparator4});
      this.cmMouseEntry.Name = "cmMouseEntry";
      this.cmMouseEntry.Size = new System.Drawing.Size(172, 132);
      this.cmMouseEntry.Opening += new System.ComponentModel.CancelEventHandler(this.cmMouseEntry_Opening);
      // 
      // tmeK_Tab
      // 
      this.tmeK_Tab.Name = "tmeK_Tab";
      this.tmeK_Tab.Size = new System.Drawing.Size(171, 22);
      this.tmeK_Tab.Tag = "K_Tab";
      this.tmeK_Tab.Text = "Kbd - TAB";
      this.tmeK_Tab.Click += new System.EventHandler(this.tmeItem_Click);
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new System.Drawing.Size(168, 6);
      // 
      // tmeXAxis
      // 
      this.tmeXAxis.Name = "tmeXAxis";
      this.tmeXAxis.Size = new System.Drawing.Size(171, 22);
      this.tmeXAxis.Tag = "X";
      this.tmeXAxis.Text = "X-Axis (horizontal)";
      this.tmeXAxis.Click += new System.EventHandler(this.tmeItem_Click);
      // 
      // tmeYAxis
      // 
      this.tmeYAxis.Name = "tmeYAxis";
      this.tmeYAxis.Size = new System.Drawing.Size(171, 22);
      this.tmeYAxis.Tag = "Y";
      this.tmeYAxis.Text = "Y-Axis (vertical)";
      this.tmeYAxis.Click += new System.EventHandler(this.tmeItem_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
      // 
      // tmeWUp
      // 
      this.tmeWUp.Name = "tmeWUp";
      this.tmeWUp.Size = new System.Drawing.Size(171, 22);
      this.tmeWUp.Tag = "U";
      this.tmeWUp.Text = "Wheel Up";
      this.tmeWUp.Click += new System.EventHandler(this.tmeItem_Click);
      // 
      // tmeWDown
      // 
      this.tmeWDown.Name = "tmeWDown";
      this.tmeWDown.Size = new System.Drawing.Size(171, 22);
      this.tmeWDown.Tag = "D";
      this.tmeWDown.Text = "Wheel Down";
      this.tmeWDown.Click += new System.EventHandler(this.tmeItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(168, 6);
      // 
      // cbxThrottle
      // 
      this.cbxThrottle.AutoSize = true;
      this.cbxThrottle.Location = new System.Drawing.Point(89, 108);
      this.cbxThrottle.Name = "cbxThrottle";
      this.cbxThrottle.Size = new System.Drawing.Size(66, 17);
      this.cbxThrottle.TabIndex = 13;
      this.cbxThrottle.Text = "Throttle";
      this.cbxThrottle.UseVisualStyleBackColor = true;
      // 
      // btFind
      // 
      this.btFind.Location = new System.Drawing.Point(215, 103);
      this.btFind.Name = "btFind";
      this.btFind.Size = new System.Drawing.Size(73, 25);
      this.btFind.TabIndex = 12;
      this.btFind.Text = "Find 1st.";
      this.btFind.UseVisualStyleBackColor = true;
      this.btFind.Click += new System.EventHandler(this.btFind_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(4, 77);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(50, 13);
      this.label7.TabIndex = 3;
      this.label7.Text = "Dev Ctrl.";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(4, 18);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(50, 13);
      this.label6.TabIndex = 3;
      this.label6.Text = "Selected";
      // 
      // btClear
      // 
      this.btClear.Location = new System.Drawing.Point(215, 134);
      this.btClear.Name = "btClear";
      this.btClear.Size = new System.Drawing.Size(73, 25);
      this.btClear.TabIndex = 2;
      this.btClear.Text = "Clear";
      this.btClear.UseVisualStyleBackColor = true;
      this.btClear.Click += new System.EventHandler(this.btClear_Click);
      // 
      // lblAction
      // 
      this.lblAction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblAction.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAction.Location = new System.Drawing.Point(64, 17);
      this.lblAction.Name = "lblAction";
      this.lblAction.Size = new System.Drawing.Size(224, 20);
      this.lblAction.TabIndex = 1;
      this.lblAction.Text = "...";
      // 
      // btAssign
      // 
      this.btAssign.Location = new System.Drawing.Point(9, 103);
      this.btAssign.Name = "btAssign";
      this.btAssign.Size = new System.Drawing.Size(73, 25);
      this.btAssign.TabIndex = 15;
      this.btAssign.Text = "Assign";
      this.btAssign.UseVisualStyleBackColor = true;
      this.btAssign.Click += new System.EventHandler(this.btAssign_Click);
      // 
      // treeView1
      // 
      this.treeView1.ContextMenuStrip = this.cmAddDel;
      this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeView1.FullRowSelect = true;
      this.treeView1.HotTracking = true;
      this.treeView1.ImageKey = "Map";
      this.treeView1.ImageList = this.IL;
      this.treeView1.Location = new System.Drawing.Point(6, 81);
      this.treeView1.Name = "treeView1";
      this.tlpanel.SetRowSpan(this.treeView1, 2);
      this.treeView1.SelectedImageKey = "Selected";
      this.treeView1.Size = new System.Drawing.Size(364, 686);
      this.treeView1.TabIndex = 16;
      this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
      // 
      // cmAddDel
      // 
      this.cmAddDel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tdiCollapseAll,
            this.tdiExpandAll,
            this.tdiSGroup1,
            this.tdiAssignBinding,
            this.tdiBlendBinding,
            this.tdiClearBinding,
            this.tdiSGroup2,
            this.tdiAddBinding,
            this.tdiDelBinding,
            this.tdiSGroup3,
            this.tdiTxDefActivationMode,
            this.tdiCbxActivation,
            this.tdiSGroup4,
            this.tdiAddMod1,
            this.tdiAddMod2,
            this.tdiAddMod3});
      this.cmAddDel.Name = "cmAddDel";
      this.cmAddDel.Size = new System.Drawing.Size(221, 457);
      this.cmAddDel.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cmAddDel_Closed);
      this.cmAddDel.Opening += new System.ComponentModel.CancelEventHandler(this.cmAddDel_Opening);
      // 
      // tdiCollapseAll
      // 
      this.tdiCollapseAll.ForeColor = System.Drawing.Color.MediumBlue;
      this.tdiCollapseAll.Name = "tdiCollapseAll";
      this.tdiCollapseAll.Size = new System.Drawing.Size(220, 22);
      this.tdiCollapseAll.Text = "Collapse to selected";
      this.tdiCollapseAll.Click += new System.EventHandler(this.tdiCollapseAll_Click);
      // 
      // tdiExpandAll
      // 
      this.tdiExpandAll.ForeColor = System.Drawing.Color.MediumBlue;
      this.tdiExpandAll.Name = "tdiExpandAll";
      this.tdiExpandAll.Size = new System.Drawing.Size(220, 22);
      this.tdiExpandAll.Text = "Expand all Mappings";
      this.tdiExpandAll.Click += new System.EventHandler(this.tdiExpandAll_Click);
      // 
      // tdiSGroup1
      // 
      this.tdiSGroup1.Name = "tdiSGroup1";
      this.tdiSGroup1.Size = new System.Drawing.Size(217, 6);
      // 
      // tdiAssignBinding
      // 
      this.tdiAssignBinding.Name = "tdiAssignBinding";
      this.tdiAssignBinding.Size = new System.Drawing.Size(220, 22);
      this.tdiAssignBinding.Text = "Assign Mapping";
      this.tdiAssignBinding.Click += new System.EventHandler(this.tdiAssignBinding_Click);
      // 
      // tdiBlendBinding
      // 
      this.tdiBlendBinding.Name = "tdiBlendBinding";
      this.tdiBlendBinding.Size = new System.Drawing.Size(220, 22);
      this.tdiBlendBinding.Text = "Disable Mapping";
      this.tdiBlendBinding.Click += new System.EventHandler(this.tdiBlendBinding_Click);
      // 
      // tdiClearBinding
      // 
      this.tdiClearBinding.Name = "tdiClearBinding";
      this.tdiClearBinding.Size = new System.Drawing.Size(220, 22);
      this.tdiClearBinding.Text = "Clear Mapping";
      this.tdiClearBinding.Click += new System.EventHandler(this.tdiClearBinding_Click);
      // 
      // tdiSGroup2
      // 
      this.tdiSGroup2.Name = "tdiSGroup2";
      this.tdiSGroup2.Size = new System.Drawing.Size(217, 6);
      // 
      // tdiAddBinding
      // 
      this.tdiAddBinding.Name = "tdiAddBinding";
      this.tdiAddBinding.Size = new System.Drawing.Size(220, 22);
      this.tdiAddBinding.Text = "Add Mapping";
      this.tdiAddBinding.Click += new System.EventHandler(this.tsiAddBinding_Click);
      // 
      // tdiDelBinding
      // 
      this.tdiDelBinding.Name = "tdiDelBinding";
      this.tdiDelBinding.Size = new System.Drawing.Size(220, 22);
      this.tdiDelBinding.Text = "Delete Mapping";
      this.tdiDelBinding.Click += new System.EventHandler(this.tdiDelBinding_Click);
      // 
      // tdiSGroup3
      // 
      this.tdiSGroup3.Name = "tdiSGroup3";
      this.tdiSGroup3.Size = new System.Drawing.Size(217, 6);
      // 
      // tdiTxDefActivationMode
      // 
      this.tdiTxDefActivationMode.BackColor = System.Drawing.Color.PapayaWhip;
      this.tdiTxDefActivationMode.Name = "tdiTxDefActivationMode";
      this.tdiTxDefActivationMode.ReadOnly = true;
      this.tdiTxDefActivationMode.Size = new System.Drawing.Size(160, 23);
      this.tdiTxDefActivationMode.Text = "Default ActMode";
      // 
      // tdiCbxActivation
      // 
      this.tdiCbxActivation.AutoSize = false;
      this.tdiCbxActivation.DropDownHeight = 140;
      this.tdiCbxActivation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
      this.tdiCbxActivation.DropDownWidth = 160;
      this.tdiCbxActivation.IntegralHeight = false;
      this.tdiCbxActivation.Items.AddRange(new object[] {
            "None"});
      this.tdiCbxActivation.MaxDropDownItems = 10;
      this.tdiCbxActivation.Name = "tdiCbxActivation";
      this.tdiCbxActivation.Size = new System.Drawing.Size(160, 180);
      this.tdiCbxActivation.Click += new System.EventHandler(this.tdiCbxActivation_Click);
      // 
      // tdiSGroup4
      // 
      this.tdiSGroup4.Name = "tdiSGroup4";
      this.tdiSGroup4.Size = new System.Drawing.Size(217, 6);
      // 
      // tdiAddMod1
      // 
      this.tdiAddMod1.Name = "tdiAddMod1";
      this.tdiAddMod1.Size = new System.Drawing.Size(220, 22);
      this.tdiAddMod1.Tag = "0";
      this.tdiAddMod1.Text = "Mod:";
      this.tdiAddMod1.Visible = false;
      this.tdiAddMod1.Click += new System.EventHandler(this.tdiAddMod_Click);
      // 
      // tdiAddMod2
      // 
      this.tdiAddMod2.Name = "tdiAddMod2";
      this.tdiAddMod2.Size = new System.Drawing.Size(220, 22);
      this.tdiAddMod2.Tag = "1";
      this.tdiAddMod2.Text = "Mod:";
      this.tdiAddMod2.Visible = false;
      this.tdiAddMod2.Click += new System.EventHandler(this.tdiAddMod_Click);
      // 
      // tdiAddMod3
      // 
      this.tdiAddMod3.Name = "tdiAddMod3";
      this.tdiAddMod3.Size = new System.Drawing.Size(220, 22);
      this.tdiAddMod3.Tag = "2";
      this.tdiAddMod3.Text = "Mod:";
      this.tdiAddMod3.Visible = false;
      this.tdiAddMod3.Click += new System.EventHandler(this.tdiAddMod_Click);
      // 
      // tc1
      // 
      this.tc1.Controls.Add(this.tabJS1);
      this.tc1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
      this.tc1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tc1.HotTrack = true;
      this.tc1.ItemSize = new System.Drawing.Size(62, 20);
      this.tc1.Location = new System.Drawing.Point(3, 3);
      this.tc1.Multiline = true;
      this.tc1.Name = "tc1";
      this.tc1.SelectedIndex = 0;
      this.tc1.ShowToolTips = true;
      this.tc1.Size = new System.Drawing.Size(298, 370);
      this.tc1.TabIndex = 15;
      this.tc1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tc1_DrawItem);
      this.tc1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tc1_Selected);
      // 
      // tabJS1
      // 
      this.tabJS1.Controls.Add(this.UC_JoyPanel);
      this.tabJS1.Location = new System.Drawing.Point(4, 24);
      this.tabJS1.Name = "tabJS1";
      this.tabJS1.Padding = new System.Windows.Forms.Padding(3);
      this.tabJS1.Size = new System.Drawing.Size(290, 342);
      this.tabJS1.TabIndex = 0;
      this.tabJS1.Text = "Joystick 1";
      // 
      // panel1
      // 
      this.tlpanel.SetColumnSpan(this.panel1, 3);
      this.panel1.Controls.Add(this.btClip);
      this.panel1.Controls.Add(this.txRebind);
      this.panel1.Controls.Add(this.linkLblReleases);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.lblTitle);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(6, 6);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1042, 66);
      this.panel1.TabIndex = 14;
      // 
      // btClip
      // 
      this.btClip.Image = global::SCJMapper_V2.Properties.Resources.Notes;
      this.btClip.Location = new System.Drawing.Point(984, 8);
      this.btClip.Name = "btClip";
      this.btClip.Size = new System.Drawing.Size(52, 55);
      this.btClip.TabIndex = 55;
      this.btClip.UseVisualStyleBackColor = true;
      this.btClip.Click += new System.EventHandler(this.btClip_Click);
      // 
      // txRebind
      // 
      this.txRebind.Location = new System.Drawing.Point(603, 39);
      this.txRebind.Name = "txRebind";
      this.txRebind.Size = new System.Drawing.Size(361, 22);
      this.txRebind.TabIndex = 4;
      this.txRebind.Text = "pp_rebindkeys";
      // 
      // linkLblReleases
      // 
      this.linkLblReleases.AutoSize = true;
      this.linkLblReleases.Location = new System.Drawing.Point(672, 17);
      this.linkLblReleases.Name = "linkLblReleases";
      this.linkLblReleases.Size = new System.Drawing.Size(259, 13);
      this.linkLblReleases.TabIndex = 3;
      this.linkLblReleases.TabStop = true;
      this.linkLblReleases.Text = "For information and updates visit us @ Github ...";
      this.linkLblReleases.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblReleases_LinkClicked);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(353, 42);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(58, 13);
      this.label8.TabIndex = 2;
      this.label8.Text = "by Cassini";
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.Location = new System.Drawing.Point(226, 8);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(185, 25);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "SC Joystick Mapper";
      // 
      // label4
      // 
      this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
      this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label4.Location = new System.Drawing.Point(0, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(220, 66);
      this.label4.TabIndex = 0;
      // 
      // buttonExit
      // 
      this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonExit.Location = new System.Drawing.Point(181, 51);
      this.buttonExit.Name = "buttonExit";
      this.buttonExit.Size = new System.Drawing.Size(120, 24);
      this.buttonExit.TabIndex = 13;
      this.buttonExit.Text = "Exit";
      this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
      // 
      // OFD
      // 
      this.OFD.DefaultExt = "xml";
      this.OFD.FileName = "Open Map File";
      this.OFD.Filter = "Mapping files|*.xml|All files|*.*";
      this.OFD.ReadOnlyChecked = true;
      this.OFD.SupportMultiDottedExtensions = true;
      // 
      // timer1
      // 
      this.timer1.Interval = 150;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // SFD
      // 
      this.SFD.DefaultExt = "xml";
      this.SFD.Filter = "Mapping files|*.xml|Text files|*.txt|All files|*.*";
      this.SFD.SupportMultiDottedExtensions = true;
      // 
      // tlpanel
      // 
      this.tlpanel.ColumnCount = 3;
      this.tlpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370F));
      this.tlpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
      this.tlpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpanel.Controls.Add(this.rtb, 2, 1);
      this.tlpanel.Controls.Add(this.panel1, 0, 0);
      this.tlpanel.Controls.Add(this.treeView1, 0, 1);
      this.tlpanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
      this.tlpanel.Controls.Add(this.tableLayoutPanel2, 1, 3);
      this.tlpanel.Controls.Add(this.tableLayoutPanel3, 2, 3);
      this.tlpanel.Controls.Add(this.flowLayoutPanel2, 0, 3);
      this.tlpanel.Controls.Add(this.tableLayoutPanel4, 1, 1);
      this.tlpanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tlpanel.Location = new System.Drawing.Point(0, 0);
      this.tlpanel.Name = "tlpanel";
      this.tlpanel.Padding = new System.Windows.Forms.Padding(3);
      this.tlpanel.RowCount = 5;
      this.tlpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
      this.tlpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
      this.tlpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
      this.tlpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tlpanel.Size = new System.Drawing.Size(1054, 892);
      this.tlpanel.TabIndex = 25;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.btOptions, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.btGrab, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.btDump, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btDumpList, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.btDumpLog, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.btJSTuning, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.btDumpProfile, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.btTable, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(376, 648);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 119);
      this.tableLayoutPanel1.TabIndex = 23;
      // 
      // btOptions
      // 
      this.btOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btOptions.Location = new System.Drawing.Point(181, 63);
      this.btOptions.Name = "btOptions";
      this.btOptions.Size = new System.Drawing.Size(120, 23);
      this.btOptions.TabIndex = 28;
      this.btOptions.Text = "Options...";
      this.btOptions.Click += new System.EventHandler(this.btOptions_Click);
      // 
      // btDumpLog
      // 
      this.btDumpLog.Location = new System.Drawing.Point(3, 63);
      this.btDumpLog.Name = "btDumpLog";
      this.btDumpLog.Size = new System.Drawing.Size(120, 24);
      this.btDumpLog.TabIndex = 25;
      this.btDumpLog.Text = "Dump Log-->";
      this.btDumpLog.UseVisualStyleBackColor = true;
      this.btDumpLog.Click += new System.EventHandler(this.btDumpLog_Click);
      // 
      // btJSTuning
      // 
      this.btJSTuning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btJSTuning.Location = new System.Drawing.Point(181, 93);
      this.btJSTuning.Name = "btJSTuning";
      this.btJSTuning.Size = new System.Drawing.Size(120, 23);
      this.btJSTuning.TabIndex = 17;
      this.btJSTuning.Text = "Device Tuning...";
      this.btJSTuning.Click += new System.EventHandler(this.btJSTuning_Click);
      // 
      // btDumpProfile
      // 
      this.btDumpProfile.Location = new System.Drawing.Point(3, 93);
      this.btDumpProfile.Name = "btDumpProfile";
      this.btDumpProfile.Size = new System.Drawing.Size(120, 23);
      this.btDumpProfile.TabIndex = 26;
      this.btDumpProfile.Text = "Dump Profile -->";
      this.btDumpProfile.UseVisualStyleBackColor = true;
      this.btDumpProfile.Click += new System.EventHandler(this.btDumpProfile_Click);
      // 
      // btTable
      // 
      this.btTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btTable.Location = new System.Drawing.Point(181, 33);
      this.btTable.Name = "btTable";
      this.btTable.Size = new System.Drawing.Size(120, 24);
      this.btTable.TabIndex = 27;
      this.btTable.Text = "Toggle Table...";
      this.btTable.UseVisualStyleBackColor = true;
      this.btTable.Click += new System.EventHandler(this.btTable_Click);
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.btMakeMod, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.buttonExit, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.btSettings, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.btJsReassign, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(376, 773);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(304, 78);
      this.tableLayoutPanel2.TabIndex = 24;
      // 
      // btSettings
      // 
      this.btSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btSettings.Location = new System.Drawing.Point(3, 51);
      this.btSettings.Name = "btSettings";
      this.btSettings.Size = new System.Drawing.Size(120, 24);
      this.btSettings.TabIndex = 14;
      this.btSettings.Text = "Settings...";
      this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
      // 
      // btJsReassign
      // 
      this.btJsReassign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btJsReassign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btJsReassign.Location = new System.Drawing.Point(3, 21);
      this.btJsReassign.Name = "btJsReassign";
      this.btJsReassign.Size = new System.Drawing.Size(120, 24);
      this.btJsReassign.TabIndex = 16;
      this.btJsReassign.Text = "Js Reassign...";
      this.btJsReassign.Click += new System.EventHandler(this.btJsReassign_Click);
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
      this.tableLayoutPanel3.Controls.Add(this.btSaveMyMapping, 1, 1);
      this.tableLayoutPanel3.Controls.Add(this.txMappingName, 1, 0);
      this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.lblPTU, 0, 1);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(686, 773);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(362, 78);
      this.tableLayoutPanel3.TabIndex = 25;
      // 
      // btSaveMyMapping
      // 
      this.btSaveMyMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btSaveMyMapping.Image = ((System.Drawing.Image)(resources.GetObject("btSaveMyMapping.Image")));
      this.btSaveMyMapping.Location = new System.Drawing.Point(154, 51);
      this.btSaveMyMapping.Name = "btSaveMyMapping";
      this.btSaveMyMapping.Size = new System.Drawing.Size(205, 24);
      this.btSaveMyMapping.TabIndex = 15;
      this.btSaveMyMapping.Text = "Dump and Save my Mapping";
      this.btSaveMyMapping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btSaveMyMapping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btSaveMyMapping.Click += new System.EventHandler(this.btSaveMyMapping_Click);
      // 
      // txMappingName
      // 
      this.txMappingName.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.txMappingName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
      this.txMappingName.Location = new System.Drawing.Point(125, 13);
      this.txMappingName.Name = "txMappingName";
      this.txMappingName.Size = new System.Drawing.Size(234, 22);
      this.txMappingName.TabIndex = 0;
      this.txMappingName.WordWrap = false;
      this.txMappingName.TextChanged += new System.EventHandler(this.txMappingName_TextChanged);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(31, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(88, 13);
      this.label1.TabIndex = 16;
      this.label1.Text = "Mapping name:";
      // 
      // lblPTU
      // 
      this.lblPTU.BackColor = System.Drawing.Color.SandyBrown;
      this.lblPTU.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblPTU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPTU.Location = new System.Drawing.Point(3, 48);
      this.lblPTU.Name = "lblPTU";
      this.lblPTU.Size = new System.Drawing.Size(116, 30);
      this.lblPTU.TabIndex = 17;
      this.lblPTU.Text = "Using PTU folders";
      this.lblPTU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblPTU.Visible = false;
      // 
      // flowLayoutPanel2
      // 
      this.flowLayoutPanel2.Controls.Add(this.cbxShowJoystick);
      this.flowLayoutPanel2.Controls.Add(this.cbxShowGamepad);
      this.flowLayoutPanel2.Controls.Add(this.cbxShowKeyboard);
      this.flowLayoutPanel2.Controls.Add(this.cbxShowMouse);
      this.flowLayoutPanel2.Controls.Add(this.cbxShowMappedOnly);
      this.flowLayoutPanel2.Controls.Add(this.label2);
      this.flowLayoutPanel2.Controls.Add(this.txFilter);
      this.flowLayoutPanel2.Controls.Add(this.btClearFilter);
      this.flowLayoutPanel2.Controls.Add(this.label3);
      this.flowLayoutPanel2.Controls.Add(this.lblProfileUsed);
      this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 773);
      this.flowLayoutPanel2.Name = "flowLayoutPanel2";
      this.flowLayoutPanel2.Size = new System.Drawing.Size(364, 78);
      this.flowLayoutPanel2.TabIndex = 26;
      // 
      // cbxShowJoystick
      // 
      this.cbxShowJoystick.AutoSize = true;
      this.cbxShowJoystick.Checked = true;
      this.cbxShowJoystick.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbxShowJoystick.Location = new System.Drawing.Point(3, 3);
      this.cbxShowJoystick.Name = "cbxShowJoystick";
      this.cbxShowJoystick.Size = new System.Drawing.Size(65, 17);
      this.cbxShowJoystick.TabIndex = 0;
      this.cbxShowJoystick.Text = "Joystick";
      this.cbxShowJoystick.UseVisualStyleBackColor = true;
      this.cbxShowJoystick.CheckedChanged += new System.EventHandler(this.cbxShowTreeOptions_CheckedChanged);
      // 
      // cbxShowGamepad
      // 
      this.cbxShowGamepad.AutoSize = true;
      this.cbxShowGamepad.Checked = true;
      this.cbxShowGamepad.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbxShowGamepad.Location = new System.Drawing.Point(74, 3);
      this.cbxShowGamepad.Name = "cbxShowGamepad";
      this.cbxShowGamepad.Size = new System.Drawing.Size(75, 17);
      this.cbxShowGamepad.TabIndex = 1;
      this.cbxShowGamepad.Text = "Gamepad";
      this.cbxShowGamepad.UseVisualStyleBackColor = true;
      this.cbxShowGamepad.CheckedChanged += new System.EventHandler(this.cbxShowTreeOptions_CheckedChanged);
      // 
      // cbxShowKeyboard
      // 
      this.cbxShowKeyboard.AutoSize = true;
      this.cbxShowKeyboard.Checked = true;
      this.cbxShowKeyboard.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbxShowKeyboard.Location = new System.Drawing.Point(155, 3);
      this.cbxShowKeyboard.Name = "cbxShowKeyboard";
      this.cbxShowKeyboard.Size = new System.Drawing.Size(53, 17);
      this.cbxShowKeyboard.TabIndex = 1;
      this.cbxShowKeyboard.Text = "Keyb.";
      this.cbxShowKeyboard.UseVisualStyleBackColor = true;
      this.cbxShowKeyboard.CheckedChanged += new System.EventHandler(this.cbxShowTreeOptions_CheckedChanged);
      // 
      // cbxShowMouse
      // 
      this.cbxShowMouse.AutoSize = true;
      this.cbxShowMouse.Location = new System.Drawing.Point(214, 3);
      this.cbxShowMouse.Name = "cbxShowMouse";
      this.cbxShowMouse.Size = new System.Drawing.Size(61, 17);
      this.cbxShowMouse.TabIndex = 28;
      this.cbxShowMouse.Text = "Mouse";
      this.cbxShowMouse.UseVisualStyleBackColor = true;
      this.cbxShowMouse.CheckedChanged += new System.EventHandler(this.cbxShowTreeOptions_CheckedChanged);
      // 
      // cbxShowMappedOnly
      // 
      this.cbxShowMappedOnly.AutoSize = true;
      this.cbxShowMappedOnly.Location = new System.Drawing.Point(281, 3);
      this.cbxShowMappedOnly.Name = "cbxShowMappedOnly";
      this.cbxShowMappedOnly.Size = new System.Drawing.Size(69, 17);
      this.cbxShowMappedOnly.TabIndex = 1;
      this.cbxShowMappedOnly.Text = "Mapped";
      this.cbxShowMappedOnly.UseVisualStyleBackColor = true;
      this.cbxShowMappedOnly.CheckedChanged += new System.EventHandler(this.cbxShowTreeOptions_CheckedChanged);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(3, 26);
      this.label2.Margin = new System.Windows.Forms.Padding(3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 24);
      this.label2.TabIndex = 27;
      this.label2.Text = "Action Filter:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txFilter
      // 
      this.txFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.txFilter.Location = new System.Drawing.Point(92, 28);
      this.txFilter.Name = "txFilter";
      this.txFilter.Size = new System.Drawing.Size(120, 22);
      this.txFilter.TabIndex = 25;
      this.txFilter.WordWrap = false;
      this.txFilter.TextChanged += new System.EventHandler(this.txFilter_TextChanged);
      // 
      // btClearFilter
      // 
      this.btClearFilter.Location = new System.Drawing.Point(218, 26);
      this.btClearFilter.Name = "btClearFilter";
      this.btClearFilter.Size = new System.Drawing.Size(120, 24);
      this.btClearFilter.TabIndex = 26;
      this.btClearFilter.Text = "Clear Filter";
      this.btClearFilter.UseVisualStyleBackColor = true;
      this.btClearFilter.Click += new System.EventHandler(this.btClearFilter_Click);
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(3, 56);
      this.label3.Margin = new System.Windows.Forms.Padding(3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(39, 19);
      this.label3.TabIndex = 30;
      this.label3.Text = "Profile:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblProfileUsed
      // 
      this.lblProfileUsed.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblProfileUsed.Location = new System.Drawing.Point(48, 56);
      this.lblProfileUsed.Margin = new System.Windows.Forms.Padding(3);
      this.lblProfileUsed.Name = "lblProfileUsed";
      this.lblProfileUsed.Size = new System.Drawing.Size(302, 19);
      this.lblProfileUsed.TabIndex = 29;
      this.lblProfileUsed.Text = "...";
      this.lblProfileUsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 1;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.tc1, 0, 0);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(376, 81);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 2;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(304, 549);
      this.tableLayoutPanel4.TabIndex = 28;
      // 
      // toolStripStatusLabel2
      // 
      this.toolStripStatusLabel2.BackColor = System.Drawing.Color.DarkKhaki;
      this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
      this.toolStripStatusLabel2.Size = new System.Drawing.Size(52, 25);
      this.toolStripStatusLabel2.Text = "Profiles:";
      // 
      // tsBtReset
      // 
      this.tsBtReset.AutoSize = false;
      this.tsBtReset.BackColor = System.Drawing.Color.DarkKhaki;
      this.tsBtReset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetDefaultsToolStripMenuItem,
            this.resetEmptyToolStripMenuItem});
      this.tsBtReset.Image = ((System.Drawing.Image)(resources.GetObject("tsBtReset.Image")));
      this.tsBtReset.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsBtReset.Name = "tsBtReset";
      this.tsBtReset.Size = new System.Drawing.Size(100, 28);
      this.tsBtReset.Text = "Reset...";
      this.tsBtReset.ToolTipText = "Reset with chosen options";
      // 
      // resetDefaultsToolStripMenuItem
      // 
      this.resetDefaultsToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
      this.resetDefaultsToolStripMenuItem.Name = "resetDefaultsToolStripMenuItem";
      this.resetDefaultsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
      this.resetDefaultsToolStripMenuItem.Text = "Reset defaults !";
      this.resetDefaultsToolStripMenuItem.Click += new System.EventHandler(this.resetDefaultsToolStripMenuItem_Click);
      // 
      // resetEmptyToolStripMenuItem
      // 
      this.resetEmptyToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
      this.resetEmptyToolStripMenuItem.Name = "resetEmptyToolStripMenuItem";
      this.resetEmptyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
      this.resetEmptyToolStripMenuItem.Text = "Reset empty !";
      this.resetEmptyToolStripMenuItem.Click += new System.EventHandler(this.resetEmptyToolStripMenuItem_Click);
      // 
      // toolStripStatusLabel3
      // 
      this.toolStripStatusLabel3.AutoSize = false;
      this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
      this.toolStripStatusLabel3.Size = new System.Drawing.Size(450, 25);
      this.toolStripStatusLabel3.Text = "            Support: profile version=\"1\" optionsVersion=\"2\" rebindVersion=\"2\"    " +
    "                    ";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 25);
      this.toolStripStatusLabel1.Text = "Mappings:";
      // 
      // tsDDbtMappings
      // 
      this.tsDDbtMappings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.tsDDbtMappings.AutoSize = false;
      this.tsDDbtMappings.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.tsDDbtMappings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsDDbtMappings.Image = ((System.Drawing.Image)(resources.GetObject("tsDDbtMappings.Image")));
      this.tsDDbtMappings.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsDDbtMappings.Name = "tsDDbtMappings";
      this.tsDDbtMappings.Size = new System.Drawing.Size(250, 28);
      this.tsDDbtMappings.Text = "Available Mappings";
      this.tsDDbtMappings.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsDDbtMappings_DropDownItemClicked);
      // 
      // tsBtLoad
      // 
      this.tsBtLoad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.tsBtLoad.AutoSize = false;
      this.tsBtLoad.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.tsBtLoad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultsLoadAndGrabToolStripMenuItem,
            this.resetLoadAndGrabToolStripMenuItem,
            this.loadAndGrabToolStripMenuItem,
            this.loadToolStripMenuItem});
      this.tsBtLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsBtLoad.Image")));
      this.tsBtLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsBtLoad.Name = "tsBtLoad";
      this.tsBtLoad.Size = new System.Drawing.Size(80, 28);
      this.tsBtLoad.Text = "Load...";
      // 
      // defaultsLoadAndGrabToolStripMenuItem
      // 
      this.defaultsLoadAndGrabToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.defaultsLoadAndGrabToolStripMenuItem.Name = "defaultsLoadAndGrabToolStripMenuItem";
      this.defaultsLoadAndGrabToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.defaultsLoadAndGrabToolStripMenuItem.Text = "Defaults, Load and Grab !";
      this.defaultsLoadAndGrabToolStripMenuItem.Click += new System.EventHandler(this.defaultsLoadAndGrabToolStripMenuItem_Click);
      // 
      // resetLoadAndGrabToolStripMenuItem
      // 
      this.resetLoadAndGrabToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.resetLoadAndGrabToolStripMenuItem.Name = "resetLoadAndGrabToolStripMenuItem";
      this.resetLoadAndGrabToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.resetLoadAndGrabToolStripMenuItem.Text = "Reset, Load and Grab !";
      this.resetLoadAndGrabToolStripMenuItem.Click += new System.EventHandler(this.resetLoadAndGrabToolStripMenuItem_Click);
      // 
      // loadAndGrabToolStripMenuItem
      // 
      this.loadAndGrabToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.loadAndGrabToolStripMenuItem.Name = "loadAndGrabToolStripMenuItem";
      this.loadAndGrabToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.loadAndGrabToolStripMenuItem.Text = "Load and Grab !";
      this.loadAndGrabToolStripMenuItem.Click += new System.EventHandler(this.loadAndGrabToolStripMenuItem_Click);
      // 
      // loadToolStripMenuItem
      // 
      this.loadToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
      this.loadToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.loadToolStripMenuItem.Text = "Load !";
      this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.tsBtReset,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.tsDDbtMappings,
            this.tsBtLoad});
      this.statusStrip1.Location = new System.Drawing.Point(0, 862);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.statusStrip1.ShowItemToolTips = true;
      this.statusStrip1.Size = new System.Drawing.Size(1054, 30);
      this.statusStrip1.TabIndex = 26;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(4, 41);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(54, 13);
      this.label5.TabIndex = 18;
      this.label5.Text = "Mapping";
      // 
      // lblAssigned
      // 
      this.lblAssigned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblAssigned.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAssigned.Location = new System.Drawing.Point(64, 40);
      this.lblAssigned.Name = "lblAssigned";
      this.lblAssigned.Size = new System.Drawing.Size(224, 20);
      this.lblAssigned.TabIndex = 17;
      this.lblAssigned.Text = "...";
      // 
      // UC_JoyPanel
      // 
      this.UC_JoyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UC_JoyPanel.JsAssignment = 0;
      this.UC_JoyPanel.Location = new System.Drawing.Point(3, 3);
      this.UC_JoyPanel.Name = "UC_JoyPanel";
      this.UC_JoyPanel.Size = new System.Drawing.Size(284, 336);
      this.UC_JoyPanel.TabIndex = 0;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1054, 892);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.tlpanel);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(1070, 930);
      this.Name = "MainForm";
      this.Text = "SC Joystick Mapper";
      this.Activated += new System.EventHandler(this.MainForm_Activated);
      this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.cmCopyPaste.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.cmMouseEntry.ResumeLayout(false);
      this.cmAddDel.ResumeLayout(false);
      this.cmAddDel.PerformLayout();
      this.tc1.ResumeLayout(false);
      this.tabJS1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tlpanel.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.flowLayoutPanel2.ResumeLayout(false);
      this.flowLayoutPanel2.PerformLayout();
      this.tableLayoutPanel4.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btDumpList;
    private System.Windows.Forms.RichTextBox rtb;
    private System.Windows.Forms.Button btGrab;
    private System.Windows.Forms.Button btDump;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btFind;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btClear;
    private System.Windows.Forms.Label lblAction;
    private System.Windows.Forms.Button btAssign;
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.TabControl tc1;
    private System.Windows.Forms.TabPage tabJS1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button buttonExit;
    private System.Windows.Forms.OpenFileDialog OFD;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.ContextMenuStrip cmCopyPaste;
    private System.Windows.Forms.ToolStripMenuItem tsiCopy;
    private System.Windows.Forms.ToolStripMenuItem tsiPaste;
    private System.Windows.Forms.ToolStripMenuItem tsiPReplace;
    private System.Windows.Forms.ToolStripMenuItem tsiSelAll;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem tsiOpen;
    private System.Windows.Forms.ToolStripMenuItem tsiSaveAs;
    private System.Windows.Forms.SaveFileDialog SFD;
    private System.Windows.Forms.ImageList IL;
    private Joystick.UC_JoyPanel UC_JoyPanel;
    private System.Windows.Forms.TableLayoutPanel tlpanel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.ToolStripDropDownButton tsDDbtMappings;
    private System.Windows.Forms.ToolStripDropDownButton tsBtReset;
    private System.Windows.Forms.ToolStripMenuItem resetDefaultsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resetEmptyToolStripMenuItem;
    private System.Windows.Forms.ToolStripDropDownButton tsBtLoad;
    private System.Windows.Forms.ToolStripMenuItem loadAndGrabToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resetLoadAndGrabToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem defaultsLoadAndGrabToolStripMenuItem;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    private System.Windows.Forms.Button btClearFilter;
    private System.Windows.Forms.TextBox txFilter;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Button btSaveMyMapping;
    private System.Windows.Forms.TextBox txMappingName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.LinkLabel linkLblReleases;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.CheckBox cbxThrottle;
    private System.Windows.Forms.TextBox txRebind;
    private System.Windows.Forms.Button btSettings;
    private System.Windows.Forms.Button btJsReassign;
    private System.Windows.Forms.Button btJSTuning;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.TextBox lblLastJ;
    private System.Windows.Forms.Button btJsKbd;
    private System.Windows.Forms.Button btBlend;
    private System.Windows.Forms.Button btClip;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.CheckBox cbxShowJoystick;
    private System.Windows.Forms.CheckBox cbxShowGamepad;
    private System.Windows.Forms.CheckBox cbxShowKeyboard;
    private System.Windows.Forms.CheckBox cbxShowMappedOnly;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ContextMenuStrip cmAddDel;
    private System.Windows.Forms.ToolStripMenuItem tdiAddBinding;
    private System.Windows.Forms.ToolStripMenuItem tdiDelBinding;
    private System.Windows.Forms.Button btDumpLog;
    private System.Windows.Forms.ToolStripSeparator tdiSGroup2;
    private System.Windows.Forms.ToolStripMenuItem tdiBlendBinding;
    private System.Windows.Forms.ToolStripMenuItem tdiClearBinding;
    private System.Windows.Forms.ToolStripMenuItem tdiAssignBinding;
    private System.Windows.Forms.CheckBox cbxShowMouse;
    private System.Windows.Forms.ContextMenuStrip cmMouseEntry;
    private System.Windows.Forms.ToolStripMenuItem tmeXAxis;
    private System.Windows.Forms.ToolStripMenuItem tmeYAxis;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem tmeWUp;
    private System.Windows.Forms.ToolStripMenuItem tmeWDown;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripSeparator tdiSGroup3;
    private System.Windows.Forms.ToolStripMenuItem tdiAddMod1;
    private System.Windows.Forms.ToolStripMenuItem tdiAddMod2;
    private System.Windows.Forms.ToolStripMenuItem tdiAddMod3;
    private System.Windows.Forms.Button btMakeMod;
    private System.Windows.Forms.Label lblPTU;
    private System.Windows.Forms.ToolStripComboBox tdiCbxActivation;
    private System.Windows.Forms.ToolStripSeparator tdiSGroup4;
    private System.Windows.Forms.ToolStripTextBox tdiTxDefActivationMode;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblProfileUsed;
    private System.Windows.Forms.ToolStripMenuItem tmeK_Tab;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Button btDumpProfile;
    private System.Windows.Forms.Button btTable;
    private System.Windows.Forms.ToolStripMenuItem tdiCollapseAll;
    private System.Windows.Forms.ToolStripMenuItem tdiExpandAll;
    private System.Windows.Forms.ToolStripSeparator tdiSGroup1;
    private System.Windows.Forms.Button btOptions;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblAssigned;
  }
}

