using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using wheresmystuff.Models;
using System.Linq;

namespace wheresmystuff.Helpers
{
    public static class ItemHelper
    {

        public static ObservableCollection<Item> Items { get; set; }

        /// <summary>
        /// Setup some default Items for debugging/sample
        /// </summary>
        static ItemHelper()
        {

            Items = new ObservableCollection<Item>();
            Items.Add(new Item
            {
                Name = "Chair",
                BoxNumber = "1",
                Description = "A chair is a piece of furniture with a raised surface supported by legs, commonly used to seat a single person.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/e/e2/Panton_Stuhl.jpg"
            });

            Items.Add(new Item
            {
                Name = "Lava Lamp",
                BoxNumber = "2",
                Description = "A lava lamp (or Astro lamp) is a decorative novelty item, invented in 1963 by British accountant Edward Craven Walker, the founder of the British lighting company Mathmos.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/1990s_Mathmos_Astro.jpg/170px-1990s_Mathmos_Astro.jpg"
            });

            Items.Add(new Item
            {
                Name = "Hat",
                BoxNumber = "3",
                Description = "A hat is a head covering which is worn for various reasons, including protection against weather conditions, ceremonial reasons such as university graduation, religious reasons, safety, or as a fashion accessory.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Gruppbild_sv_arbetsförmän_vid_Läten_Hospitalbygge_-_Nordiska_Museet_-_NMA.0056803.jpg/220px-Gruppbild_sv_arbetsförmän_vid_Läten_Hospitalbygge_-_Nordiska_Museet_-_NMA.0056803.jpg"
            });

            Items.Add(new Item
            {
                Name = "jake",
                BoxNumber = "4",
                Description = "jake",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Gruppbild_sv_arbetsförmän_vid_Läten_Hospitalbygge_-_Nordiska_Museet_-_NMA.0056803.jpg/220px-Gruppbild_sv_arbetsförmän_vid_Läten_Hospitalbygge_-_Nordiska_Museet_-_NMA.0056803.jpg"
            });

        }
    }
}