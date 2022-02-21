using MongoDB.Bson;
using System;
using System.ComponentModel.DataAnnotations;

namespace MongoDBLibrary
{
    public class PersonModel
    {
        public ObjectId _id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [RegularExpression(@"^([^0-9]*)$", ErrorMessage = "First name only allows letters.")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Middle name is required.")]
        [RegularExpression(@"^([^0-9]*)$", ErrorMessage = "Middle name only allows letters.")]
        public string middleName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [RegularExpression(@"^([^0-9]*)$", ErrorMessage = "Last name only allows letters.")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Date of birth is required.")]
        public DateTime dateOfBirth { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string address { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string gender { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Please enter valid age number.")]
        public int age { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        public string contactNumber { get; set; }

        [Required(ErrorMessage = "Number of persons in the house is required.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid number.")]
        public int NumberOfPersonsInTheHouse { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Invalid email.")]
        public string email { get; set; }
    }
}
