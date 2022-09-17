namespace CSharpLabs.Windows
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            this.InitializeComponent();
            this.task_combobox.SelectedIndex = default(int);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            switch (this.task_combobox.SelectedIndex)
            {
                case 0: new LabTask1().ShowDialog(); break;
                case 1: new LabTask2().ShowDialog(); break;
                default: break;
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            string taskinfo_message = this.task_combobox.SelectedIndex == 0 ? "1) ��������� ���������\n" +
                "2) ��������� ����� ������� ����.\n3) ����� �� ���������� ��������� �������.\n4) ���������� " +
                "�������� �����" : "������� ��������� �� ���������� ������� � ����� ����������� ������";

            MessageBox.Show(taskinfo_message, "���������� �������");
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