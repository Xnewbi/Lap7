using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LabExerciseWeek11.EmployeeData;

namespace LabExerciseWeek11
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Tugas Lab 8 (Pertemuan 11) = Inheritance, Polymorphism, Abstraction, & Collection";

			//making objects for all employees
			KaryawanTetap karyawanTetap = new KaryawanTetap();
			karyawanTetap.NIK = "123.444.324";
			karyawanTetap.Nama = "John Michael";
			karyawanTetap.GajiBulanan = 25000000;

			KaryawanHarian karyawanHarian = new KaryawanHarian();
			karyawanHarian.NIK = "123.453.663";
			karyawanHarian.Nama = "Tono Sutono";
			karyawanHarian.JumlahJamKerja = 11;
			karyawanHarian.UpahPerJam= 15000;

			Sales sales = new Sales();
			sales.NIK = "123.425.663";
			sales.Nama = "Ari Subekti";
			sales.JumlahPenjualan = 25;
			sales.Komisi = 350000;

			//object class collection
			List<Karyawan> listKaryawan = new List<Karyawan>();

			listKaryawan.Add(karyawanTetap);
			listKaryawan.Add(karyawanHarian);
			listKaryawan.Add(sales);

			int numberSequence = 1;

			Console.WriteLine("DAFTAR GAJI KARYAWAN PT SEJAHTERA ANUGERAH ABADI");
			Console.WriteLine("------------------------------------------------");

			foreach(Karyawan emps in listKaryawan)
			{
				Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3:N0}",
					numberSequence, emps.NIK, emps.Nama, emps.Gaji());

				numberSequence++;
			}

			Console.WriteLine("------------------------------------------------");
				
			Console.ReadKey();
		}
	}
}