
namespace Api_Caller
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panelMethods = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioDelete = new System.Windows.Forms.RadioButton();
			this.radioPut = new System.Windows.Forms.RadioButton();
			this.radioPost = new System.Windows.Forms.RadioButton();
			this.radioGet = new System.Windows.Forms.RadioButton();
			this.panelUrlButtons = new System.Windows.Forms.Panel();
			this.panelBtnSend = new System.Windows.Forms.Panel();
			this.btnSend = new System.Windows.Forms.Button();
			this.panelBtnClear = new System.Windows.Forms.Panel();
			this.btnClearParams = new System.Windows.Forms.Button();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelMain = new System.Windows.Forms.Panel();
			this.panelResponse = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.txtResponse = new System.Windows.Forms.TextBox();
			this.panelRequest = new System.Windows.Forms.Panel();
			this.PanelHeaders = new System.Windows.Forms.Panel();
			this.panelHeadersGrid = new System.Windows.Forms.Panel();
			this.dgvHeaders = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelHeadersHead = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panelParameters = new System.Windows.Forms.Panel();
			this.panelBodyGrid = new System.Windows.Forms.Panel();
			this.cmbAuth = new System.Windows.Forms.ComboBox();
			this.txtAuth = new System.Windows.Forms.TextBox();
			this.chkAuth = new System.Windows.Forms.CheckBox();
			this.dgvBody = new System.Windows.Forms.DataGridView();
			this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelBodyHeader = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panelMethods.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panelUrlButtons.SuspendLayout();
			this.panelBtnSend.SuspendLayout();
			this.panelBtnClear.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.panelResponse.SuspendLayout();
			this.panelRequest.SuspendLayout();
			this.PanelHeaders.SuspendLayout();
			this.panelHeadersGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).BeginInit();
			this.panelHeadersHead.SuspendLayout();
			this.panelParameters.SuspendLayout();
			this.panelBodyGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBody)).BeginInit();
			this.panelBodyHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMethods
			// 
			this.panelMethods.Controls.Add(this.groupBox1);
			resources.ApplyResources(this.panelMethods, "panelMethods");
			this.panelMethods.Name = "panelMethods";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
			this.groupBox1.Controls.Add(this.radioDelete);
			this.groupBox1.Controls.Add(this.radioPut);
			this.groupBox1.Controls.Add(this.radioPost);
			this.groupBox1.Controls.Add(this.radioGet);
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// radioDelete
			// 
			resources.ApplyResources(this.radioDelete, "radioDelete");
			this.radioDelete.Name = "radioDelete";
			this.radioDelete.TabStop = true;
			this.radioDelete.UseVisualStyleBackColor = true;
			// 
			// radioPut
			// 
			resources.ApplyResources(this.radioPut, "radioPut");
			this.radioPut.Name = "radioPut";
			this.radioPut.TabStop = true;
			this.radioPut.UseVisualStyleBackColor = true;
			// 
			// radioPost
			// 
			resources.ApplyResources(this.radioPost, "radioPost");
			this.radioPost.Name = "radioPost";
			this.radioPost.TabStop = true;
			this.radioPost.UseVisualStyleBackColor = true;
			// 
			// radioGet
			// 
			resources.ApplyResources(this.radioGet, "radioGet");
			this.radioGet.Name = "radioGet";
			this.radioGet.TabStop = true;
			this.radioGet.UseVisualStyleBackColor = true;
			// 
			// panelUrlButtons
			// 
			this.panelUrlButtons.Controls.Add(this.panelBtnSend);
			this.panelUrlButtons.Controls.Add(this.panelBtnClear);
			this.panelUrlButtons.Controls.Add(this.txtUrl);
			this.panelUrlButtons.Controls.Add(this.label1);
			resources.ApplyResources(this.panelUrlButtons, "panelUrlButtons");
			this.panelUrlButtons.Name = "panelUrlButtons";
			// 
			// panelBtnSend
			// 
			this.panelBtnSend.Controls.Add(this.btnSend);
			resources.ApplyResources(this.panelBtnSend, "panelBtnSend");
			this.panelBtnSend.Name = "panelBtnSend";
			// 
			// btnSend
			// 
			resources.ApplyResources(this.btnSend, "btnSend");
			this.btnSend.Name = "btnSend";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// panelBtnClear
			// 
			this.panelBtnClear.Controls.Add(this.btnClearParams);
			resources.ApplyResources(this.panelBtnClear, "panelBtnClear");
			this.panelBtnClear.Name = "panelBtnClear";
			// 
			// btnClearParams
			// 
			resources.ApplyResources(this.btnClearParams, "btnClearParams");
			this.btnClearParams.Name = "btnClearParams";
			this.btnClearParams.UseVisualStyleBackColor = true;
			this.btnClearParams.Click += new System.EventHandler(this.btnClearParams_Click);
			// 
			// txtUrl
			// 
			resources.ApplyResources(this.txtUrl, "txtUrl");
			this.txtUrl.Name = "txtUrl";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Name = "label1";
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.panelResponse);
			this.panelMain.Controls.Add(this.panelRequest);
			resources.ApplyResources(this.panelMain, "panelMain");
			this.panelMain.Name = "panelMain";
			// 
			// panelResponse
			// 
			this.panelResponse.Controls.Add(this.label4);
			this.panelResponse.Controls.Add(this.txtResponse);
			resources.ApplyResources(this.panelResponse, "panelResponse");
			this.panelResponse.Name = "panelResponse";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// txtResponse
			// 
			resources.ApplyResources(this.txtResponse, "txtResponse");
			this.txtResponse.Name = "txtResponse";
			this.txtResponse.ReadOnly = true;
			// 
			// panelRequest
			// 
			this.panelRequest.Controls.Add(this.PanelHeaders);
			this.panelRequest.Controls.Add(this.panelParameters);
			resources.ApplyResources(this.panelRequest, "panelRequest");
			this.panelRequest.Name = "panelRequest";
			// 
			// PanelHeaders
			// 
			this.PanelHeaders.Controls.Add(this.panelHeadersGrid);
			this.PanelHeaders.Controls.Add(this.panelHeadersHead);
			resources.ApplyResources(this.PanelHeaders, "PanelHeaders");
			this.PanelHeaders.Name = "PanelHeaders";
			// 
			// panelHeadersGrid
			// 
			this.panelHeadersGrid.Controls.Add(this.dgvHeaders);
			resources.ApplyResources(this.panelHeadersGrid, "panelHeadersGrid");
			this.panelHeadersGrid.Name = "panelHeadersGrid";
			// 
			// dgvHeaders
			// 
			this.dgvHeaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			resources.ApplyResources(this.dgvHeaders, "dgvHeaders");
			this.dgvHeaders.MultiSelect = false;
			this.dgvHeaders.Name = "dgvHeaders";
			this.dgvHeaders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvHeaders.RowTemplate.Height = 24;
			// 
			// dataGridViewTextBoxColumn1
			// 
			resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// panelHeadersHead
			// 
			this.panelHeadersHead.Controls.Add(this.label3);
			resources.ApplyResources(this.panelHeadersHead, "panelHeadersHead");
			this.panelHeadersHead.Name = "panelHeadersHead";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// panelParameters
			// 
			resources.ApplyResources(this.panelParameters, "panelParameters");
			this.panelParameters.Controls.Add(this.panelBodyGrid);
			this.panelParameters.Controls.Add(this.panelBodyHeader);
			this.panelParameters.Name = "panelParameters";
			// 
			// panelBodyGrid
			// 
			this.panelBodyGrid.Controls.Add(this.cmbAuth);
			this.panelBodyGrid.Controls.Add(this.txtAuth);
			this.panelBodyGrid.Controls.Add(this.chkAuth);
			this.panelBodyGrid.Controls.Add(this.dgvBody);
			resources.ApplyResources(this.panelBodyGrid, "panelBodyGrid");
			this.panelBodyGrid.Name = "panelBodyGrid";
			// 
			// cmbAuth
			// 
			resources.ApplyResources(this.cmbAuth, "cmbAuth");
			this.cmbAuth.FormattingEnabled = true;
			this.cmbAuth.Name = "cmbAuth";
			// 
			// txtAuth
			// 
			resources.ApplyResources(this.txtAuth, "txtAuth");
			this.txtAuth.Name = "txtAuth";
			// 
			// chkAuth
			// 
			resources.ApplyResources(this.chkAuth, "chkAuth");
			this.chkAuth.Name = "chkAuth";
			this.chkAuth.UseVisualStyleBackColor = true;
			this.chkAuth.CheckedChanged += new System.EventHandler(this.chkAuth_CheckedChanged);
			// 
			// dgvBody
			// 
			resources.ApplyResources(this.dgvBody, "dgvBody");
			this.dgvBody.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.key,
            this.value});
			this.dgvBody.MultiSelect = false;
			this.dgvBody.Name = "dgvBody";
			this.dgvBody.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvBody.RowTemplate.Height = 24;
			// 
			// key
			// 
			resources.ApplyResources(this.key, "key");
			this.key.Name = "key";
			// 
			// value
			// 
			resources.ApplyResources(this.value, "value");
			this.value.Name = "value";
			// 
			// panelBodyHeader
			// 
			this.panelBodyHeader.Controls.Add(this.label2);
			resources.ApplyResources(this.panelBodyHeader, "panelBodyHeader");
			this.panelBodyHeader.Name = "panelBodyHeader";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelUrlButtons);
			this.Controls.Add(this.panelMethods);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panelMethods.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panelUrlButtons.ResumeLayout(false);
			this.panelUrlButtons.PerformLayout();
			this.panelBtnSend.ResumeLayout(false);
			this.panelBtnClear.ResumeLayout(false);
			this.panelMain.ResumeLayout(false);
			this.panelResponse.ResumeLayout(false);
			this.panelResponse.PerformLayout();
			this.panelRequest.ResumeLayout(false);
			this.PanelHeaders.ResumeLayout(false);
			this.panelHeadersGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).EndInit();
			this.panelHeadersHead.ResumeLayout(false);
			this.panelHeadersHead.PerformLayout();
			this.panelParameters.ResumeLayout(false);
			this.panelBodyGrid.ResumeLayout(false);
			this.panelBodyGrid.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBody)).EndInit();
			this.panelBodyHeader.ResumeLayout(false);
			this.panelBodyHeader.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMethods;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioDelete;
		private System.Windows.Forms.RadioButton radioPut;
		private System.Windows.Forms.RadioButton radioPost;
		private System.Windows.Forms.RadioButton radioGet;
		private System.Windows.Forms.Panel panelUrlButtons;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Panel panelResponse;
		private System.Windows.Forms.Panel panelRequest;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtResponse;
		private System.Windows.Forms.DataGridView dgvHeaders;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvBody;
		private System.Windows.Forms.DataGridViewTextBoxColumn key;
		private System.Windows.Forms.DataGridViewTextBoxColumn value;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnClearParams;
		private System.Windows.Forms.Panel panelBtnSend;
		private System.Windows.Forms.Panel panelBtnClear;
		private System.Windows.Forms.Panel panelParameters;
		private System.Windows.Forms.Panel PanelHeaders;
		private System.Windows.Forms.Panel panelHeadersGrid;
		private System.Windows.Forms.Panel panelHeadersHead;
		private System.Windows.Forms.Panel panelBodyGrid;
		private System.Windows.Forms.Panel panelBodyHeader;
		private System.Windows.Forms.TextBox txtAuth;
		private System.Windows.Forms.CheckBox chkAuth;
		private System.Windows.Forms.ComboBox cmbAuth;
	}
}

