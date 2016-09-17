namespace EnergonSoftware.FauxDataBuilder
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static App Instance => (App)Current;

        public State State { get; } = new State();
    }
}
