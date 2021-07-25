
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioDelete = new System.Windows.Forms.RadioButton();
			this.radioPut = new System.Windows.Forms.RadioButton();
			this.radioPost = new System.Windows.Forms.RadioButton();
			this.radioGet = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panelResponse = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.txtResponse = new System.Windows.Forms.TextBox();
			this.panelRequest = new System.Windows.Forms.Panel();
			this.dgvHeaders = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvBody = new System.Windows.Forms.DataGridView();
			this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panelResponse.SuspendLayout();
			this.panelRequest.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBody)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1086, 61);
			this.panel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
			this.groupBox1.Controls.Add(this.radioDelete);
			this.groupBox1.Controls.Add(this.radioPut);
			this.groupBox1.Controls.Add(this.radioPost);
			this.groupBox1.Controls.Add(this.radioGet);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1086, 61);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Method Verbs";
			// 
			// radioDelete
			// 
			this.radioDelete.AutoSize = true;
			this.radioDelete.Location = new System.Drawing.Point(514, 21);
			this.radioDelete.Name = "radioDelete";
			this.radioDelete.Size = new System.Drawing.Size(83, 21);
			this.radioDelete.TabIndex = 3;
			this.radioDelete.TabStop = true;
			this.radioDelete.Text = "DELETE";
			this.radioDelete.UseVisualStyleBackColor = true;
			// 
			// radioPut
			// 
			this.radioPut.AutoSize = true;
			this.radioPut.Location = new System.Drawing.Point(390, 21);
			this.radioPut.Name = "radioPut";
			this.radioPut.Size = new System.Drawing.Size(57, 21);
			this.radioPut.TabIndex = 2;
			this.radioPut.TabStop = true;
			this.radioPut.Text = "PUT";
			this.radioPut.UseVisualStyleBackColor = true;
			// 
			// radioPost
			// 
			this.radioPost.AutoSize = true;
			this.radioPost.Location = new System.Drawing.Point(253, 21);
			this.radioPost.Name = "radioPost";
			this.radioPost.Size = new System.Drawing.Size(67, 21);
			this.radioPost.TabIndex = 1;
			this.radioPost.TabStop = true;
			this.radioPost.Text = "POST";
			this.radioPost.UseVisualStyleBackColor = true;
			// 
			// radioGet
			// 
			this.radioGet.AutoSize = true;
			this.radioGet.Location = new System.Drawing.Point(121, 21);
			this.radioGet.Name = "radioGet";
			this.radioGet.Size = new System.Drawing.Size(58, 21);
			this.radioGet.TabIndex = 0;
			this.radioGet.TabStop = true;
			this.radioGet.Text = "GET";
			this.radioGet.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnSend);
			this.panel2.Controls.Add(this.txtUrl);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 61);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1086, 63);
			this.panel2.TabIndex = 3;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(928, 9);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(105, 37);
			this.btnSend.TabIndex = 2;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtUrl
			// 
			this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUrl.Location = new System.Drawing.Point(74, 12);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(848, 30);
			this.txtUrl.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL:";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panelResponse);
			this.panel3.Controls.Add(this.panelRequest);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 124);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1086, 538);
			this.panel3.TabIndex = 4;
			// 
			// panelResponse
			// 
			this.panelResponse.Controls.Add(this.label4);
			this.panelResponse.Controls.Add(this.txtResponse);
			this.panelResponse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelResponse.Location = new System.Drawing.Point(632, 0);
			this.panelResponse.Name = "panelResponse";
			this.panelResponse.Size = new System.Drawing.Size(454, 538);
			this.panelResponse.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Response:";
			// 
			// txtResponse
			// 
			this.txtResponse.Location = new System.Drawing.Point(0, 29);
			this.txtResponse.Multiline = true;
			this.txtResponse.Name = "txtResponse";
			this.txtResponse.ReadOnly = true;
			this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtResponse.Size = new System.Drawing.Size(454, 506);
			this.txtResponse.TabIndex = 0;
			this.txtResponse.WordWrap = false;
			// 
			// panelRequest
			// 
			this.panelRequest.Controls.Add(this.dgvHeaders);
			this.panelRequest.Controls.Add(this.label3);
			this.panelRequest.Controls.Add(this.dgvBody);
			this.panelRequest.Controls.Add(this.label2);
			this.panelRequest.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelRequest.Location = new System.Drawing.Point(0, 0);
			this.panelRequest.Name = "panelRequest";
			this.panelRequest.Size = new System.Drawing.Size(632, 538);
			this.panelRequest.TabIndex = 0;
			// 
			// dgvHeaders
			// 
			this.dgvHeaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.dgvHeaders.Location = new System.Drawing.Point(4, 363);
			this.dgvHeaders.MultiSelect = false;
			this.dgvHeaders.Name = "dgvHeaders";
			this.dgvHeaders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvHeaders.RowTemplate.Height = 24;
			this.dgvHeaders.Size = new System.Drawing.Size(625, 172);
			this.dgvHeaders.TabIndex = 3;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Key";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Value";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 339);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Headers:";
			// 
			// dgvBody
			// 
			this.dgvBody.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.key,
            this.value});
			this.dgvBody.Location = new System.Drawing.Point(5, 29);
			this.dgvBody.MultiSelect = false;
			this.dgvBody.Name = "dgvBody";
			this.dgvBody.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvBody.RowTemplate.Height = 24;
			this.dgvBody.Size = new System.Drawing.Size(625, 296);
			this.dgvBody.TabIndex = 1;
			// 
			// key
			// 
			this.key.HeaderText = "Key";
			this.key.MinimumWidth = 6;
			this.key.Name = "key";
			// 
			// value
			// 
			this.value.HeaderText = "Value";
			this.value.MinimumWidth = 6;
			this.value.Name = "value";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Body/Parameters:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1086, 662);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "API CALLER";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panelResponse.ResumeLayout(false);
			this.panelResponse.PerformLayout();
			this.panelRequest.ResumeLayout(false);
			this.panelRequest.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBody)).EndInit();
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
	}
}

