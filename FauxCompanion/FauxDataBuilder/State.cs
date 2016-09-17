using EnergonSoftware.FauxCompanion;

namespace EnergonSoftware.FauxDataBuilder
{
    public sealed class State
    {
        public FauxData Data { get; private set; } = new FauxData();

        public string LastFileName { get; set; } = string.Empty;

        public void Reset()
        {
            Data = new FauxData();
        }

        public bool Open(string filename)
        {
// TODO: this should only set if the read was successful
            LastFileName = filename;

// TODO: read the file and deserialize the data
return false;
        }

        public bool Save()
        {
            return Save(LastFileName);
        }

        public bool Save(string filename)
        {
// TODO: this should only set if the save was successful
            LastFileName = filename;

// TODO: serialize the data and save the file
return false;
        }
    }
}
