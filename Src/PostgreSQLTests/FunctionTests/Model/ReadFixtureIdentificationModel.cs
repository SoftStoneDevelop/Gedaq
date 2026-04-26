namespace Tests.FunctionTests.Model
{
    public class ReadFixtureIdentificationModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ReadFixtureCountryModel Country { get; set; }
    }
}