using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan_6
{
    class Dosen
    {
        private int id;
        private string nama;
        private int Nik;
        private string gender;
        private string course;
        public Dosen() {
            id = 1;

            nama = "Dosen Pengampu";
            Nik = 123456789;
            gender = "Male";
            course = "Pemrograman Berorientasi Objek";
        }

        public void attDosen(string name, int nik)
        {
            nama = name;
            Nik = nik;
        }

        public void addCourse(string newCourse)
        {
            course += ", " + newCourse;
        }
        public void display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("Nik: " + Nik);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Course: " + course);

        }
    }
}
