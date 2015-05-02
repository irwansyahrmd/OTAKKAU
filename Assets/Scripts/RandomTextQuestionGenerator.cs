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
        initQuestion();
		initIndex ();
    }

	private void initIndex(){
		for (int i = 0; i < listTextQuestions.Count; i++){
			index.Add(i);
		}
	}

    public TextQuestion getRandomTextQuestion()
    {
        int randomIndex = Random.Range(0, listTextQuestions.Count);
		Debug.Log (listTextQuestions.Count);
        TextQuestion textQuestion = listTextQuestions[randomIndex];
        listTextQuestions.RemoveAt(randomIndex);
        return textQuestion;
    }

    public void addTextQuestion(TextQuestion textQuestion)
    {
        listTextQuestions.Add(textQuestion);
    }

    public void initQuestion()
    {
        //addTextQuestion(new TextQuestion("Gunung tertinggi di dunia", "Everest"));
        //addTextQuestion(new TextQuestion("Founder Facebook.com", "Zuckerberg"));
        //addTextQuestion(new TextQuestion("Presiden Indonesia ke - 2 ?", "Soeharto"));
        //addTextQuestion(new TextQuestion("Sebutan kicauan pada twitter", "tweet"));
        //addTextQuestion(new TextQuestion("Kitab suci umat hindu", "weda"));
        //addTextQuestion(new TextQuestion("Mata uang Thailand", "baht"));
        //addTextQuestion(new TextQuestion("Dokter wanita pertama di dunia", "blackwell"));
        //addTextQuestion(new TextQuestion("Serangga penghasil madu", "lebah"));
        //addTextQuestion(new TextQuestion("Negara penyelenggara Piala Dunia 2022?", "qatar"));
        //addTextQuestion(new TextQuestion("Kemampuan bunglon untuk mengubah warna kulit", "mimikri"));
        //addTextQuestion(new TextQuestion("Presiden pertama Amerika Serikat", "abraham  lincoln"));
        //addTextQuestion(new TextQuestion("Kota di Jepang yang terkena bom Atom pada PD II", "nagasaki"));
        //addTextQuestion(new TextQuestion("Alat musik tradisional Jawa Barat", "angklung"));

        addTextQuestion(new TextQuestion("Gunung tertinggi di dunia", "Everest"));
        addTextQuestion(new TextQuestion("Siapa founder Facebook.com ", "Mark Zuckerberg"));
        addTextQuestion(new TextQuestion("Siapa presiden Indonesia ke - 20 ", "Soeharto"));
        addTextQuestion(new TextQuestion("Sebutan kicauan pada twitter ", "tweet"));
        addTextQuestion(new TextQuestion("Alat musik tradisional Jawa Barat ", "Angklung"));
        addTextQuestion(new TextQuestion("Kitab suci umat hindu ", " Weda"));
        addTextQuestion(new TextQuestion("Lagu daerah ‘Anak Kambing Saya’ berasal dari provinsi", "Nusa Tenggara Timur"));
        addTextQuestion(new TextQuestion("Mata uang Thailand", "Baht"));
        addTextQuestion(new TextQuestion("Siapakah dokter wanita pertama di dunia", "Elizabeth Blackwell"));
        addTextQuestion(new TextQuestion("Sebutan orang yang memiliki lebih dari 1 istri ", "Bajingan"));
        addTextQuestion(new TextQuestion("Serangga yang menghasilkan madu ", "Lebah"));
        addTextQuestion(new TextQuestion("Kota tempat diselenggarakannya Piala Dunia 2022", "Qatar"));
        addTextQuestion(new TextQuestion("Kemampuan bunglon untuk mengubah warna sesuai lingkungannya disebut", "Mimikri"));
        addTextQuestion(new TextQuestion("Presiden pertama Amerika Serikat", "George Washington"));
        addTextQuestion(new TextQuestion("Kota di Jepang yang terkena bom Atom pada PD II", "Nagasaki"));
        addTextQuestion(new TextQuestion("Mahluk mitologi mesir bertubuh singa berkepala manusia disebut", "Sphinx"));
        addTextQuestion(new TextQuestion("Sebutan untuk makhluk hidup berdarah panas", "Homoiterm"));
        addTextQuestion(new TextQuestion("SEA Games ke-V diadakan di kota ", "Rangoon"));
        addTextQuestion(new TextQuestion("Indigo adalah sebutan sebuah warna, yang dalam bahasa sehari - sehari dikenal dengan warna ", "Ungu"));
        addTextQuestion(new TextQuestion("Kota paling boros listrik di asia adalah", "Tokyo"));
        addTextQuestion(new TextQuestion("Fraksi gabungan dua partai atau lebih di parlemen disebut ", "Koalisi"));
        addTextQuestion(new TextQuestion("Angkor Vat berada dari negara", "Kamboja"));
        addTextQuestion(new TextQuestion("Gurun pasir terluas di dunia adalah ", "Sahara"));
        addTextQuestion(new TextQuestion("Spongebob Squarepants bertempat tinggal di", "Bikini Bottom"));
        addTextQuestion(new TextQuestion("Musuh Tarzan yang membunuh gorilla adalah", "Clyton"));
        addTextQuestion(new TextQuestion("Istilah yang digunakan untuk orang-orang yang mendiami daerah kutub utara", "Eskimo"));
        addTextQuestion(new TextQuestion("Alat pengukur gempa disebut", "Seismograf"));
        addTextQuestion(new TextQuestion("Alat pernafasan belalang", "Trakea"));
        addTextQuestion(new TextQuestion("Ideologi Indonesia ", "Pancasila"));
        addTextQuestion(new TextQuestion("Kota terpadat di dunia adalah", "Seoul"));
        addTextQuestion(new TextQuestion("Sebutan untuk wanita misterius dalam kasus korupsi impor daging sapi", "bunda putri"));
        addTextQuestion(new TextQuestion("Provinsi termuda di Indonesia", "Kalimantan Utara"));
        addTextQuestion(new TextQuestion("Apakah ibukota Maluku Utara", "Ternate"));
        addTextQuestion(new TextQuestion("Sebutan untuk bagian belakang kapal", "Buritan"));
        addTextQuestion(new TextQuestion("Nama galaksi tempat tata surya kita berada", "Milky Way"));
        addTextQuestion(new TextQuestion("Sekretaris Jenderal PBB (Perserikatan Bangsa-Bangsa) pertama", "Sir Gladwyn Jebb"));
        addTextQuestion(new TextQuestion("Vokalis The Beatles", "John Lennon"));
        addTextQuestion(new TextQuestion("Jembatan terpanjang di dunia ", "Danyang–Kunshan Grand Bridge"));
        addTextQuestion(new TextQuestion("Negeri 1001 malam adalah sebutan untuk negara", "Irak"));
        addTextQuestion(new TextQuestion("Air terjun tertinggi di dunia", "Angel Falls"));
        addTextQuestion(new TextQuestion("Terima Kasih dalam bahasa Spanyol", "Gracias"));
        addTextQuestion(new TextQuestion("Baju adat jepang yang paling terkenal ", "Kimono"));
        addTextQuestion(new TextQuestion("Jepang terkenal dengan pohon ", "Sakura"));
        addTextQuestion(new TextQuestion("King of Pop dunia ", "Michael Jackson"));
        addTextQuestion(new TextQuestion("Nama nyamuk penyebab demam berdarah ", "aedes aegypti"));
        addTextQuestion(new TextQuestion("Kain khas daerah sumatera selatan ", "Songket"));
        addTextQuestion(new TextQuestion("Kekasih Spiderman", "Gwen Stacy"));
        addTextQuestion(new TextQuestion("Negara di Benua Amerika Selatan, yang dilalui garis khatulistiwa", "Brasil"));
        addTextQuestion(new TextQuestion("Suku asli jepang ", "Ainu"));
        addTextQuestion(new TextQuestion("Negara yang telah meraih piala dunia sebanyak 4 kali ", "Argentina"));
        addTextQuestion(new TextQuestion("Bahasa pemrograman yang mirip dengan nama hewan", "Phyton"));
        addTextQuestion(new TextQuestion("Kantor pusat Google", "Mountain View"));
        addTextQuestion(new TextQuestion("Nama jalan yang menjadi tempat pertukaran saham terbesar di dunia", "Wall Street"));
        addTextQuestion(new TextQuestion("Pendiri perusahaan animasi Disney", "Walt Elias Disney"));
        addTextQuestion(new TextQuestion("1,1,2,3,5,8,13,21,44,... merupakan deret ", "Fibonacci"));
        addTextQuestion(new TextQuestion("Perusahaan audio terkenal dari Amerika ", "Dolby"));
        addTextQuestion(new TextQuestion("Nama Istri Pangeran William (putra lady Diana) ", "Catherine Middleton"));
        addTextQuestion(new TextQuestion("Kepolisian Republik Indonesia ", "POLRI"));
        addTextQuestion(new TextQuestion("Cantik, Sunda", "Geulis"));
        addTextQuestion(new TextQuestion("Ibukota Queensland, negara bagian Australia", "Brisbane"));
        addTextQuestion(new TextQuestion("Kumpulan Superheroes Marvel", "Avengers"));
        addTextQuestion(new TextQuestion("Presiden Pertama Indonesia", "Soekarno"));
        addTextQuestion(new TextQuestion("Nama asli Batman", "Bruce Wayne"));
        addTextQuestion(new TextQuestion("Perusahaan Handphone asal Kanada", "Blackberry"));
        addTextQuestion(new TextQuestion("Android 5.0", "Lollipop"));
        addTextQuestion(new TextQuestion("Pemeran Utama James Bond", "Daniel Craig"));
        addTextQuestion(new TextQuestion("Raja Keraton Yogyakarta", "Hamengkubuwono"));
        addTextQuestion(new TextQuestion("Penguasa Laut Selatan", "Nyi Roro Kidul"));
        addTextQuestion(new TextQuestion("Pemilik Trans TV", "Chairul Tanjung"));
        addTextQuestion(new TextQuestion("Sepatu Sejuta Umat", "Converse"));
        addTextQuestion(new TextQuestion("Induk Organisasi Bulutangkis Indonesia", "PBSI"));
        //addTextQuestion(new TextQuestion("Kompetisi jet darat", "F1"));
        addTextQuestion(new TextQuestion("BUMN Telekomunikasi Indonesia", "Telkom"));
        addTextQuestion(new TextQuestion("Perusahaan Teknologi bernama buah", "Apple"));
        addTextQuestion(new TextQuestion("Organisasi Islam berasal dari Yogyakarta", "Muhammadiyah"));
        addTextQuestion(new TextQuestion("Ibukota Timor Timor", "Dili"));
        addTextQuestion(new TextQuestion("Suku asli Australia", "Aborigin"));
        addTextQuestion(new TextQuestion("Indonesia dan Malaysia", "Serumpun"));
        addTextQuestion(new TextQuestion("1 Semenanjung, Beda ideologi", "Korea"));
        addTextQuestion(new TextQuestion("Pusat Tata Surya Kita", "Matahari"));
        addTextQuestion(new TextQuestion("Dahulu Planet, sekarang bukan", "Pluto"));
        addTextQuestion(new TextQuestion("Musuh abadi Batman", "Joker"));
        addTextQuestion(new TextQuestion("Superhero dengan kekuatan cincin", "Green lantern"));
        addTextQuestion(new TextQuestion("Largest Indonesian online Community", "Kaskus"));
        addTextQuestion(new TextQuestion("Suku asal Sumatera Barat", "Minangkabau"));
        addTextQuestion(new TextQuestion("Vendor Komputer asal Taiwan", "ASUS"));
        addTextQuestion(new TextQuestion("Saingan Berat ATI", "Nvidia"));
        addTextQuestion(new TextQuestion("Saingan Berat Intel", "AMD"));
        addTextQuestion(new TextQuestion("Smartphone buatan Apple", "Iphone"));
        addTextQuestion(new TextQuestion("Benua Terbesar di Dunia", "Asia"));
        addTextQuestion(new TextQuestion("Negara di 2 Benua", "Rusia"));
        addTextQuestion(new TextQuestion("Nama Aliansi Jerman, Italia, dan Jepang saat perang dunia II", "AXIS"));
        addTextQuestion(new TextQuestion("Pemimpin Bangsa Mongol yang terkenal", "Gengis Khan"));
        addTextQuestion(new TextQuestion("Sungai Terpanjang di afrika", "Nil"));
        addTextQuestion(new TextQuestion("Imperium terbesar di dunia", "Britania Raya"));
        addTextQuestion(new TextQuestion("panggilan untuk anak dari paman / bibi", "Sepupu"));
        addTextQuestion(new TextQuestion("Ikatan keluarga", "Marga"));
        addTextQuestion(new TextQuestion("Ibukota Provinsi Jawa Tengah", "Semarang"));
        addTextQuestion(new TextQuestion("Kucing Robot dari abad 22", "Doraemon"));


    }
}

