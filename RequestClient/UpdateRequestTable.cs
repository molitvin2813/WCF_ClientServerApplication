using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace RequestClient
{
    public partial class UpdateRequestTable : Form
    {
        DateTime date;
        long idBrigade, idManager, idSysAdmin;
        int id;
        private async Task getIdBrigade()
        {
            BrigadeCRUDClient client4 = new BrigadeCRUDClient();
            Brigade[] brigades = await client4.ReadBrigadeTableAsync();

            this.idBrigade = (from item in brigades
                              where item.Name == dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString()
                              select new
                            {
                                  item.IdBrigade
                            }).ToArray()[0].IdBrigade;

            await client4.CloseAsync();
        }
        
        private async Task getIdManager()
        {
            ManagerTableCRUDClient client4 = new ManagerTableCRUDClient();
            ManagerTable[] requestStates = await client4.ReadManagerTableAsync();

            this.idManager = (from state in requestStates
                            where state.Name == dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[9].Value.ToString()
                              select new
                            {
                                state.IdManager
                            }).ToArray()[0].IdManager;

            await client4.CloseAsync();
        }
        
        private async Task getIdSysAdmin()
        {
            SystemAdministratorTableCRUDClient client4 = new SystemAdministratorTableCRUDClient();
            SystemAdministratorTable[] requestStates = await client4.ReadSystemAdministratorTableAsync();

            this.idSysAdmin = (from state in requestStates
                            where state.Name == dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[10].Value.ToString()
                               select new
                            {
                                state.IdSystemAdministrator
                            }).ToArray()[0].IdSystemAdministrator;

            await client4.CloseAsync();
        }
        
        public UpdateRequestTable(DateTime date, int id)
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            refreshGrid();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.date = date;
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.openChildFormInPanel(new GetDataFromRequestTableBySomeDay(this.date));
        }

      
        private async Task refreshGrid()
        {
            dataGridView1.Columns.Clear();
            RequestTableCRUDClient client = new RequestTableCRUDClient();
            RequestTable[] requestTables = client.ReadRequestTableAsync().Result;
            await client.CloseAsync();

            RequestTypeTableCRUDClient client1 = new RequestTypeTableCRUDClient();
            RequestTypeTable[] requestTypeTables = await client1.ReadRequestTypeTableAsync();

            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(long));
            table.Columns.Add("Количество ТВ", typeof(string));
            table.Columns.Add("Скорость", typeof(string));

            table.Columns.Add("Пинг", typeof(string));
            table.Columns.Add("Коментарий мех.", typeof(string));
            table.Columns.Add("Дата выполнения", typeof(string));
            table.Columns.Add("Цена", typeof(string));


            DataGridViewComboBoxColumn brigadeCombobox = new DataGridViewComboBoxColumn();
            brigadeCombobox.HeaderText = "Бригада";
            brigadeCombobox.ValueType = typeof(string);
            brigadeCombobox.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            brigadeCombobox.FlatStyle = FlatStyle.Popup;
            BrigadeCRUDClient brigadeCRUDClient = new BrigadeCRUDClient();
            Brigade[] brigades = await brigadeCRUDClient.ReadBrigadeTableAsync();
            await brigadeCRUDClient.CloseAsync();

            foreach (Brigade brigade in brigades)
                brigadeCombobox.Items.Add(brigade.Name);

            DataGridViewComboBoxColumn managerCombobox = new DataGridViewComboBoxColumn();
            managerCombobox.HeaderText = "Менеджер";
            managerCombobox.ValueType = typeof(string);
            managerCombobox.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            managerCombobox.FlatStyle = FlatStyle.Popup;
            ManagerTableCRUDClient managerTableCRUDClient = new ManagerTableCRUDClient();
            ManagerTable[] managerTables = await managerTableCRUDClient.ReadManagerTableAsync();
            await managerTableCRUDClient.CloseAsync();

            foreach (ManagerTable item in managerTables)
                managerCombobox.Items.Add(item.Name);

            DataGridViewComboBoxColumn systemAdministratorCombobox = new DataGridViewComboBoxColumn();
            systemAdministratorCombobox.HeaderText = "Системный администратор";
            systemAdministratorCombobox.ValueType = typeof(string);
            systemAdministratorCombobox.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            systemAdministratorCombobox.FlatStyle = FlatStyle.Popup;
            SystemAdministratorTableCRUDClient client4 = new SystemAdministratorTableCRUDClient();
            SystemAdministratorTable[] systemAdministratorTables = await client4.ReadSystemAdministratorTableAsync();
            await client4.CloseAsync();
                      
            foreach (SystemAdministratorTable item in systemAdministratorTables)
                systemAdministratorCombobox.Items.Add(item.Name);


            table.Columns.Add("Отзыв");

            var erer = (from ss in requestTables
                       where
                       (ss.IdRequest == this.id )

                       select new
                       {
                           ss.AccountBalance,
                           ss.IdRequest,
                           ss.CountTv,
                           ss.Speed,
                           ss.Ping,
                           ss.CommentMechanic,
                           ss.DateOfCompletion,
                           ss.IdRequestType,
                           ss.IdBrigade,
                           ss.IdManager,
                           ss.IdSystemAdministrator,
                           ss.Review
                       }).ToArray();

            table.Rows.Add(table.NewRow());
            table.Rows[0][0] = erer[0].IdRequest;
            table.Rows[0][1] = erer[0].CountTv;
            table.Rows[0][2] = erer[0].Speed;
            table.Rows[0][3] = erer[0].Ping;
            table.Rows[0][4] = erer[0].CommentMechanic;
            table.Rows[0][5] = erer[0].DateOfCompletion;

            var tmp = (from ss in requestTypeTables
                        where ss.IdRequestType == erer[0].IdRequestType
                        select new
                        {
                            ss.Price
                        }).ToArray();

            table.Rows[0][6] = tmp.Length == 0 ? "" : tmp[0].Price.ToString();
            table.Rows[0][7] = erer[0].Review;
            
            dataGridView1.DataSource = table;
            dataGridView1.Columns.Add(brigadeCombobox);
            dataGridView1.Columns.Add(managerCombobox);
            dataGridView1.Columns.Add(systemAdministratorCombobox);

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].ReadOnly = true;

            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Rows[1].ReadOnly = true;
            refreshCombo();
            await client1.CloseAsync();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            refreshCombo();
        }


        private async Task<long> getIdStateDone()
        {
            RequestStateTableCRUDClient client4 = new RequestStateTableCRUDClient();
            RequestStateTable[] requestStates = await client4.ReadRequestStateTableAsync();

            await client4.CloseAsync();
            return (from state in requestStates
                    where state.State == "выполнено"
                    select new
                    {
                        state.IdRequestState
                    }).ToArray()[0].IdRequestState;
        }


        public async void refreshCombo()
        {
            RequestTableCRUDClient client = new RequestTableCRUDClient();
            RequestTable[] requestStateTable = client.ReadRequestTableAsync().Result;
            await client.CloseAsync();

            BrigadeCRUDClient brigadeCRUDClient = new BrigadeCRUDClient();
            Brigade[] brigades = await brigadeCRUDClient.ReadBrigadeTableAsync();
            await brigadeCRUDClient.CloseAsync();

            ManagerTableCRUDClient managerTableCRUDClient = new ManagerTableCRUDClient();
            ManagerTable[] managerTables = await managerTableCRUDClient.ReadManagerTableAsync();
            await managerTableCRUDClient.CloseAsync();

            SystemAdministratorTableCRUDClient client4 = new SystemAdministratorTableCRUDClient();
            SystemAdministratorTable[] systemAdministratorTables = await client4.ReadSystemAdministratorTableAsync();
            await client4.CloseAsync();


            int c = 0;
            if ((from request in requestStateTable
                    where request.IdRequest == this.id
                    select new
                    {
                        request.IdBrigade
                    }).ToArray()[0].IdBrigade != null)
            {
                long idBrigade = (long)(from request in requestStateTable
                                        where request.IdRequest == this.id
                                        select new
                                        {
                                            request.IdBrigade
                                        }).ToArray()[0].IdBrigade;

                dataGridView1.Rows[c].Cells[8].Value = (from brigade in brigades
                                                        where brigade.IdBrigade == idBrigade
                                                        select new
                                                        {
                                                            brigade.Name
                                                        }).ToArray()[0].Name;

            }

            if((from request in requestStateTable
                where request.IdRequest == this.id
                select new
                {
                    request.IdManager
                }).ToArray()[0].IdManager != null)
            {
                long idManager = (long)(from request in requestStateTable
                                        where request.IdRequest == this.id
                                        select new
                                        {
                                            request.IdManager
                                        }).ToArray()[0].IdManager;
                dataGridView1.Rows[c].Cells[9].Value = (from manager in managerTables
                                                        where manager.IdManager == idManager
                                                        select new
                                                        {
                                                            manager.Name
                                                        }).ToArray()[0].Name;

            }

            if((from request in requestStateTable
                where request.IdRequest == this.id
                select new
                {
                    request.IdSystemAdministrator
                }).ToArray()[0].IdSystemAdministrator != null)
            {
                long idSys = (long)(from request in requestStateTable
                                    where request.IdRequest == this.id
                                    select new
                                    {
                                        request.IdSystemAdministrator
                                    }).ToArray()[0].IdSystemAdministrator;

                dataGridView1.Rows[c].Cells[10].Value = (from systemAdministrator in systemAdministratorTables
                                                            where systemAdministrator.IdSystemAdministrator == idSys
                                                            select new
                                                            {
                                                                systemAdministrator.Name
                                                            }).ToArray()[0].Name;
            }           

            

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

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[1].FormattedValue == "" ||
                dataGridView1.Rows[0].Cells[2].FormattedValue == "" ||
                dataGridView1.Rows[0].Cells[3].FormattedValue == "" ||
                dataGridView1.Rows[0].Cells[4].FormattedValue == "" ||
                dataGridView1.Rows[0].Cells[6].FormattedValue == "" ||
                dataGridView1.Rows[0].Cells[7].FormattedValue == "" ||
                dataGridView1.Rows[0].Cells[8].FormattedValue == "" ||
                dataGridView1.Rows[0].Cells[9].FormattedValue == "" ||
                dataGridView1.Rows[0].Cells[10].FormattedValue == "" 
                )
            {
                MessageBox.Show("Невозможно выполнить заявку: ЗАПОЛНИТЕ ВСЕ ПОЛЯ");
                return;
            }
            RequestTableCRUDClient client = new RequestTableCRUDClient();
            RequestTable[] request = await client.ReadRequestTableAsync();

            RequestTable ss = request.Where(i => i.IdRequest == this.id).ToArray()[0];

            if(ss.AccountBalance <0)
            {
                MessageBox.Show("Невозможно выполнить заявку: Отрицательный баланс");
                return;
            }

            if (ss.IdRequestState != await getIdStateCancel())
            {

                await getIdManager();                
                await getIdSysAdmin();
                await getIdBrigade();

                /*
                await client.UpdateRequestTableAsync(
                    -1,-1, "", long.Parse( textBoxCountTV.Text), double.Parse( textBoxSpeed.Text), long.Parse( textBoxPing.Text), 
                    textBoxCommentMech.Text, DateTime.Now,
                    this.idWorker, this.idManager, this.idSysAdmin, textBoxReview.Text, -1, -1, int.Parse( TextBoxID.Text));
               */

                await client.UpdateRequestTableAsync
                    (
                        -1,
                        -1,
                        "",
                        long.Parse(dataGridView1.Rows[0].Cells[1].Value.ToString()),
                        dataGridView1.Rows[0].Cells[2].Value.ToString(),
                        dataGridView1.Rows[0].Cells[3].Value.ToString(),
                        dataGridView1.Rows[0].Cells[4].Value.ToString(),
                        DateTime.Now,
                        this.idBrigade,
                        this.idManager,
                        this.idSysAdmin,
                        dataGridView1.Rows[0].Cells[7].Value.ToString(),
                        await getIdStateDone(),
                        "",
                        -1,
                        "",
                        "",
                        "",
                        "",
                        int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString())
                    );
            

                await refreshGrid();
            }
            else
            {
                MessageBox.Show("Невозможно выполнить заявку: ОНА БЫЛА ОТМЕНЕНА");
            }
            await client.CloseAsync();
        }
    }
}
