namespace Medical_bot;

internal class MedicalBot
{
    private readonly string BotName = "bob";

    private void PrescribeMedication(Patient patient)
    {
        string GetDosage(string medicineName)
        {
            if (medicineName == "Ibuprofen")
            {
                if (patient.GetAge() < 18) return "400mg";
                return "800mg";
            }

            else if (medicineName == "Diphenhydramine")
            {
                if (patient.GetAge() < 18) return "50mg";
                return "300mg";
            }

            else if (medicineName == "Dimenhydrinate")
            {
                if (patient.GetAge() < 18) return "50mg";
                return "400mg";
            }

            else if (medicineName == "Metformin")
            {
                return "500mg";
            }

            return "Dosage information not available for the given medicine.";
        }

        if (patient.GetSymptomCode() == "headache")
        {
            patient.SetPrescription("Ibuprofen" + GetDosage("Ibuprofen"));
        }
        else if (patient.GetSymptomCode() == "rashes")
        {
            patient.SetPrescription("Diphenhydramine" + GetDosage("Diphenhydramine"));
        }
        else if (patient.GetSymptomCode() == "dizziness")
        {
            if (patient.GetMedicalHistory() == "diabetes")
                patient.SetPrescription("Metformin" + GetDosage("Metformin"));
            patient.SetPrescription("Dimenhydrinate" + GetDosage("Dimenhydrinate"));
        }
    }

    internal class Patient
    {
        private string _name = "";
        private int _age;
        private string _gender = "";
        private string _medicalHistory = "";
        private string _symptomCode = "";
        private string _prescription = "";

        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

        public string GetGender()
        {
            return _gender;
        }

        public string GetMedicalHistory()
        {
            return _medicalHistory;
        }

        public string GetSymptomCode()
        {
            return _symptomCode;
        }

        public string GetPrescription()
        {
            return _prescription;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public void SetAge(int newAge)
        {
            _age = newAge;
        }

        public void SetGender(string newGender)
        {
            _gender = newGender;
        }

        public void SetMedicalHistory(string newMedicalHistory)
        {
            _medicalHistory = newMedicalHistory;
        }

        public void SetSymptomCode(string newSymptomCode)
        {
            _symptomCode = newSymptomCode;
        }

        public void SetPrescription(string newPrescription)
        {
            _prescription = newPrescription;
        }
    }

    public static void Main(string[] args)
    {
        var bot = new MedicalBot();
        var patient = new Patient();

        Console.WriteLine("Hi, I'm " + bot.BotName + ". I'm here to help you in your medication.");
        Console.WriteLine("What is your name?");
        patient.SetName(Console.ReadLine());
        Console.WriteLine("How old are you?");
        patient.SetAge(int.Parse(Console.ReadLine()));
        Console.WriteLine("What is your gender?");
        patient.SetGender(Console.ReadLine());
        Console.WriteLine("What is your medical history?");
        patient.SetMedicalHistory(Console.ReadLine());

        Console.WriteLine("Welcome " + patient.GetName() + ", " + patient.GetAge() + ".");
        Console.WriteLine("Which of the following symptoms do you have:");
        Console.WriteLine("1. Headache");
        Console.WriteLine("2. Rashes");
        Console.WriteLine("3. Dizziness");

        patient.SetSymptomCode(Console.ReadLine());
        bot.PrescribeMedication(patient);
        Console.WriteLine("Your prescription based on your age, symptoms and medical history: " +
                          patient.GetPrescription());
        Console.WriteLine("Thank you for coming.");
    }
}