namespace cs_labs_winform
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.task_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            switch (this.task_combobox.SelectedIndex) 
            {
                case 0: new LabTask1().ShowDialog(); break;
                case 1: new Form3().ShowDialog(); break;
                    // ������ 2 �������
                default: break;
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            switch (this.task_combobox.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("1) ���� x, y, z. ��������� a, b\n2) ��������� ����� ������� ���� � ������ H � ��������� ��������� V.\n" +
                        "3) ����������, ����� �� ���������� ��������� � �������������� a, b � c �������.\n" +
                        "4) ��������� ��������� ���������� �������� ��������� �������������� �����", "���������� �������");
                    break;
                case 1:
                    MessageBox.Show("1) ������� ��������� �������� ���������� ������� ��������\n" +
                        "2) �������� ����� ����������� ������ ���������.", "���������� �������");
                    break;
                default: break;
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� ������������ ������: �������� ����� ���������� ����������" +
                "���������������� ����������� ��� ���������������� �����-������ � ��������" +
                "���������� ����� C# �� ��������� .NET Framework.", "������� ��������");
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

    }
}