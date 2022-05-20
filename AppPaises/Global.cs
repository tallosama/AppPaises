using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPaises
{
    class Global
    {
        public static List<Contienente> lContinentes = new List<Contienente>()
        {
            new Contienente(1, "Africa"),
            new Contienente(2, "América"),
            new Contienente(3, "Asia"),
            new Contienente(4, "Europa")
    };
        public static List<Pais> lPaises = new List<Pais>()
        {

  ///new Pais(1,'Angola',"Luanda",244,1,"AO","AGO" )
  new Pais(1,"Angola","Luanda",244,1,"AO","AGO"),
new Pais(2,"Argelia","Algiers",213,1,"DZ","DZA"),
new Pais(3,"Benín","Porto-Novo",229,1,"BJ","BEN"),
new Pais(4,"Botsuana","Gaborone",267,1,"BW","BWA"),
new Pais(5,"Burkina Faso","Ouagadougou",226,1,"BF","BFA"),
new Pais(6,"Burundi","Bujumbura",257,1,"BI","BDI"),
new Pais(7,"Cabo Verde","Praia",238,1,"CV","CPV"),
new Pais(8,"Camerún","Yaoundé",237,1,"CM","CMR"),
new Pais(9,"Comoras","Moroni",269,1,"KM","COM"),
new Pais(10,"Costa de Marfil","Yamoussoukro",225,1,"CI","CIV"),
new Pais(11,"Djibuti","Djibouti",253,1,"DJ","DJI"),
new Pais(12,"Egipto","Cairo",20,1,"EG","EGY"),
new Pais(13,"El Sáhara Español","El-Aaiun",212,1,"EH","ESH"),
new Pais(14,"Eritrea","Asmara",291,1,"ER","ERI"),
new Pais(15,"Etiopía","Addis Ababa",251,1,"ET","ETH"),
new Pais(16,"Gabón","Libreville",241,1,"GA","GAB"),
new Pais(17,"Gambia","Banjul",220,1,"GM","GMB"),
new Pais(18,"Ghana","Accra",233,1,"GH","GHA"),
new Pais(19,"Guinea","Conakry",224,1,"GN","GIN"),
new Pais(20,"Guinea Ecuatorial","Malabo",240,1,"GQ","GNQ"),
new Pais(21,"Guinea-Bissáu","Bissau",245,1,"GW","GNB"),
new Pais(22,"Kenia","Nairobi",254,1,"KE","KEN"),
new Pais(23,"Lesoto","Maseru",266,1,"LS","LSO"),
new Pais(24,"Liberia","Monrovia",231,1,"LR","LBR"),
new Pais(25,"Libia","Tripolis",218,1,"LY","LBY"),
new Pais(26,"Madagascar","Antananarivo",261,1,"MG","MDG"),
new Pais(27,"Malaui","Lilongwe",265,1,"MW","MWI"),
new Pais(28,"Mali","Bamako",223,1,"ML","MLI"),
new Pais(29,"Marruecos","Rabat",212,1,"MA","MAR"),
new Pais(30,"Mauricio","Port Louis",230,1,"MU","MUS"),
new Pais(31,"Mauritania","Nouakchott",222,1,"MR","MRT"),
new Pais(32,"Mozambique","Maputo",258,1,"MZ","MOZ"),
new Pais(33,"Namibia","Windhoek",264,1,"NA","NAM"),
new Pais(34,"Níger","Niamey",227,1,"NE","NER"),
new Pais(35,"Nigeria","Abuja",234,1,"NG","NGA"),
new Pais(36,"República Centroafricana","Bangui",236,1,"CF","CAF"),
new Pais(37,"República de Sudán del Sur","Juba",211,1,"SS","SSD"),
new Pais(38,"República del Congo","Brazzaville",242,1,"CG","COG"),
new Pais(39,"República Democrática del Congo","Kinshasa",243,1,"CD","COD"),
new Pais(40,"Reunión","Saint-Denis",262,1,"RE","REU"),
new Pais(41,"Ruanda","Kigali",250,1,"RW","RWA"),
new Pais(42,"Santa Elena","Jamestown",290,1,"SH","SHN"),
new Pais(43,"Santo Tomé y Príncipe","São Tomé",239,1,"ST","STP"),
new Pais(44,"Senegal","Dakar",221,1,"SN","SEN"),
new Pais(45,"Seychelles","Victoria",248,1,"SC","SYC"),
new Pais(46,"Sierra Leona","Freetown",232,1,"SL","SLE"),
new Pais(47,"Somalia","Mogadishu",252,1,"SO","SOM"),
new Pais(48,"Sudáfrica","Pretoria",27,1,"ZA","ZAF"),
new Pais(49,"Sudán","Khartoum",249,1,"SD","SDN"),
new Pais(50,"Swazilandia","Mbabane",268,1,"SZ","SWZ"),
new Pais(51,"Tanzania","Dodoma",255,1,"TZ","TZA"),
new Pais(52,"Togo","Lomé",228,1,"TG","TGO"),
new Pais(53,"Túnez","Tunis",216,1,"TN","TUN"),
new Pais(54,"Uganda","Kampala",256,1,"UG","UGA"),
new Pais(55,"Zambia","Lusaka",260,1,"ZM","ZMB"),
new Pais(56,"Zimbabue","Harare",263,1,"ZW","ZWE"),

new Pais(57,"Anguila","The Valley",+1264,2,"AI","AIA"),
new Pais(58,"Argentina","Buenos Aires",54,2,"AR","ARG"),
new Pais(59,"Aruba","Oranjestad",297,2,"AW","ABW"),
new Pais(60,"Bahamas","Nassau",1,2,"BS","BHS"),
new Pais(61,"Barbados","Bridgetown",1,2,"BB","BRB"),
new Pais(62,"Belice","Belmopan",501,2,"BZ","BLZ"),
new Pais(63,"Bermudas","Hamilton",1,2,"BM","BMU"),
new Pais(64,"Bolivia","La Paz",591,2,"BO","BOL"),
new Pais(65,"Brasil","Brasília",55,2,"BR","BRA"),
new Pais(66,"Canadá","Ottawa",1,2,"CA","CAN"),
new Pais(67,"Chile","Santiago",56,2,"CL","CHL"),
new Pais(68,"Colombia","Bogotá",57,2,"CO","COL"),
new Pais(69,"Costa Rica","San José",506,2,"CR","CRI"),
new Pais(70,"Cuba","Havana",53,2,"CU","CUB"),
new Pais(71,"Curazao","Willemstad",599,2,"CW","CUW"),
new Pais(72,"Dominica","Roseau",1,2,"DM","DMA"),
new Pais(73,"Ecuador","Quito",593,2,"EC","ECU"),
new Pais(74,"El Salvador","San Salvador",503,2,"SV","SLV"),
new Pais(75,"Estados Unidos","Washington",1,2,"US","USA"),
new Pais(76,"Groenlandia","Nuuk",299,2,"GL","GRL"),
new Pais(77,"Guadalupe","Basse-Terre",590,2,"GP","GLP"),
new Pais(78,"Guatemala","Guatemala City",502,2,"GT","GTM"),
new Pais(79,"Guyana","Georgetown",592,2,"GY","GUY"),
new Pais(80,"Haití","Port-au-Prince",509,2,"HT","HTI"),
new Pais(81,"Honduras","Tegucigalpa",504,2,"HN","HND"),
new Pais(82,"Islas Caimán","George Town",-344,2,"KY","CYM"),
new Pais(83,"Islas Malvinas","Stanley",500,2,"FK","FLK"),
new Pais(84,"Islas Vírgenes Británicas","Road Town",+1284,2,"VG","VGB"),
new Pais(85,"Jamaica","Kingston",1,2,"JM","JAM"),
new Pais(86,"México","Mexico City",52,2,"MX","MEX"),
new Pais(87,"Montserrat","Plymouth",+1664,2,"MS","MSR"),
new Pais(88,"Nicaragua","Managua",505,2,"NI","NIC"),
new Pais(89,"Panamá","Panama City",507,2,"PA","PAN"),
new Pais(90,"Paraguay","Asunción",595,2,"PY","PRY"),
new Pais(91,"Perú","Lima",51,2,"PE","PER"),
new Pais(92,"Puerto Rico","San Juan",1,2,"PR","PRI"),
new Pais(93,"República Dominicana","Santo Domingo",1,2,"DO","DOM"),
new Pais(94,"San Bartolomé","Gustavia",590,2,"BL","BLM"),
new Pais(95,"San Cristóbal y Nevis","Basseterre",1,2,"KN","KNA"),
new Pais(96,"San Martín","Marigot",+1599,2,"MF","MAF"),
new Pais(97,"San Pedro y Miquelón","Saint-Pierre",508,2,"PM","SPM"),
new Pais(98,"San Vicente y las Granadinas","Kingstown",1,2,"VC","VCT"),
new Pais(99,"Santa Lucía","Castries",1,2,"LC","LCA"),
new Pais(100,"Surinam","Paramaribo",597,2,"SR","SUR"),
new Pais(101,"Trinidad y Tobago","Port of Spain",1,2,"TT","TTO"),
new Pais(102,"Uruguay","Montevideo",598,2,"UY","URY"),
new Pais(103,"Venezuela","Caracas",58,2,"VE","VEN"),

new Pais(104,"Afganistán","Kabul",93,3,"AF","AFG"),
new Pais(105,"Arabia Saudita","Riyadh",966,3,"SA","SAU"),
new Pais(106,"Armenia","Yerevan",374,3,"AM","ARM"),
new Pais(107,"Azerbaiyán","Baku",994,3,"AZ","AZE"),
new Pais(108,"Bahréin","Manama",973,3,"BH","BHR"),
new Pais(109,"Bangladesh","Dhaka",880,3,"BD","BGD"),
new Pais(110,"Birmania (Myanmar)","Nay Pyi Taw",95,3,"MM","MMR"),
new Pais(111,"Brunéi","Bandar Seri Begawan",673,3,"BN","BRN"),
new Pais(112,"Bután","Thimphu",975,3,"BT","BTN"),
new Pais(113,"Camboya","Phnom Penh",855,3,"KH","KHM"),
new Pais(114,"China","Beijing",86,3,"CN","CHN"),
new Pais(115,"Corea del Norte","Pyongyang",850,3,"KP","PRK"),
new Pais(116,"Corea del Sur","Seoul",82,3,"KR","KOR"),
new Pais(117,"Emiratos Árabes Unidos","Abu Dhabi",971,3,"AE","ARE"),
new Pais(118,"Filipinas","Manila",63,3,"PH","PHL"),
new Pais(119,"Georgia","Tbilisi",995,3,"GE","GEO"),
new Pais(120,"Hong Kong","Hong Kong",852,3,"HK","HKG"),
new Pais(121,"India","New Delhi",91,3,"IN","IND"),
new Pais(122,"Indonesia","Jakarta",62,3,"ID","IDN"),
new Pais(123,"Irak","Baghdad",964,3,"IQ","IRQ"),
new Pais(124,"Irán","Tehran",98,3,"IR","IRN"),
new Pais(125,"Israel","Jerusalem",972,3,"IL","ISR"),
new Pais(126,"Japón","Tokyo",81,3,"JP","JPN"),
new Pais(127,"Jordania","Amman",962,3,"JO","JOR"),
new Pais(128,"Kazajistán","Astana",7,3,"KZ","KAZ"),
new Pais(129,"Kirgizistán","Bishkek",996,3,"KG","KGZ"),
new Pais(130,"Kuwait","Kuwait City",965,3,"KW","KWT"),
new Pais(134,"Laos","Vientiane",856,3,"LA","LAO"),
new Pais(135,"Líbano","Beirut",961,3,"LB","LBN"),
new Pais(136,"Macao","Macao",853,3,"MO","MAC"),
new Pais(137,"Malasia","Kuala Lumpur",60,3,"MY","MYS"),
new Pais(138,"Maldivas","Malé",960,3,"MV","MDV"),
new Pais(139,"Mongolia","Ulan Bator",976,3,"MN","MNG"),
new Pais(140,"Nepal","Kathmandu",977,3,"NP","NPL"),
new Pais(141,"Omán","Muscat",968,3,"OM","OMN"),
new Pais(142,"Pakistán","Islamabad",92,3,"PK","PAK"),
new Pais(143,"Qatar","Doha",974,3,"QA","QAT"),
new Pais(144,"Singapur","Singapur",65,3,"SG","SGP"),
new Pais(145,"Siria","Damascus",963,3,"SY","SYR"),
new Pais(146,"Sri Lanka","Colombo",94,3,"LK","LKA"),
new Pais(147,"Tailandia","Bangkok",66,3,"TH","THA"),
new Pais(148,"Taiwán","Taipei",886,3,"TW","TWN"),
new Pais(149,"Tayikistán","Dushanbe",992,3,"TJ","TJK"),
new Pais(150,"Turkmenistán","Ashgabat",993,3,"TM","TKM"),
new Pais(151,"Turquía","Ankara",90,3,"TR","TUR"),
new Pais(152,"Uzbekistán","Tashkent",998,3,"UZ","UZB"),
new Pais(153,"Vietnam","Hanoi",84,3,"VN","VNM"),
new Pais(154,"Yemen","San‘a’",967,3,"YE","YEM"),
new Pais(155,"Albania","Tirana",355,4,"AL","ALB"),
new Pais(156,"Alemania","Berlin",49,4,"DE","DEU"),
new Pais(157,"Andorra","Andorra la Vella",376,4,"AD","AND"),
new Pais(158,"Austria","Vienna",43,4,"AT","AUT"),
new Pais(159,"Bélgica","Brussels",32,4,"BE","BEL"),
new Pais(160,"Bielorrusia","Minsk",375,4,"BY","BLR"),
new Pais(161,"Bosnia-Herzegovina","Sarajevo",387,4,"BA","BIH"),
new Pais(162,"Bulgaria","Sofia",359,4,"BG","BGR"),
new Pais(163,"Chipre","Nicosia",357,4,"CY","CYP"),
new Pais(164,"Croacia","Zagreb",385,4,"HR","HRV"),
new Pais(165,"Dinamarca","Copenhagen",45,4,"DK","DNK"),
new Pais(166,"El Vaticano","Vatican City",39,4,"VA","VAT"),
new Pais(167,"Eslovaquia","Bratislava",421,4,"SK","SVK"),
new Pais(168,"Eslovenia","Ljubljana",386,4,"SI","SVN"),
new Pais(169,"España","Madrid",34,4,"ES","ESP"),
new Pais(170,"Estonia","Tallinn",372,4,"EE","EST"),
new Pais(171,"Finlandia","Helsinki",358,4,"FI","FIN"),
new Pais(172,"Francia","Paris",33,4,"FR","FRA"),
new Pais(173,"Gibraltar","Gibraltar",350,4,"GI","GIB"),
new Pais(174,"Grecia","Athens",30,4,"GR","GRC"),
new Pais(175,"Holanda","Amsterdam",31,4,"NL","NLD"),
new Pais(176,"Hungría","Budapest",36,4,"HU","HUN"),
new Pais(177,"Irlanda","Dublin",353,4,"IE","IRL"),
new Pais(178,"Isla de Man","Douglas, Isle of Man",44,4,"IM","IMN"),
new Pais(179,"Islandia","Reykjavík",354,4,"IS","ISL"),
new Pais(180,"Islas Feroe","Tórshavn",298,4,"FO","FRO"),
new Pais(181,"Italia","Rome",39,4,"IT","ITA"),
new Pais(182,"Kosovo","Pristina",381,4,"XK","XKX"),
new Pais(183,"Letonia","Riga",371,4,"LV","LVA"),
new Pais(184,"Liechtenstein","Vaduz",423,4,"LI","LIE"),
new Pais(185,"Lituania","Vilnius",370,4,"LT","LTU"),
new Pais(186,"Luxemburgo","Luxembourg",352,4,"LU","LUX"),
new Pais(187,"Macedonia","Skopje",389,4,"MK","MKD"),
new Pais(188,"Malta","Valletta",356,4,"MT","MLT"),
new Pais(189,"Moldavia","Chişinău",373,4,"MD","MDA"),
new Pais(190,"Mónaco","Monaco",377,4,"MC","MCO"),
new Pais(191,"Montenegro","Podgorica",382,4,"ME","MNE"),
new Pais(192,"Noruega","Oslo",47,4,"NO","NOR"),
new Pais(193,"Polonia","Warsaw",48,4,"PL","POL"),
new Pais(194,"Portugal","Lisbon",351,4,"PT","PRT"),
new Pais(195,"Reino Unido","London",44,4,"GB","GBR"),
new Pais(196,"República Checa","Prague",420,4,"CZ","CZE"),
new Pais(197,"Rumanía","Bucharest",40,4,"RO","ROU"),
new Pais(198,"Rusia","Moscow",7,4,"RU","RUS"),
new Pais(199,"San Marino","San Marino",378,4,"SM","SMR"),
new Pais(200,"Serbia","Belgrade",381,4,"RS","SRB"),
new Pais(201,"Suecia","Stockholm",46,4,"SE","SWE"),
new Pais(202,"Suiza","Berne",41,4,"CH","CHE"),
new Pais(203,"Ucrania","Kiev",380,4,"UA","UKR")


    };
    }
    public class Contienente
    {
        int idContinente;
        string descripcion;
        public Contienente(int idContinente, string descripcion)
        {
            this.IdContinente = idContinente;

            this.descripcion = descripcion;
        }
        public string DescripcionPais { get => descripcion; set => descripcion = value; }
        public int IdContinente { get => idContinente; set => idContinente = value; }
    }

    public class Pais
    {
        int idPais;
        string descripcion;
        string capital;
        string isoDos;
        string isoTres;
        int prefijo;
        int continenteId;

        public Pais(int idPais, string descripcion, string capital, int prefijo, int continenteId, string isoDos, string isoTres)
        {
            this.IdPais = idPais;
            this.Descripcion = descripcion;
            this.Capital = capital;
            this.Prefijo = prefijo;
            this.ContinenteId = continenteId;
            this.IsoDos = isoDos;
            this.IsoTres = isoTres;
        }



        public int IdPais { get => idPais; set => idPais = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Capital { get => capital; set => capital = value; }

        public int Prefijo { get => prefijo; set => prefijo = value; }
        public int ContinenteId { get => continenteId; set => continenteId = value; }
        public string IsoDos { get => isoDos; set => isoDos = value; }
        public string IsoTres { get => isoTres; set => isoTres = value; }
    }
}
