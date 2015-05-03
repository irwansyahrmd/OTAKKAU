using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class RandomTextQuestionGenerator
{
    private List<TextQuestion> listTextQuestions;
	private ArrayList index;
    public RandomTextQuestionGenerator()
    {
        listTextQuestions = new List<TextQuestion>();
		index = new ArrayList ();
        InitQuestions();
    }

    public TextQuestion GetRandomTextQuestion()
    {
        int randomIndex = Random.Range(0, listTextQuestions.Count);
		Debug.Log (listTextQuestions.Count);
        TextQuestion textQuestion = listTextQuestions[randomIndex];
        listTextQuestions.RemoveAt(randomIndex);
        return textQuestion;
    }

    public void AddTextQuestion(TextQuestion textQuestion)
    {
        listTextQuestions.Add(textQuestion);
    }

    public void InitQuestions()
    {
        AddTextQuestion(new TextQuestion("Gunung tertinggi di dunia", "Everest"));
        AddTextQuestion(new TextQuestion("Siapa founder Facebook.com ", "Mark Zuckerberg"));
        AddTextQuestion(new TextQuestion("Siapa presiden Indonesia ke - 20 ", "Soeharto"));
        AddTextQuestion(new TextQuestion("Sebutan kicauan pada twitter ", "tweet"));
        AddTextQuestion(new TextQuestion("Alat musik tradisional Jawa Barat ", "Angklung"));
        AddTextQuestion(new TextQuestion("Kitab suci umat hindu ", " Weda"));
        AddTextQuestion(new TextQuestion("Lagu daerah ‘Anak Kambing Saya’ berasal dari provinsi", "Nusa Tenggara Timur"));
        AddTextQuestion(new TextQuestion("Mata uang Thailand", "Baht"));
        AddTextQuestion(new TextQuestion("Siapakah dokter wanita pertama di dunia", "Elizabeth Blackwell"));
        AddTextQuestion(new TextQuestion("Serangga yang menghasilkan madu ", "Lebah"));
        AddTextQuestion(new TextQuestion("Kota tempat diselenggarakannya Piala Dunia 2022", "Qatar"));
        AddTextQuestion(new TextQuestion("Kemampuan bunglon untuk mengubah warna sesuai lingkungannya disebut", "Mimikri"));
        AddTextQuestion(new TextQuestion("Presiden pertama Amerika Serikat", "George Washington"));
        AddTextQuestion(new TextQuestion("Kota di Jepang yang terkena bom Atom pada PD II", "Nagasaki"));
        AddTextQuestion(new TextQuestion("Mahluk mitologi mesir bertubuh singa berkepala manusia disebut", "Sphinx"));
        AddTextQuestion(new TextQuestion("Sebutan untuk makhluk hidup berdarah panas", "Homoiterm"));
        AddTextQuestion(new TextQuestion("SEA Games ke-V diadakan di kota ", "Rangoon"));
        AddTextQuestion(new TextQuestion("Indigo adalah sebutan sebuah warna, yang dalam bahasa sehari - sehari dikenal dengan warna ", "Ungu"));
        AddTextQuestion(new TextQuestion("Kota paling boros listrik di asia adalah", "Tokyo"));
        AddTextQuestion(new TextQuestion("Fraksi gabungan dua partai atau lebih di parlemen disebut ", "Koalisi"));
        AddTextQuestion(new TextQuestion("Angkor Vat berada dari negara", "Kamboja"));
        AddTextQuestion(new TextQuestion("Gurun pasir terluas di dunia adalah ", "Sahara"));
        AddTextQuestion(new TextQuestion("Spongebob Squarepants bertempat tinggal di", "Bikini Bottom"));
        AddTextQuestion(new TextQuestion("Musuh Tarzan yang membunuh gorilla adalah", "Clyton"));
        AddTextQuestion(new TextQuestion("Istilah yang digunakan untuk orang-orang yang mendiami daerah kutub utara", "Eskimo"));
        AddTextQuestion(new TextQuestion("Alat pengukur gempa disebut", "Seismograf"));
        AddTextQuestion(new TextQuestion("Alat pernafasan belalang", "Trakea"));
        AddTextQuestion(new TextQuestion("Ideologi Indonesia ", "Pancasila"));
        AddTextQuestion(new TextQuestion("Kota terpadat di dunia adalah", "Seoul"));
        AddTextQuestion(new TextQuestion("Apakah ibukota Maluku Utara", "Ternate"));
        AddTextQuestion(new TextQuestion("Sebutan untuk bagian belakang kapal", "Buritan"));
        AddTextQuestion(new TextQuestion("Nama galaksi tempat tata surya kita berada", "Milky Way"));
        AddTextQuestion(new TextQuestion("Sekretaris Jenderal PBB (Perserikatan Bangsa-Bangsa) pertama", "Sir Gladwyn Jebb"));
        AddTextQuestion(new TextQuestion("Vokalis The Beatles", "John Lennon"));
        AddTextQuestion(new TextQuestion("Jembatan terpanjang di dunia ", "Danyang–Kunshan Grand Bridge"));
        AddTextQuestion(new TextQuestion("Negeri 1001 malam adalah sebutan untuk negara", "Irak"));
        AddTextQuestion(new TextQuestion("Air terjun tertinggi di dunia", "Angel Falls"));
        AddTextQuestion(new TextQuestion("Terima Kasih dalam bahasa Spanyol", "Gracias"));
        AddTextQuestion(new TextQuestion("Baju adat jepang yang paling terkenal ", "Kimono"));
        AddTextQuestion(new TextQuestion("Jepang terkenal dengan pohon ", "Sakura"));
        AddTextQuestion(new TextQuestion("King of Pop dunia ", "Michael Jackson"));
        AddTextQuestion(new TextQuestion("Nama nyamuk penyebab demam berdarah ", "aedes aegypti"));
        AddTextQuestion(new TextQuestion("Kain khas daerah sumatera selatan ", "Songket"));
        AddTextQuestion(new TextQuestion("Kekasih Spiderman", "Gwen Stacy"));
        AddTextQuestion(new TextQuestion("Negara di Benua Amerika Selatan, yang dilalui garis khatulistiwa", "Brasil"));
        AddTextQuestion(new TextQuestion("Suku asli jepang ", "Ainu"));
        AddTextQuestion(new TextQuestion("Negara yang telah meraih piala dunia sebanyak 4 kali ", "Argentina"));
        AddTextQuestion(new TextQuestion("Bahasa pemrograman yang mirip dengan nama hewan", "Phyton"));
        AddTextQuestion(new TextQuestion("Kantor pusat Google", "Mountain View"));
        AddTextQuestion(new TextQuestion("Nama jalan yang menjadi tempat pertukaran saham terbesar di dunia", "Wall Street"));
        AddTextQuestion(new TextQuestion("Pendiri perusahaan animasi Disney", "Walt Elias Disney"));
        AddTextQuestion(new TextQuestion("1,1,2,3,5,8,13,21,44,... merupakan deret ", "Fibonacci"));
        AddTextQuestion(new TextQuestion("Perusahaan audio terkenal dari Amerika ", "Dolby"));
        AddTextQuestion(new TextQuestion("Nama Istri Pangeran William (putra lady Diana) ", "Catherine Middleton"));
        AddTextQuestion(new TextQuestion("Kepolisian Republik Indonesia ", "POLRI"));
        AddTextQuestion(new TextQuestion("Cantik, Sunda", "Geulis"));
        AddTextQuestion(new TextQuestion("Ibukota Queensland, negara bagian Australia", "Brisbane"));
        AddTextQuestion(new TextQuestion("Kumpulan Superheroes Marvel", "Avengers"));
        AddTextQuestion(new TextQuestion("Presiden Pertama Indonesia", "Soekarno"));
        AddTextQuestion(new TextQuestion("Nama asli Batman", "Bruce Wayne"));
        AddTextQuestion(new TextQuestion("Perusahaan Handphone asal Kanada", "Blackberry"));
        AddTextQuestion(new TextQuestion("Android 5.0", "Lollipop"));
        AddTextQuestion(new TextQuestion("Pemeran Utama James Bond", "Daniel Craig"));
        AddTextQuestion(new TextQuestion("Raja Keraton Yogyakarta", "Hamengkubuwono"));
        AddTextQuestion(new TextQuestion("Penguasa Laut Selatan", "Nyi Roro Kidul"));
        AddTextQuestion(new TextQuestion("Pemilik Trans TV", "Chairul Tanjung"));
        AddTextQuestion(new TextQuestion("Sepatu Sejuta Umat", "Converse"));
        AddTextQuestion(new TextQuestion("Induk Organisasi Bulutangkis Indonesia", "PBSI"));
        AddTextQuestion(new TextQuestion("Kompetisi mobil jet darat", "F1"));
        AddTextQuestion(new TextQuestion("BUMN Telekomunikasi Indonesia", "Telkom"));
        AddTextQuestion(new TextQuestion("Perusahaan Teknologi bernama buah", "Apple"));
        AddTextQuestion(new TextQuestion("Organisasi Islam berasal dari Yogyakarta", "Muhammadiyah"));
        AddTextQuestion(new TextQuestion("Ibukota Timor Timor", "Dili"));
        AddTextQuestion(new TextQuestion("Suku asli Australia", "Aborigin"));
        AddTextQuestion(new TextQuestion("Indonesia dan Malaysia", "Serumpun"));
        AddTextQuestion(new TextQuestion("1 Semenanjung, Beda ideologi", "Korea"));
        AddTextQuestion(new TextQuestion("Pusat Tata Surya Kita", "Matahari"));
        AddTextQuestion(new TextQuestion("Musuh abadi Batman", "Joker"));
        AddTextQuestion(new TextQuestion("Superhero dengan kekuatan cincin", "Green lantern"));
        AddTextQuestion(new TextQuestion("Largest Indonesian online Community", "Kaskus"));
        AddTextQuestion(new TextQuestion("Suku asal Sumatera Barat", "Minangkabau"));
        AddTextQuestion(new TextQuestion("Vendor Komputer asal Taiwan", "ASUS"));
        AddTextQuestion(new TextQuestion("Saingan Berat ATI", "Nvidia"));
        AddTextQuestion(new TextQuestion("Saingan Berat Intel", "AMD"));
        AddTextQuestion(new TextQuestion("Smartphone buatan Apple", "Iphone"));
        AddTextQuestion(new TextQuestion("Benua Terbesar di Dunia", "Asia"));
        AddTextQuestion(new TextQuestion("Negara di 2 Benua", "Rusia"));
        AddTextQuestion(new TextQuestion("Nama Aliansi Jerman, Italia, dan Jepang saat perang dunia II", "AXIS"));
        AddTextQuestion(new TextQuestion("Pemimpin Bangsa Mongol yang terkenal", "Gengis Khan"));
        AddTextQuestion(new TextQuestion("Imperium terbesar di dunia", "Britania Raya"));
        AddTextQuestion(new TextQuestion("panggilan untuk anak dari paman / bibi", "Sepupu"));
        AddTextQuestion(new TextQuestion("Ikatan keluarga", "Marga"));
        AddTextQuestion(new TextQuestion("Ibukota Provinsi Jawa Tengah", "Semarang"));
        AddTextQuestion(new TextQuestion("Kucing Robot dari abad 22", "Doraemon"));


    }
}

