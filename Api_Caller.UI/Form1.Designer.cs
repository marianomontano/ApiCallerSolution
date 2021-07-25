
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioDelete = new System.Windows.Forms.RadioButton();
			this.radioPut = new System.Windows.Forms.RadioButton();
			this.radioPost = new System.Windows.Forms.RadioButton();
			this.radioGet = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnSend = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnClearParams = new System.Windows.Forms.Button();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panelResponse = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.txtResponse = new System.Windows.Forms.TextBox();
			this.panelRequest = new System.Windows.Forms.Panel();
			this.PanelHeaders = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.dgvHeaders = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel10 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panelParameters = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.dgvBody = new System.Windows.Forms.DataGridView();
			this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panelResponse.SuspendLayout();
			this.panelRequest.SuspendLayout();
			this.PanelHeaders.SuspendLayout();
			this.panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).BeginInit();
			this.panel10.SuspendLayout();
			this.panelParameters.SuspendLayout();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBody)).BeginInit();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
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
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.txtUrl);
			this.panel2.Controls.Add(this.label1);
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Name = "panel2";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.btnSend);
			resources.ApplyResources(this.panel5, "panel5");
			this.panel5.Name = "panel5";
			// 
			// btnSend
			// 
			resources.ApplyResources(this.btnSend, "btnSend");
			this.btnSend.Name = "btnSend";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnClearParams);
			resources.ApplyResources(this.panel4, "panel4");
			this.panel4.Name = "panel4";
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
			// panel3
			// 
			this.panel3.Controls.Add(this.panelResponse);
			this.panel3.Controls.Add(this.panelRequest);
			resources.ApplyResources(this.panel3, "panel3");
			this.panel3.Name = "panel3";
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
			this.PanelHeaders.Controls.Add(this.panel11);
			this.PanelHeaders.Controls.Add(this.panel10);
			resources.ApplyResources(this.PanelHeaders, "PanelHeaders");
			this.PanelHeaders.Name = "PanelHeaders";
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.dgvHeaders);
			resources.ApplyResources(this.panel11, "panel11");
			this.panel11.Name = "panel11";
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
			// panel10
			// 
			this.panel10.Controls.Add(this.label3);
			resources.ApplyResources(this.panel10, "panel10");
			this.panel10.Name = "panel10";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// panelParameters
			// 
			resources.ApplyResources(this.panelParameters, "panelParameters");
			this.panelParameters.Controls.Add(this.panel9);
			this.panelParameters.Controls.Add(this.panel8);
			this.panelParameters.Name = "panelParameters";
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.dgvBody);
			resources.ApplyResources(this.panel9, "panel9");
			this.panel9.Name = "panel9";
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
			// panel8
			// 
			this.panel8.Controls.Add(this.label2);
			resources.ApplyResources(this.panel8, "panel8");
			this.panel8.Name = "panel8";
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
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panelResponse.ResumeLayout(false);
			this.panelResponse.PerformLayout();
			this.panelRequest.ResumeLayout(false);
			this.PanelHeaders.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).EndInit();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.panelParameters.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBody)).EndInit();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioDelete;
		private System.Windows.Forms.RadioButton radioPut;
		private System.Windows.Forms.RadioButton radioPost;
		private System.Windows.Forms.RadioButton radioGet;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
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
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panelParameters;
		private System.Windows.Forms.Panel PanelHeaders;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel8;
	}
}

