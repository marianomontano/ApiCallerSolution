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
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			string response = "";
			Task.Run(() => response = ExecuteRequestAsync().Result).Wait();

			txtResponse.Text = response;
		}

		private async Task<string> ExecuteRequestAsync()
		{
			IRequestManager manager;

			manager = CreateRequestManager();

			try
			{
				manager.Url = txtUrl.Text;

				foreach (DataGridViewRow parameter in dgvBody.Rows)
				{
					var key = parameter.Cells[0].Value ?? string.Empty;
					var value = parameter.Cells[1].Value ?? string.Empty;
					if (!string.IsNullOrEmpty(key.ToString()) && !string.IsNullOrEmpty(value.ToString()))
						manager.Parameters.Add(key.ToString(), value.ToString());
				}

				foreach (DataGridViewRow header in dgvHeaders.Rows)
				{
					var key = header.Cells[0].Value ?? string.Empty;
					var value = header.Cells[1].Value ?? string.Empty;
					if (!string.IsNullOrEmpty(key.ToString()) && !string.IsNullOrEmpty(value.ToString()))
						manager.Headers.Add(key.ToString(), value.ToString());
				}

				await manager.SendRequest();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			return manager.Response;
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
	}
}