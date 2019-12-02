﻿namespace Software_Engineering_Assignment.Support_Classes
{
    public class Bay
    {
        public int BayNumber;

        public delegate void patientAlarmEvent(Patient patient, bool on);
        public patientAlarmEvent AlarmThrown = delegate { };

        /// <summary>
        /// Structure to hold information on bays including bedsides/patients
        /// </summary>
        /// <param name="bayNumber"></param>
        public Bay(int bayNumber)
        {
            BayNumber = bayNumber;
            patient1 = DatabaseConnector.Instance.GetPatient(bayNumber, 1);
            patient2 = DatabaseConnector.Instance.GetPatient(bayNumber, 2);
            patient3 = DatabaseConnector.Instance.GetPatient(bayNumber, 3);
            patient4 = DatabaseConnector.Instance.GetPatient(bayNumber, 4);
            patient5 = DatabaseConnector.Instance.GetPatient(bayNumber, 5);
            patient6 = DatabaseConnector.Instance.GetPatient(bayNumber, 6);
            patient7 = DatabaseConnector.Instance.GetPatient(bayNumber, 7);
            patient8 = DatabaseConnector.Instance.GetPatient(bayNumber, 8);

            patient1.ThrowPatientAlarm += PatientAlarmThrown;
            patient2.ThrowPatientAlarm += PatientAlarmThrown;
            patient3.ThrowPatientAlarm += PatientAlarmThrown;
            patient4.ThrowPatientAlarm += PatientAlarmThrown;
            patient5.ThrowPatientAlarm += PatientAlarmThrown;
            patient6.ThrowPatientAlarm += PatientAlarmThrown;
            patient7.ThrowPatientAlarm += PatientAlarmThrown;
            patient8.ThrowPatientAlarm += PatientAlarmThrown;
        }

        public void PatientAlarmThrown(Patient patient, bool on)
        {
            AlarmThrown(patient, on);
        }

        /// <summary>
        /// This method returns a patient based on the bedside number
        /// </summary>
        /// <param name="bedNumber"></param>
        /// <returns></returns>
        public Patient GetPatient(int bedNumber)
        {
            switch (bedNumber)
            {
                case 1: return patient1;
                case 2: return patient2;
                case 3: return patient3;
                case 4: return patient4;
                case 5: return patient5;
                case 6: return patient6;
                case 7: return patient7;
                case 8: return patient8;
                default: return new Patient();
            }
        }

        //Patients from bed 1 to 8
        readonly Patient patient1;
        readonly Patient patient2;
        readonly Patient patient3;
        readonly Patient patient4;
        readonly Patient patient5;
        readonly Patient patient6;
        readonly Patient patient7;
        readonly Patient patient8;
    }
}
