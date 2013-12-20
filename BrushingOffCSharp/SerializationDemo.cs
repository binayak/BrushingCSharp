// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationDemo.cs" company="">
//   
// </copyright>
// <summary>
//   The serialization demo.
//   DOT NET can do 4 different types of serialization
//   1. binary serialization
//   2. soap serialization
//   3. Custom serialization
//   4. XML serialization
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BrushingOffCSharp
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    /// <summary>
    /// The serialization demo.
    /// </summary>
    public class SerializationDemo
    {
        /// <summary>
        /// The _ filename.
        /// </summary>
        private const string Filename = "myEmployee.xml";

        /// <summary>
        /// The main for serialization.
        /// </summary>
        public void MainForSerialization()
        {
            EmployeeDetails em = new EmployeeDetails();
            this.DoSerialize(em,Filename);
            this.ReadFile();
            this.DoDeSerialize(em,Filename);
        }

        /// <summary>
        /// The read file.
        /// </summary>
        public void ReadFile()
        {
            StreamReader readfile = new StreamReader(Filename);
            Console.WriteLine(readfile.ReadToEnd());
            readfile.Close();
        }

        /// <summary>
        /// The do serialize.
        /// </summary>
        /// <param name="o">
        /// The o.
        /// </param>
        /// <param name="fileName">
        /// The file Name.
        /// </param>
        public void DoSerialize(object o, string fileName)
        {
            XmlSerializer employeeSerializer = new XmlSerializer(typeof(EmployeeDetails));

            StreamWriter employeeStreamWriter = new StreamWriter(fileName, false);

            employeeSerializer.Serialize(employeeStreamWriter, o);

            employeeStreamWriter.Close();
        }

        /// <summary>
        /// This will deserialize
        /// </summary>
        /// <param name="o">Passing object to deserialize to</param>
        /// <param name="filename">passing file name as parameter</param>
        private void DoDeSerialize(object o, string filename)
        {
            XmlSerializer empDeSerializer = new XmlSerializer(typeof(EmployeeDetails));

            FileStream file = new FileStream(filename, FileMode.Open);

            o = (EmployeeDetails)empDeSerializer.Deserialize(file);

            file.Close();

            Console.WriteLine("Deserialized!!");


        }
    }

    /// <summary>
    /// The employee details.
    /// </summary>
    public class EmployeeDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDetails"/> class.
        /// AND CONSTRUCTORS DO NOT HAVE RETURN TYPE
        /// </summary>
        public EmployeeDetails()
        {
            this.Name = "Binayak Silwal";
            this.Age = 30;
            this.Address = "Glencoe Avn";
            this.Salary = 1000000;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        public int Salary { get; set; }
    }

}
