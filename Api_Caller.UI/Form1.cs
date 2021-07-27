using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Api_Caller.UI;
using Api_Caller.UI.RequestManagers;

namespace Api_Caller
{
	public partial class Form1 : Form
	{
		private SimpleFactory factory;

		public Form1(SimpleFactory simpleFactory)
		{
			InitializeComponent();
			factory = simpleFactory;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			radioGet.Checked = true;
			txtUrl.Text = string.Empty;
			txtResponse.Text = string.Empty;
			dgvBody.DataSource = null;
			dgvHeaders.DataSource = null;

			cmbAuth.DataSource = new List<string>
			{
				"No Auth",
				"Bearer",
				"Basic Auth",
				"Oauth 2.0"
			};

			txtAuth.Enabled = false;
		}

		private async void btnSend_Click(object sender, EventArgs e)
		{
			IRequestManager manager;
			manager = CreateRequestManager();

			try
			{
				manager.Url = txtUrl.Text;

				GetAllParameters(manager);
				GetHeaders(manager);
				GetAuthorizationParameters(manager);

				await manager.SendRequest();
				txtResponse.Text = manager.Response;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void GetAuthorizationParameters(IRequestManager manager)
		{
			if (chkAuth.Checked)
			{
				if (txtAuth.Text != "")
				{
					var combo = this.Invoke(new Func<string>(() => cmbAuth.Text)).ToString();
					manager.Authorization = new Tuple<string, string>(combo, txtAuth.Text);
				}
				else
				{
					MessageBox.Show("Authorization value is mandatory");
				}
			}
		}

		private void GetHeaders(IRequestManager manager)
		{
			foreach (DataGridViewRow header in dgvHeaders.Rows)
			{
				var key = header.Cells[0].Value ?? string.Empty;
				var value = header.Cells[1].Value ?? string.Empty;
				if (!string.IsNullOrEmpty(key.ToString()) && !string.IsNullOrEmpty(value.ToString()))
					manager.Headers.Add(key.ToString(), value.ToString());
			}
		}

		private void GetAllParameters(IRequestManager manager)
		{
			foreach (DataGridViewRow parameter in dgvBody.Rows)
			{
				var key = parameter.Cells[0].Value ?? string.Empty;
				var value = parameter.Cells[1].Value ?? string.Empty;
				if (!string.IsNullOrEmpty(key.ToString()) && !string.IsNullOrEmpty(value.ToString()))
					manager.Parameters.Add(key.ToString(), value.ToString());
			}
		}

		private IRequestManager CreateRequestManager()
		{
			IRequestManager manager;

			if (radioGet.Checked)
			{
				manager = factory.GetRequestManagerInstance();
			}
			else if (radioPost.Checked)
			{
				manager = factory.GetPostRequestManagerInstance();
			}
			else if (radioPut.Checked)
			{
				manager = factory.GetPutRequestManagerInstance();
			}
			else if (radioDelete.Checked)
			{
				manager = factory.GetDeleteRequestManagerInstance();
			}
			else
			{
				manager = null;
				MessageBox.Show("Método seleccionado inválido.");
			}

			return manager;
		}

		private void btnClearParams_Click(object sender, EventArgs e)
		{
			dgvBody.Rows.Clear();
			dgvHeaders.Rows.Clear();
			chkAuth.Checked = false;
			cmbAuth.SelectedIndex = 0;
		}

		private void chkAuth_CheckedChanged(object sender, EventArgs e)
		{
			txtAuth.Enabled = chkAuth.Checked;
		}
	}
}