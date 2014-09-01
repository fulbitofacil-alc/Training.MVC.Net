using System.Collections.Generic;
using System.ComponentModel;

namespace MVC5Course.Automapper.Models.Basic
{
    public class PersonViewModel
    {
        [DisplayName("Person Id")]
        public int Id { get; set; }

        [DisplayName("Person Firstname")]
        public string Firstname { get; set; }

        [DisplayName("Person surname")]
        public string Surname { get; set; }

        public AddressViewModel Address { get; set; }

        public List<NoteViewModel> Notes { get; set; }
    }

    public class AddressViewModel
    {
        [DisplayName("Address Line One")]
        public string PersonAddressLineOne { get; set; }

        [DisplayName("Country Of Residence")]
        public string PersonCountryOfResidence { get; set; }

        [DisplayName("Post Code")]
        public string PostCode { get; set; }
    }

    public class NoteViewModel
    {
        [DisplayName("Note Id")]
        public int Id { get; set; }

        [DisplayName("Note Text")]
        public string Text { get; set; }
    }
}