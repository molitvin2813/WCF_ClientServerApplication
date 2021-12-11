using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestClient
{
    public partial class GetDataFromRequestTableBySomeDay : Form
    {
        long idState, idType;
        int idStreet;
        int rowIndex;
        private DateTime date;
        public GetDataFromRequestTableBySomeDay(DateTime date)
        {
            InitializeComponent();
            this.date = date;
            refreshGrid();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }
        private async void refreshGrid()
        {
            dataGridView1.Columns.Clear();
            RequestTableCRUDClient client = new RequestTableCRUDClient();
            RequestTable[] requestStateTable = client.ReadRequestTableAsync().Result;
            await client.CloseAsync();

            DataTable table = new DataTable();

            RequestTypeTableCRUDClient client2 = new RequestTypeTableCRUDClient();
            RequestTypeTable[] requestTypes = await client2.ReadRequestTypeTableAsync();
            DataGridViewComboBoxColumn typeCombobox = new DataGridViewComboBoxColumn();
            typeCombobox.HeaderText = "Тип заявки";
            typeCombobox.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            typeCombobox.FlatStyle = FlatStyle.Popup;

            foreach (RequestTypeTable item in requestTypes)
                typeCombobox.Items.Add(item.Type);


            StreetTableCRUDClient client3 = new StreetTableCRUDClient();
            StreetTable[] streetTables = await client3.ReadStreetTableAsync();

            await client3.CloseAsync();
            DataGridViewComboBoxColumn streetCombobox = new DataGridViewComboBoxColumn();
            streetCombobox.HeaderText = "Улица";
            streetCombobox.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            streetCombobox.FlatStyle = FlatStyle.Popup;

            foreach (StreetTable item in streetTables)
                streetCombobox.Items.Add(item.Street);


            RequestStateTableCRUDClient client4 = new RequestStateTableCRUDClient();
            RequestStateTable[] requestStates = await client4.ReadRequestStateTableAsync();

            await client2.CloseAsync();

            await client4.CloseAsync();

            DataGridViewComboBoxColumn stateCombobox = new DataGridViewComboBoxColumn();
            stateCombobox.HeaderText = "Статус заявки";
            stateCombobox.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            stateCombobox.FlatStyle = FlatStyle.Popup;


            foreach (RequestStateTable item in requestStates)
                stateCombobox.Items.Add(item.State);

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Баланс");
            table.Columns.Add("Коментарий к заявке");

            table.Columns.Add("ФИО клиента");
            table.Columns.Add("Дом");
            table.Columns.Add("Квартира");

            table.Columns.Add("Номер телефона");
            table.Columns.Add("Порт");

            int i = 0;
            requestStateTable = requestStateTable.Where(i =>
                
                i.DateCreate.Value.Day == this.date.Day &&
                i.DateCreate.Value.Year == this.date.Year &&
                i.DateCreate.Value.Month == this.date.Month
                ).ToArray();
            foreach (RequestTable item in requestStateTable)
            {
                table.Rows.Add(table.NewRow());
                table.Rows[i][0] = item.IdRequest;
                table.Rows[i][1] = item.AccountBalance;
                table.Rows[i][2] = item.CommentForRequest;
                table.Rows[i][3] = item.FioClient;
                table.Rows[i][4] = item.House;
                table.Rows[i][5] = item.Apartment;
                table.Rows[i][6] = item.PhoneNumber;
                table.Rows[i][7] = item.Port;

                i++;
            }
            if(table.Rows.Count > 0) { 
                dataGridView1.DataSource = table;

                dataGridView1.Columns.Add(streetCombobox);
                dataGridView1.Columns.Add(typeCombobox);
                dataGridView1.Columns.Add(stateCombobox);


                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                dataGridView1.Rows[dataGridView1.Rows.Count -1].ReadOnly = true;
                refreshCombo();
            }
            //dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
       
          
            await client.CloseAsync();
        }

        public async void refreshCombo()
        {
            RequestTableCRUDClient client = new RequestTableCRUDClient();
            RequestTable[] requestStateTable = client.ReadRequestTableAsync().Result;
            await client.CloseAsync();

            RequestTypeTableCRUDClient client2 = new RequestTypeTableCRUDClient();
            RequestTypeTable[] requestTypes = await client2.ReadRequestTypeTableAsync();

            RequestStateTableCRUDClient client4 = new RequestStateTableCRUDClient();
            RequestStateTable[] requestStates = await client4.ReadRequestStateTableAsync();
            await client2.CloseAsync();
            await client4.CloseAsync();

            StreetTableCRUDClient streetTableCRUDClient = new StreetTableCRUDClient();
            StreetTable[] streetTables = await streetTableCRUDClient.ReadStreetTableAsync();
            await streetTableCRUDClient.CloseAsync();

            for (int c = 0; c < dataGridView1.Rows.Count - 1; c++)
            {
                long idreqType = (from request in requestStateTable
                                  where request.IdRequest == int.Parse(dataGridView1.Rows[c].Cells[0].Value.ToString())
                                  select new
                                  {
                                      request.IdRequestType
                                  }).ToArray()[0].IdRequestType;

                long idState = (from request in requestStateTable
                                where request.IdRequest == int.Parse(dataGridView1.Rows[c].Cells[0].Value.ToString())
                                select new
                                {
                                    request.IdRequestState
                                }).ToArray()[0].IdRequestState;

                if ((from request in requestStateTable
                     where request.IdRequest == int.Parse(dataGridView1.Rows[c].Cells[0].Value.ToString())
                     select new
                     {
                         request.IdStreet
                     }).ToArray()[0].IdStreet != null)
                {
                    int idStreet = (int)(from request in requestStateTable
                                         where request.IdRequest == int.Parse(dataGridView1.Rows[c].Cells[0].Value.ToString())
                                         select new
                                         {
                                             request.IdStreet
                                         }).ToArray()[0].IdStreet;
                    dataGridView1.Rows[c].Cells[8].Value = (from street in streetTables
                                                            where street.IdStreet == idStreet
                                                            select new
                                                            {
                                                                street.Street
                                                            }).ToArray()[0].Street;
                }


                dataGridView1.Rows[c].Cells[9].Value = (from type in requestTypes
                                                        where type.IdRequestType == idreqType
                                                        select new
                                                        {
                                                            type.Type
                                                        }).ToArray()[0].Type;

                dataGridView1.Rows[c].Cells[10].Value = (from state in requestStates
                                                         where state.IdRequestState == idState
                                                         select new
                                                         {
                                                             state.State
                                                         }).ToArray()[0].State;
            }
            paintRequest();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.rowIndex = e.RowIndex;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.openChildFormInPanel(new GetDataFromRequestTableByDay(this.date.Year, this.date.Month));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.openChildFormInPanel(new ReportWorker(this.date));
        }

        private void paintRequest()
        {
            dataGridView1.Columns[10].Visible = false;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                if (dataGridView1.Rows[i].Cells[10].Value != null)
                    switch (dataGridView1.Rows[i].Cells[10].Value.ToString())
                    {
                        case "выполнено":
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                            break;
                        case "отрицательный баланс":
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            break;
                        case "не выполнено":
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            break;
                        case "выполняется":
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Yellow;
                            break;
                        case "отменена":
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                            break;
                    }
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            refreshCombo();
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {

            await getIdState();
            await getIdStreet();
            await getIdType();

            RequestTableCRUDClient client = new RequestTableCRUDClient();



            await client.UpdateRequestTableAsync
               (
                   long.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString()),
                   this.idType,
                   dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString(),
                   -1,
                   "",
                   "",
                   "",
                   DateTime.Now,
                   -1,
                   -1,
                   -1,
                   "",
                   this.idState,
                   dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString(),
                   this.idStreet,
                   dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString(),
                   dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString(),
                   dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString(),
                   dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString(),
                   int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString())
               );
            await client.CloseAsync();

            refreshGrid();
        }

        private async Task getIdType()
        {

            RequestTypeTableCRUDClient client2 = new RequestTypeTableCRUDClient();
            RequestTypeTable[] requestTypes = await client2.ReadRequestTypeTableAsync();

            this.idType = (from request in requestTypes
                           where request.Type == dataGridView1.Rows[this.rowIndex].Cells[9].Value.ToString()
                           select new
                           {
                               request.IdRequestType
                           }).ToArray()[0].IdRequestType;

            await client2.CloseAsync();
        }

        private async Task getIdState()
        {

            RequestStateTableCRUDClient client4 = new RequestStateTableCRUDClient();
            RequestStateTable[] requestStates = await client4.ReadRequestStateTableAsync();

            this.idState = (from state in requestStates
                            where state.State == dataGridView1.Rows[this.rowIndex].Cells[10].Value.ToString()
                            select new
                            {
                                state.IdRequestState
                            }).ToArray()[0].IdRequestState;

            await client4.CloseAsync();

        }

        private async Task getIdStreet()
        {

            StreetTableCRUDClient client4 = new StreetTableCRUDClient();
            StreetTable[] streetTables = await client4.ReadStreetTableAsync();

            this.idStreet = (from state in streetTables
                             where state.Street == dataGridView1.Rows[this.rowIndex].Cells[8].Value.ToString()
                             select new
                             {
                                 state.IdStreet
                             }).ToArray()[0].IdStreet;

            await client4.CloseAsync();

        }


        private async Task<long> getIdStateCancel()
        {
            RequestStateTableCRUDClient client4 = new RequestStateTableCRUDClient();
            RequestStateTable[] requestStates = await client4.ReadRequestStateTableAsync();

            await client4.CloseAsync();
            return (from state in requestStates
                    where state.State == "отменена"
                    select new
                    {
                        state.IdRequestState
                    }).ToArray()[0].IdRequestState;
        }

        private async Task<long> getIdStateInProgress()
        {
            RequestStateTableCRUDClient client4 = new RequestStateTableCRUDClient();
            RequestStateTable[] requestStates = await client4.ReadRequestStateTableAsync();

            await client4.CloseAsync();
            return (from state in requestStates
                    where state.State == "выполняется"
                    select new
                    {
                        state.IdRequestState
                    }).ToArray()[0].IdRequestState;
        }


        private async void buttonCancel_Click(object sender, EventArgs e)
        {
            RequestTableCRUDClient client1 = new RequestTableCRUDClient();
            RequestTable[] requests = await client1.ReadRequestTableAsync();
            await client1.CloseAsync();
            var ss = requests.Where
                    (i =>
                        i.IdRequest == int.Parse(dataGridView1.Rows[this.rowIndex].Cells[0].FormattedValue.ToString())
                    ).ToArray()[0].DateOfCompletion;
            if (requests.Where
                    (i=> 
                        i.IdRequest == int.Parse(dataGridView1.Rows[this.rowIndex].Cells[0].FormattedValue.ToString())
                    ).ToArray()[0].DateOfCompletion ==null
                )
            {
                long tmp = await getIdStateCancel();
                RequestTableCRUDClient client = new RequestTableCRUDClient();

                await client.UpdateRequestTableAsync
                    (
                       -1,
                       -1,
                       "",
                       -1,
                       "",
                       "",
                       "",
                       null,
                       -1,
                       -1,
                       -1,
                       "",
                       tmp,
                       "",
                       -1,
                       "",
                       "",
                       "",
                       "",
                       int.Parse(dataGridView1.Rows[this.rowIndex].Cells[0].FormattedValue.ToString())
                    ); ;
                await client.CloseAsync();
            }
            else
            {
                MessageBox.Show("Заявку невозможно отменить: ее уже выполнили");
            }
            

            refreshGrid();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            long tmp = await getIdStateInProgress();
            RequestTableCRUDClient client = new RequestTableCRUDClient();

            await client.UpdateRequestTableAsync
                (
                   -1,
                   -1,
                   "",
                   -1,
                   "",
                   "",
                   "",
                   null,
                   -1,
                   -1,
                   -1,
                   "",
                   tmp,
                   "",
                   -1,
                   "",
                   "",
                   "",
                   "",
                   int.Parse(dataGridView1.Rows[this.rowIndex].Cells[0].FormattedValue.ToString())
                ); ;
            await client.CloseAsync();

            refreshGrid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 && e.ColumnIndex != dataGridView1.Columns.Count && e.RowIndex != -1)
                if(dataGridView1.Rows[this.rowIndex].Cells[0].Value != null && e.RowIndex < dataGridView1.Rows.Count - 1)
                Main.openChildFormInPanel(new UpdateRequestTable(this.date, int.Parse(dataGridView1.Rows[this.rowIndex].Cells[0].Value.ToString())));
        }
    }
}
