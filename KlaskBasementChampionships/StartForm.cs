namespace KlaskBasementChampionships
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            Tournament tournament = new Tournament(); //create the tournament
            if (!int.TryParse(txtPlayerCount.Text, out int n)) //make sure they actually put a goddamn number in there
            {
                return;
            }
            int playerCount = Int16.Parse(txtPlayerCount.Text); //get amount of players
            for (int i = 0; i < playerCount; i++) //create all the player objects
            {
                tournament.participants.Add(new Player());
            }
            GetNamesForm getNames = new GetNamesForm(tournament); //initialize new form, pass tournament object
            getNames.ShowDialog(); //show new form

        }

        //only allow numbers for player count, obviously
        private void txtPlayerCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}