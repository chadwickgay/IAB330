using wheresmystuff.Interfaces;
using Xamarin.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using wheresmystuff.Models;

namespace wheresmystuff.Views
{
    public partial class DataExportPage : ContentPage
    {
        public DataExportPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        void ExportData(object sender, System.EventArgs e)
        {
            var fileService = DependencyService.Get<ISaveAndLoad>();

            // Prepare all data for export
            WheresMyStuffExport export = new WheresMyStuffExport();

            // Setup a memory stream to write into
            using (MemoryStream jsonStream = new MemoryStream())
            {
                // Prepare a JSON Serializer
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(WheresMyStuffExport));

                // Write our export object to the stream
                ser.WriteObject(jsonStream, export);

                // Reset the stream to the start
                jsonStream.Position = 0;

                // Write the stream to file
                using (StreamReader sr = new StreamReader(jsonStream)) { 
                    fileService.SaveTextAsync("WheresMyStuffExport.json", sr.ReadToEnd());
                }

                DisplayAlert("Success", "Successfully exported data to file. Check the data directory for the WheresMyStuff application.", "OK");
            }
        }
    }
}