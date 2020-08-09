namespace SerialComTESTProgram
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnComPortOpen = new System.Windows.Forms.Button();
            this.btnComPortClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.cbSTX = new System.Windows.Forms.CheckBox();
            this.cbCR = new System.Windows.Forms.CheckBox();
            this.cbLF = new System.Windows.Forms.CheckBox();
            this.cbETX = new System.Windows.Forms.CheckBox();
            this.btnTextClear = new System.Windows.Forms.Button();
            this.cbCommand = new System.Windows.Forms.ComboBox();
            this.btnContinueSend = new System.Windows.Forms.Button();
            this.tbSendMessage = new System.Windows.Forms.RichTextBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lbCommand = new System.Windows.Forms.Label();
            this.lbPortName = new System.Windows.Forms.Label();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.lbDataBit = new System.Windows.Forms.Label();
            this.lbParityBit = new System.Windows.Forms.Label();
            this.lbStopBit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReceiveMessage = new System.Windows.Forms.RichTextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPortNum = new System.Windows.Forms.Label();
            this.rbSerial = new System.Windows.Forms.RadioButton();
            this.rbTCP = new System.Windows.Forms.RadioButton();
            this.btnCheckSum = new System.Windows.Forms.Button();
            this.tableLayoutSerial = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutCommand = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutMode = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutTCP = new System.Windows.Forms.TableLayoutPanel();
            this.btnTCPDisconnect = new System.Windows.Forms.Button();
            this.btnTCPConnect = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutSerial.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutCommand.SuspendLayout();
            this.tableLayoutMode.SuspendLayout();
            this.tableLayoutTCP.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "ComPort";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "BaudRate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(4, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "DataBit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(4, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(4, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "StopBit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnComPortOpen
            // 
            this.btnComPortOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnComPortOpen.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnComPortOpen.Location = new System.Drawing.Point(185, 1);
            this.btnComPortOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnComPortOpen.Name = "btnComPortOpen";
            this.btnComPortOpen.Size = new System.Drawing.Size(124, 27);
            this.btnComPortOpen.TabIndex = 10;
            this.btnComPortOpen.Text = "OPEN";
            this.btnComPortOpen.UseVisualStyleBackColor = true;
            this.btnComPortOpen.Click += new System.EventHandler(this.btnComPortOpen_Click);
            // 
            // btnComPortClose
            // 
            this.btnComPortClose.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnComPortClose.Location = new System.Drawing.Point(185, 29);
            this.btnComPortClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnComPortClose.Name = "btnComPortClose";
            this.btnComPortClose.Size = new System.Drawing.Size(124, 27);
            this.btnComPortClose.TabIndex = 11;
            this.btnComPortClose.Text = "CLOSE";
            this.btnComPortClose.UseVisualStyleBackColor = true;
            this.btnComPortClose.Click += new System.EventHandler(this.btnComPortClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSend.Location = new System.Drawing.Point(0, 0);
            this.btnSend.Margin = new System.Windows.Forms.Padding(0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(124, 30);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbCommand
            // 
            this.tbCommand.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbCommand.Location = new System.Drawing.Point(3, 3);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(273, 22);
            this.tbCommand.TabIndex = 13;
            this.tbCommand.TextChanged += new System.EventHandler(this.TbCommand_TextChanged);
            // 
            // cbSTX
            // 
            this.cbSTX.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbSTX.Location = new System.Drawing.Point(282, 3);
            this.cbSTX.Name = "cbSTX";
            this.cbSTX.Size = new System.Drawing.Size(49, 23);
            this.cbSTX.TabIndex = 15;
            this.cbSTX.Text = "STX";
            this.cbSTX.UseVisualStyleBackColor = true;
            this.cbSTX.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // cbCR
            // 
            this.cbCR.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCR.Location = new System.Drawing.Point(392, 3);
            this.cbCR.Name = "cbCR";
            this.cbCR.Size = new System.Drawing.Size(49, 23);
            this.cbCR.TabIndex = 16;
            this.cbCR.Text = "CR";
            this.cbCR.UseVisualStyleBackColor = true;
            this.cbCR.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // cbLF
            // 
            this.cbLF.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbLF.Location = new System.Drawing.Point(447, 3);
            this.cbLF.Name = "cbLF";
            this.cbLF.Size = new System.Drawing.Size(49, 23);
            this.cbLF.TabIndex = 17;
            this.cbLF.Text = "LF";
            this.cbLF.UseVisualStyleBackColor = true;
            this.cbLF.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // cbETX
            // 
            this.cbETX.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbETX.Location = new System.Drawing.Point(337, 3);
            this.cbETX.Name = "cbETX";
            this.cbETX.Size = new System.Drawing.Size(49, 23);
            this.cbETX.TabIndex = 18;
            this.cbETX.Text = "ETX";
            this.cbETX.UseVisualStyleBackColor = true;
            this.cbETX.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // btnTextClear
            // 
            this.btnTextClear.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTextClear.Location = new System.Drawing.Point(248, 0);
            this.btnTextClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnTextClear.Name = "btnTextClear";
            this.btnTextClear.Size = new System.Drawing.Size(124, 30);
            this.btnTextClear.TabIndex = 19;
            this.btnTextClear.Text = "TEXT CLEAR";
            this.btnTextClear.UseVisualStyleBackColor = true;
            this.btnTextClear.Click += new System.EventHandler(this.btnTextClear_Click);
            // 
            // cbCommand
            // 
            this.cbCommand.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCommand.FormattingEnabled = true;
            this.cbCommand.Location = new System.Drawing.Point(502, 3);
            this.cbCommand.Name = "cbCommand";
            this.cbCommand.Size = new System.Drawing.Size(117, 21);
            this.cbCommand.TabIndex = 20;
            this.cbCommand.SelectedIndexChanged += new System.EventHandler(this.cbOption_SelectedIndexChanged);
            // 
            // btnContinueSend
            // 
            this.btnContinueSend.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnContinueSend.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnContinueSend.Location = new System.Drawing.Point(124, 0);
            this.btnContinueSend.Margin = new System.Windows.Forms.Padding(0);
            this.btnContinueSend.Name = "btnContinueSend";
            this.btnContinueSend.Size = new System.Drawing.Size(124, 30);
            this.btnContinueSend.TabIndex = 21;
            this.btnContinueSend.Text = "REPEAT SEND";
            this.btnContinueSend.UseVisualStyleBackColor = true;
            this.btnContinueSend.Click += new System.EventHandler(this.btnContinueSend_Click);
            // 
            // tbSendMessage
            // 
            this.tbSendMessage.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSendMessage.Location = new System.Drawing.Point(4, 28);
            this.tbSendMessage.Name = "tbSendMessage";
            this.tbSendMessage.Size = new System.Drawing.Size(307, 208);
            this.tbSendMessage.TabIndex = 22;
            this.tbSendMessage.Text = "";
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetting.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetting.Location = new System.Drawing.Point(496, 0);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(126, 30);
            this.btnSetting.TabIndex = 23;
            this.btnSetting.Text = "SETTING";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // lbCommand
            // 
            this.lbCommand.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCommand.Location = new System.Drawing.Point(3, 3);
            this.lbCommand.Margin = new System.Windows.Forms.Padding(3);
            this.lbCommand.Name = "lbCommand";
            this.lbCommand.Size = new System.Drawing.Size(491, 23);
            this.lbCommand.TabIndex = 24;
            this.lbCommand.Text = "Command";
            this.lbCommand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPortName
            // 
            this.lbPortName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPortName.Location = new System.Drawing.Point(96, 4);
            this.lbPortName.Margin = new System.Windows.Forms.Padding(3);
            this.lbPortName.Name = "lbPortName";
            this.lbPortName.Size = new System.Drawing.Size(84, 21);
            this.lbPortName.TabIndex = 25;
            this.lbPortName.Text = "COM1";
            this.lbPortName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBaudRate.Location = new System.Drawing.Point(96, 32);
            this.lbBaudRate.Margin = new System.Windows.Forms.Padding(3);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(84, 21);
            this.lbBaudRate.TabIndex = 26;
            this.lbBaudRate.Text = "9600";
            this.lbBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDataBit
            // 
            this.lbDataBit.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDataBit.Location = new System.Drawing.Point(96, 60);
            this.lbDataBit.Margin = new System.Windows.Forms.Padding(3);
            this.lbDataBit.Name = "lbDataBit";
            this.lbDataBit.Size = new System.Drawing.Size(84, 21);
            this.lbDataBit.TabIndex = 27;
            this.lbDataBit.Text = "8";
            this.lbDataBit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbParityBit
            // 
            this.lbParityBit.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbParityBit.Location = new System.Drawing.Point(96, 88);
            this.lbParityBit.Margin = new System.Windows.Forms.Padding(3);
            this.lbParityBit.Name = "lbParityBit";
            this.lbParityBit.Size = new System.Drawing.Size(84, 21);
            this.lbParityBit.TabIndex = 28;
            this.lbParityBit.Text = "NONE";
            this.lbParityBit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStopBit
            // 
            this.lbStopBit.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbStopBit.Location = new System.Drawing.Point(96, 116);
            this.lbStopBit.Margin = new System.Windows.Forms.Padding(3);
            this.lbStopBit.Name = "lbStopBit";
            this.lbStopBit.Size = new System.Drawing.Size(84, 23);
            this.lbStopBit.TabIndex = 29;
            this.lbStopBit.Text = "1";
            this.lbStopBit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Address";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(4, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "PortNum";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbReceiveMessage
            // 
            this.tbReceiveMessage.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbReceiveMessage.Location = new System.Drawing.Point(318, 28);
            this.tbReceiveMessage.Name = "tbReceiveMessage";
            this.tbReceiveMessage.Size = new System.Drawing.Size(308, 208);
            this.tbReceiveMessage.TabIndex = 14;
            this.tbReceiveMessage.Text = "";
            // 
            // lbAddress
            // 
            this.lbAddress.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAddress.Location = new System.Drawing.Point(81, 4);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(3);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(101, 21);
            this.lbAddress.TabIndex = 32;
            this.lbAddress.Text = "100.100.100.1";
            this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPortNum
            // 
            this.lbPortNum.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPortNum.Location = new System.Drawing.Point(81, 32);
            this.lbPortNum.Margin = new System.Windows.Forms.Padding(3);
            this.lbPortNum.Name = "lbPortNum";
            this.lbPortNum.Size = new System.Drawing.Size(101, 21);
            this.lbPortNum.TabIndex = 33;
            this.lbPortNum.Text = "8000";
            this.lbPortNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbSerial
            // 
            this.rbSerial.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbSerial.Location = new System.Drawing.Point(3, 3);
            this.rbSerial.Name = "rbSerial";
            this.rbSerial.Size = new System.Drawing.Size(309, 19);
            this.rbSerial.TabIndex = 38;
            this.rbSerial.TabStop = true;
            this.rbSerial.Text = "SERIAL";
            this.rbSerial.UseVisualStyleBackColor = true;
            this.rbSerial.CheckedChanged += new System.EventHandler(this.rbSerial_CheckedChanged);
            // 
            // rbTCP
            // 
            this.rbTCP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbTCP.Location = new System.Drawing.Point(318, 3);
            this.rbTCP.Name = "rbTCP";
            this.rbTCP.Size = new System.Drawing.Size(309, 19);
            this.rbTCP.TabIndex = 39;
            this.rbTCP.TabStop = true;
            this.rbTCP.Text = "TCP";
            this.rbTCP.UseVisualStyleBackColor = true;
            this.rbTCP.CheckedChanged += new System.EventHandler(this.rbTCP_CheckedChanged);
            // 
            // btnCheckSum
            // 
            this.btnCheckSum.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckSum.Location = new System.Drawing.Point(372, 0);
            this.btnCheckSum.Margin = new System.Windows.Forms.Padding(0);
            this.btnCheckSum.Name = "btnCheckSum";
            this.btnCheckSum.Size = new System.Drawing.Size(124, 30);
            this.btnCheckSum.TabIndex = 40;
            this.btnCheckSum.Text = "CHECKSUM";
            this.btnCheckSum.UseVisualStyleBackColor = true;
            this.btnCheckSum.Click += new System.EventHandler(this.btnCheckSum_Click);
            // 
            // tableLayoutSerial
            // 
            this.tableLayoutSerial.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutSerial.ColumnCount = 3;
            this.tableLayoutSerial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutSerial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutSerial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutSerial.Controls.Add(this.btnComPortOpen, 2, 0);
            this.tableLayoutSerial.Controls.Add(this.label5, 0, 4);
            this.tableLayoutSerial.Controls.Add(this.label4, 0, 3);
            this.tableLayoutSerial.Controls.Add(this.lbStopBit, 1, 4);
            this.tableLayoutSerial.Controls.Add(this.label3, 0, 2);
            this.tableLayoutSerial.Controls.Add(this.lbParityBit, 1, 3);
            this.tableLayoutSerial.Controls.Add(this.lbDataBit, 1, 2);
            this.tableLayoutSerial.Controls.Add(this.lbPortName, 1, 0);
            this.tableLayoutSerial.Controls.Add(this.lbBaudRate, 1, 1);
            this.tableLayoutSerial.Controls.Add(this.label2, 0, 1);
            this.tableLayoutSerial.Controls.Add(this.label1, 0, 0);
            this.tableLayoutSerial.Controls.Add(this.btnComPortClose, 2, 1);
            this.tableLayoutSerial.Location = new System.Drawing.Point(12, 43);
            this.tableLayoutSerial.Name = "tableLayoutSerial";
            this.tableLayoutSerial.RowCount = 5;
            this.tableLayoutSerial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutSerial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutSerial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutSerial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutSerial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutSerial.Size = new System.Drawing.Size(310, 145);
            this.tableLayoutSerial.TabIndex = 41;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutCommand, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 194);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 110);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.btnSetting, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnContinueSend, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnSend, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnTextClear, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnCheckSum, 3, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 76);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(622, 30);
            this.tableLayoutPanel6.TabIndex = 46;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbCommand, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(622, 29);
            this.tableLayoutPanel4.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(500, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 23);
            this.label10.TabIndex = 47;
            this.label10.Text = "DEVICE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutCommand
            // 
            this.tableLayoutCommand.ColumnCount = 6;
            this.tableLayoutCommand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutCommand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutCommand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutCommand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutCommand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutCommand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutCommand.Controls.Add(this.tbCommand, 0, 0);
            this.tableLayoutCommand.Controls.Add(this.cbCommand, 5, 0);
            this.tableLayoutCommand.Controls.Add(this.cbLF, 4, 0);
            this.tableLayoutCommand.Controls.Add(this.cbCR, 3, 0);
            this.tableLayoutCommand.Controls.Add(this.cbETX, 2, 0);
            this.tableLayoutCommand.Controls.Add(this.cbSTX, 1, 0);
            this.tableLayoutCommand.Location = new System.Drawing.Point(4, 40);
            this.tableLayoutCommand.Name = "tableLayoutCommand";
            this.tableLayoutCommand.RowCount = 1;
            this.tableLayoutCommand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutCommand.Size = new System.Drawing.Size(622, 29);
            this.tableLayoutCommand.TabIndex = 25;
            // 
            // tableLayoutMode
            // 
            this.tableLayoutMode.ColumnCount = 2;
            this.tableLayoutMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMode.Controls.Add(this.rbSerial, 0, 0);
            this.tableLayoutMode.Controls.Add(this.rbTCP, 1, 0);
            this.tableLayoutMode.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutMode.Name = "tableLayoutMode";
            this.tableLayoutMode.RowCount = 1;
            this.tableLayoutMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMode.Size = new System.Drawing.Size(630, 25);
            this.tableLayoutMode.TabIndex = 43;
            // 
            // tableLayoutTCP
            // 
            this.tableLayoutTCP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutTCP.ColumnCount = 3;
            this.tableLayoutTCP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutTCP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutTCP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutTCP.Controls.Add(this.label6, 0, 0);
            this.tableLayoutTCP.Controls.Add(this.label7, 0, 1);
            this.tableLayoutTCP.Controls.Add(this.lbAddress, 1, 0);
            this.tableLayoutTCP.Controls.Add(this.lbPortNum, 1, 1);
            this.tableLayoutTCP.Controls.Add(this.btnTCPDisconnect, 2, 1);
            this.tableLayoutTCP.Controls.Add(this.btnTCPConnect, 2, 0);
            this.tableLayoutTCP.Location = new System.Drawing.Point(332, 43);
            this.tableLayoutTCP.Name = "tableLayoutTCP";
            this.tableLayoutTCP.RowCount = 5;
            this.tableLayoutTCP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutTCP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutTCP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutTCP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutTCP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutTCP.Size = new System.Drawing.Size(310, 145);
            this.tableLayoutTCP.TabIndex = 44;
            // 
            // btnTCPDisconnect
            // 
            this.btnTCPDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTCPDisconnect.Location = new System.Drawing.Point(186, 29);
            this.btnTCPDisconnect.Margin = new System.Windows.Forms.Padding(0);
            this.btnTCPDisconnect.Name = "btnTCPDisconnect";
            this.btnTCPDisconnect.Size = new System.Drawing.Size(123, 27);
            this.btnTCPDisconnect.TabIndex = 35;
            this.btnTCPDisconnect.Text = "DISCONNECT";
            this.btnTCPDisconnect.UseVisualStyleBackColor = true;
            this.btnTCPDisconnect.Click += new System.EventHandler(this.btnTCPDisconnect_Click);
            // 
            // btnTCPConnect
            // 
            this.btnTCPConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTCPConnect.Location = new System.Drawing.Point(186, 1);
            this.btnTCPConnect.Margin = new System.Windows.Forms.Padding(0);
            this.btnTCPConnect.Name = "btnTCPConnect";
            this.btnTCPConnect.Size = new System.Drawing.Size(123, 27);
            this.btnTCPConnect.TabIndex = 34;
            this.btnTCPConnect.Text = "CONNECT";
            this.btnTCPConnect.UseVisualStyleBackColor = true;
            this.btnTCPConnect.Click += new System.EventHandler(this.btnTCPConnect_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbSendMessage, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbReceiveMessage, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 310);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(630, 240);
            this.tableLayoutPanel3.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(318, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Received Message";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Send Message";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(654, 562);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutTCP);
            this.Controls.Add(this.tableLayoutMode);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutSerial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Serial Communication TEST Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutSerial.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutCommand.ResumeLayout(false);
            this.tableLayoutCommand.PerformLayout();
            this.tableLayoutMode.ResumeLayout(false);
            this.tableLayoutTCP.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnComPortOpen;
        private System.Windows.Forms.Button btnComPortClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.CheckBox cbSTX;
        private System.Windows.Forms.CheckBox cbCR;
        private System.Windows.Forms.CheckBox cbLF;
        private System.Windows.Forms.CheckBox cbETX;
        private System.Windows.Forms.Button btnTextClear;
        private System.Windows.Forms.ComboBox cbCommand;
        private System.Windows.Forms.Button btnContinueSend;
        private System.Windows.Forms.RichTextBox tbSendMessage;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label lbCommand;
        private System.Windows.Forms.Label lbPortName;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.Label lbDataBit;
        private System.Windows.Forms.Label lbParityBit;
        private System.Windows.Forms.Label lbStopBit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox tbReceiveMessage;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPortNum;
        private System.Windows.Forms.RadioButton rbSerial;
        private System.Windows.Forms.RadioButton rbTCP;
        private System.Windows.Forms.Button btnCheckSum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutSerial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutTCP;
        private System.Windows.Forms.Button btnTCPDisconnect;
        private System.Windows.Forms.Button btnTCPConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCommand;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}

