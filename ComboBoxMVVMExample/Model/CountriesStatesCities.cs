using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxMVVMExample.Model
{
    public static class CountriesStatesCities
    {

        ///// <summary>
        // Get list of all coutries in world
        // </summary>
        // <returns></returns>
        public static List<string> GetCitiesList(string countryName)
        {
            switch (countryName)
            {
                case "Argentina":
                    return ArgentinaCityNames.ToList();

                case "Australia":
                    return AustraliaCityNames.ToList();

                case "Austria":
                    return AustriaCityNames.ToList();

                case "Bangladesh":
                    return BangladeshCityNames.ToList();

                case "Belarus":
                    return BelarusCityNames.ToList();

                case "Belgium":
                    return BelgiumCityNames.ToList();

                case "Bolivia":
                    return BoliviaCityNames.ToList();

                case "Brazil":
                    return BrazilCityNames.ToList();

                case "Brunei":
                    break;

                case "Bulgaria":
                    break;

                case "Cameroon":
                    return CameroonCityNames.ToList();

                case "Canada":
                    return CanadaCityNames.ToList();

                case "Chile":
                    return ChileCityNames.ToList();

                case "China":
                    return ChinaCityNames.ToList();

                case "Colombia":
                    return ColombiaCityNames.ToList();

                case "Croatia":
                    return CrotiaCityNames.ToList();

                case "Cyprus":
                    return CyprusCityNames.ToList();

                case "Czech Republic":
                    break;

                case "Denmark":
                    break;

                case "Egypt":
                    return EgyptCityNames.ToList();

                case "England":
                    return UnitedKingdomCityNames.ToList();

                case "Finland":
                    return FinlandCityNames.ToList();

                case "France":
                    return FranceCityNames.ToList();

                case "Germany":
                    return GermanyCityNames.ToList();

                case "Ghana":
                    return GhanaCityNames.ToList();

                case "Greece":
                    return GreeceCityNames.ToList();

                case "Grenadin Islands":
                    return GrenadinCityNames.ToList();

                case "Guantanamo Bay":
                    break;

                case "Guatemala":
                    return GuantemalaCityNames.ToList();

                case "Guyana":
                    return GuyanaCityNames.ToList();

                case "Hungary":
                    return HungaryCityNames.ToList();

                case "India":
                    return IndianCityNames.ToList();

                case "Indonesia":
                    return IndonesiaCityNames.ToList();

                case "Iran":
                    return IranCityNames.ToList();

                case "Iraq":
                    break;

                case "Ireland":
                    return IrelandCityNames.ToList();

                case "Israel":
                    return IsraelCityNames.ToList();

                case "Italy":
                    return ItalyCityNames.ToList();

                case "Japan":
                    return JapanCityNames.ToList();

                case "Jordan":
                    return JordanCityNames.ToList();

                case "Kazakistan":
                    return KazakistanCityNames.ToList();

                case "Kenya":
                    return KenyaCityNames.ToList();

                case "Korea":
                    break;

                case "Kuwait":
                    return KuwaitCityNames.ToList();

                case "Kygyzstan":
                    return KygyzstanCityNames.ToList();

                case "Latvia":
                    return LatviaCityNames.ToList();

                case "Lebanon":
                    return LebanonCityNames.ToList();

                case "Libya":
                    return LibyaCityNames.ToList();

                case "Lithuania":
                    return LithuaniaCityNames.ToList();

                case "Luxembourg":
                    return LuxembourgCityNames.ToList();

                case "Macedonia":
                    return MecedoniaCityNames.ToList();

                case "Malawi":
                    return MalawiCityNames.ToList();

                case "Malaysia":
                    return MalaysiaCityNames.ToList();

                case "Malta":
                    return MaltaCityNames.ToList();

                case "Mauritius":
                    break;

                case "Mexico":
                    return MexicoCityNames.ToList();

                case "Morocco":
                    return MoroccoCityNames.ToList();

                case "Namibia":
                    return NamibiaCityNames.ToList();

                case "Neth. Antilles":
                    return NethAntillesCityNames.ToList();

                case "Netherlands":
                    return NetherlandCityNames.ToList();

                case "New Zealand":
                    return NewZealandCityNames.ToList();

                case "Nigeria":
                    return NigeriaCityNames.ToList();

                case "Norway":
                    return NorwayCityNames.ToList();

                case "Pakistan":
                    return PakistanCityNames.ToList();

                case "Palestinian Territories":
                    return PalestineCityNames.ToList();

                case "Paraguay":
                    return ParaguayCityNames.ToList();

                case "Peru":
                    return PeruCityNames.ToList();

                case "Philippines":
                    return PhilippinesCityNames.ToList();

                case "Poland":
                    return PolandCityNames.ToList();

                case "Portugal":
                    return PortugalCityNames.ToList();

                case "Romania":
                    return RomaniaCityNames.ToList();

                case "Russia":
                    return RussiaCityNames.ToList();

                case "Saipan":
                    return SaipanCityNames.ToList();

                case "Scotland":
                    break;

                case "Singapore":
                    break;

                case "Saudia Arabia":
                    return SaudiaArabiaCityNames.ToList();

                case "Sierra Leone":
                    return SierraCityNames.ToList();

                case "Slovakia":
                    return SlovakiaCityNames.ToList();

                case "Slovenia":
                    return SloveniaCityNames.ToList();

                case "South Africa":
                    return SouthAfricaCityNames.ToList();

                case "South Korea":
                    return SouthKoreaCityNames.ToList();

                case "Spain":
                    break;

                case "Sri Lanka":
                    return SrilankaCityNames.ToList();

                case "Sweden":
                    break;

                case "Switzerland":
                    return SwitzerlandCityNames.ToList();

                case "Syria ":
                    return SyriaCityNames.ToList();

                case "Taiwan":
                    return TaiwanCityNames.ToList();

                case "Tajikistan":
                    return TajiksitanCityNames.ToList();

                case "Tanzania":
                    return TanzaniaCityNames.ToList();

                case "Thailand":
                    return ThailandCityNames.ToList();

                case "Trinidad and Tobago":
                    return TrinidadandTobagoCityNames.ToList();

                case "Tunisia":
                    return TunisiaCityNames.ToList();

                case "Turkey":
                    return TurkeyCityNames.ToList();

                case "Uganda":
                    return UgandaCityNames.ToList();

                case "Ukraine":
                    return UkraineCityNames.ToList();

                case "United Arab Emirates":
                    return UnitedArabEmritesCityNames.ToList();

                case "United Kingdom":
                    return UnitedKingdomCityNames.ToList();

                case "Uruguay":
                    return UruguayCityNames.ToList();

                case "USA":
                    return USACityNames.ToList();

                case "Uzbekistan":
                    return UzbekistanCityNames.ToList();

                case "Venezuela":
                    return VenezuelaCityNames.ToList();

                case "Vietnam":
                    return VietnamCityNames.ToList();

                case "Yemen":
                    return YemaenCityNames.ToList();

                case "Yugoslavia":
                    return YugoslaviaCityNames.ToList();

                case "Zaire":
                    return ZaireCityNames.ToList();

                case "Zambia":
                    return ZambiaCityNames.ToList();

                case "Zimbabwe":
                    return ZimbabweCityNames.ToList();
            }
            return new List<string>();
        }

        public static List<string> GetCountriesList()
        {
            return CountryNames.ToList();
        }

        /// <summary>
        /// Get State/Provinces List
        /// </summary>
        /// <returns></returns>
        public static List<string> GetStatesList(string countryName)
        {
            switch (countryName)
            {
                case "USA":
                    return AmericaStatesNames.ToList();

                case "Australia":
                    return AustraliaStatesNames.ToList();

                case "Canada":
                    return CanadaStatesNames.ToList();

                default:
                    return new List<string>();
            }
        }

        public static string[] CountryNames = new string[]
        {
            "USA",
        "Argentina",
        "Australia",
        "Austria",
        "Bangladesh",
        "Belarus",
        "Belgium",
        "Bolivia",
        "Brazil",
        "Brunei",
        "Bulgaria",
        "Cameroon",
        "Canada",
        "Chile",
        "China",
        "Colombia",
        "Croatia",
        "Cyprus",
        "Czech Republic",
        "Denmark",
        "Egypt",
        "England",
        "Finland",
        "France",
        "Germany",
        "Ghana",
        "Greece",
        "Grenadin Islands",
        "Guantanamo Bay",
        "Guatemala",
        "Guyana",
        "Hungary",
        "India",
        "Indonesia",
        "Iran",
        "Iraq",
        "Ireland",
        "Israel",
        "Italy",
        "Japan",
        "Jordan",
        "Kazakhstan",
        "Kenya",
        "Korea",
        "Kuwait",
        "Kygyzstan",
        "Latvia",
        "Lebanon",
        "Libya",
        "Lithuania",
        "Luxembourg",
        "Macedonia",
        "Malawi",
        "Malaysia",
        "Malta",
        "Mauritius",
        "Mexico",
        "Morocco",
        "Namibia",
        "Neth. Antilles",
        "Netherlands",
        "New Zealand",
        "Nigeria",
        "Norway",
        "Pakistan",
        "Palestinian Territories",
        "Paraguay",
        "Peru",
        "Philippines",
        "Poland",
        "Portugal",
        "Romania",
        "Russia",
        "Saipan",
        "Scotland",
        "Singapore",
        "Saudia Arabia",
        "Sierra Leone",
        "Slovakia",
        "Slovenia",
        "South Africa",
        "South Korea",
        "Spain",
        "Sri Lanka",
        "Sweden",
        "Switzerland",
        "Syria ",
        "Taiwan",
        "Tajikistan",
        "Tanzania",
        "Thailand",
        "Trinidad and Tobago",
        "Tunisia",
        "Turkey",
        "Uganda",
        "Ukraine",
        "United Arab Emirates",
        "United Kingdom",
        "Uruguay",
        //"USA",
        "Uzbekistan",
        "Venezuela",
        "Vietnam",
        "Yemen",
        "Yugoslavia",
        "Zaire",
        "Zambia",
        "Zimbabwe"
            };

        #region States Names

        /// -summary-
        /// List of states/provinces
        /// -/summary-
        public static string[] AustraliaStatesNames = new string[]
        {
           "Australian Capital Territory",
           "New South Wales",
           "Victoria",
           "Queensland",
           "Western Australia",
           "Tasmania",
           "Northern Territory"
        };

        public static string[] CanadaStatesNames = new string[]
        {
            "Alberta",
            "British Columbia",
            "Manitoba",
            "New Brunswick",
            "Newfoundland",
            "Northwest Territories",
            "Nova Scotia",
            "Nunavit",
            "Ontario",
            "Prince Edward Island",
            "Quebec",
            "Saskatchewan",
            "Yukon Territories"
        };

        public static string[] AmericaStatesNames = new string[]
        {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "D.C.",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "Washington D.C.",
            "West Virginia",
            "Wisconsin",
            "Wyoming"
        };
        
        #endregion

        #region Cities Names

        public static string[] ArgentinaCityNames = new string[]
        {
            "Azul","Bahia Blanca","Buenos Aires","Chilvilcoy","Comodoro Rivadavia","Cordoba", "Corrientes","La Plata",
            "Las Flores","Mar Del Plata","Medoza","Merio", "Moreno","Posadas","Resistencia","Rio Cuarto","Rosario",
            "San Juan", "San Rafael","Santa Fe","Tandil","Villa Maria"
        };

        public static string[] AustraliaCityNames = new string[]
        {
            "Adelaide","Albury","Alice Springs","Armidale","Ballerat","Brisbane","Cairns","Canberra","Darwin",
            "Geelong","Gold Coast","Hamilton","Hobart","Launceston","Melbourne","Mildura","Newcastle",
            "Perth","Sydney","Toowoomba","Townsville","Wollongong"
        };

        public static string[] AustriaCityNames = new string[]
        {
            "Baden Bei Wien","Badgastein","Graz","Horn","Innsbruck","Kitzbuehel","Klagenfurt","Klosterneuburg",
            "Krems An Der Donau","Linz","Linz Donau","Lofer","Neunkirchen Niederosterreich","Salzburg","Sankt Polten","Thuringen",
            "Velden Am Wother See","Vienna","Weis","Zell Am See"
        };

        public static string[] BangladeshCityNames = new string[]
        {
           "Chittagong","Dhaka (Dacca)","Khulna","Rangpur"
        };

        public static string[] BelarusCityNames = new string[]
        {
           "Brest","Minsk","Novopolotsk","Sosny"
        };

        public static string[] BelgiumCityNames = new string[]
        {
            "Antwerp","Bruges","Brussels","Charleroi","Ghent","Hasselt","Knokke","Kortrijk","La Louviere","Leuven",
            "Libramont","Liege","Malines","Mons","Namur","Oostende","Verviers","Waregem"
        };

        public static string[] BoliviaCityNames = new string[]
        {
            "Cochabamba","La Paz","Santa Cruz"
        };

        public static string[] BrazilCityNames = new string[]
        {
            "Aracajú","Belem","Belo Horizonte","Boa Vista","Botucatu","Brasilia","Campinas","Campo Grande","Canoas",
            "Cuiabá","Curitiba","Diadema","Florianópolis","Fortaleza","Goiania","Guarulhos","João Pessoa","Juiz de Fora",
            "Jundiai","Londrina","Macapá","Maceió","Manaus","Natal","Niteroi","Nova Hamburgo","Palmas","Paranagua","Pelotas",
            "Porto Alegre","Porto Velho","Recife","Ribeirao Preto","Rio de Janeiro","Salvador","Santo Andre","Santos","São Bernardo do Campo",
            "São Jose dos Campos","São Luiz","São Paulo","Teresina","Vitoria"
        };

        public static string[] CameroonCityNames = new string[]
        {
            "Bahenda","Buea","Veliko Turnovo","Yaounde"
        };

        public static string[] CanadaCityNames = new string[]
        {
            "100 Mile House","108 Mile Ranch","Abbotsford","Aldergrove","Athabasca","Belleville","Brampton","Brighton","Brockville",
            "Calgary","Campbell River","Castlegar","Charlottetown","Cobourg","Collingwood","Coquitlam","Cornwall","Courtenay",
            "Cranbrook","Dalhousie","Dorval","Drummondville","Duncan","Edmonton","Fort St. John","Fort William","Georgetown",
            "Guelph","Halifax","Hamilton","Hope","Hull","Invermere","Iqaluit","Kelowna","Kenora","Kingston","Langley","Lethbridge",
            "London","Malton","Marathon","Midland","Mississauga","Montréal","Muncton","Nanaimo","Nelson","Nepean","Niagara Falls",
            "North Bay","Ottawa","Owen Sound","Parksville","Parry Sound","Port Alberni","Prince George","Québec City","Regina",
            "Revelstoke","Sainte-Foy","Saskatoon","Sault Ste. Marie","Scarborough","Sherbrooke","Sidney","Simcoe","St. John's",
            "Stettler","Sudbury","Swift Current","Thunder Bay","Toronto","Trois-Rivieres","Vancouver","Victoria","Waterloo","Whistler",
            "Whitehorse","Windsor","Winnipeg","Winsor","Yellowknife"
        };

        public static string[] ChileCityNames = new string[]
        {
            "Antofagasta","Arica","Calama","Chiquayante","Concepcion","Iquique","Penco","Puerto Montt","Punta Arenas","Rancagua",
            "Tecreo","San Bernardo","Santiago","Talca","Talcahuano","Temuco","Valparaiso","Vina Del Mar"
        };

        public static string[] ChinaCityNames = new string[]
        {
            "Anqing","Anshan","Baicheng","Baoan Xian","Baoding","Baoji","Beihai","Beijing (Peking)","Bengbu","Cangzhou","Changchun",
            "Changde","Changle","Changsha","Changzhou","Chaoyang","Chaozhou","Chengde","Chengdu","Chongan","Chongqing","Conghua",
            "Dagang","Dalian","Dandong","Daqing","Deyang","Dongguan","Foshan","Fuding","Fuxin","Fuzhou","Gaoming","Gongzhuling",
            "Guangzhou","Guilin","Guiyang","Gutian","Haikou","Handan","Hangu","Hangzhou","Hankou","Harbin","Hefei","Hengshui","Hengyang",
            "Hepu","Heshan","Huanggang","Huangshi","Huaxian","Huian","Huizhou","Huzhou","Jiamusi","Jiangmen","Jianou","Jianyang","Jiaxing",
            "Jilin","Jinan","Jinhua","Jining","Jinjiang","Jinzhou","Kaifeng","Kaiping","Kunming","Langfang","Lanzhou","Lianyungang","Liaoyang",
            "Liaoyuan","Lishui","Liuzhou","Longgang","Longhai","Longyan","Fujian","Luoyang","Luzhou","Maanshan","Mawei","Meizhou","Mianyang",
            "Minqing","Mudanjiang","Nanan","Nanching","Nanchong","Nanjing","Nanning","Nanping","Nantong","Nantou","Nanyang","Ningbo","ingde",
            "Panjin","Panyu","Pingdingshan","Pingtan","Pucheng","Puning","Putian","Qingdao","Qinhuangdao","Qinzhou","Quanzhou","Quzhou",
            "Sanming","Sanshui","Shanghai","Shangqiu","Shantou","Shaoguan","Shaowu","Shaoxing","Shaxian","Shekou","Shenyang","Shenzhen",
            "Shijiazhuang","Shishi","Shuangcheng","Shunde","Sihui","Siping","Suihua","Suxian","Suzhou","Taian","Taiyuan","Taizhou","Tanggu",
            "Tangshan","Tianjin","Tianshui","Tieling","Tongan","Tonghua","Urumqi","Weifang","Wenjiang","Wenzhou","Wuhan","Wuhu","Wuxi",
            "Xiamen","Xi'an","Xiangtan","Xiaogan","Xiaolan","Xiapu","Xichang","Xingtai","Xinhui","Xining","Xinxiang","Xuchang","Xuzhou",
            "Yanan","Yancheng","Yangzhou","Yanji","Yantai","Yibin","Yinchuan","Yiyang","Yongan","Yongzhou","Yueyang","Yulin","Zhangjiakou",
            "Zhangpu","Zhangzhou","Zhanjiang","Zhaoqing","Zhengzhou","Zhenjiang","Zherong","Zhongshan","Zhuhai","Zhuzhou","Zibo","Zigong"
         };

        public static string[] ColombiaCityNames = new string[]
        {
            "Armenia","Barranquila","Bogota","Bucaramanga","Cali","Cartagena","Cartago","Cucuta","Giradot","Ibague","Manizales","Medellin",
            "Neiva","Palmira","Pereira","Santa Marta","Villavicencio"
        };

        public static string[] CrotiaCityNames = new string[]
        {
            "Bakar","Dubrovnik","Pula","Rijeka","Split","Varazdin","Zadar","Zagreb"
        };

        public static string[] CyprusCityNames = new string[]
        {
           "Famagusta","Larnaca","Limassol","Nicosia","Paphos"
        };

        public static string[] EcuadorCityNames = new string[]
        {
            "Ambato","Cayambe","Cuenca","Esmeraldas","Guayaquil","Ibarra","Loja","Machachi","Machala","Manta","Portoviejo",
            "Quevedo","Quito","Salinas","Santo Domingo","Tulcan"
        };

        public static string[] EgyptCityNames = new string[]
        {
            "Alexandria","Aswan","Asyut","Benhas","Cairo","Damanhour","El Mahallah","El Mansoura","Luxor","Mahalah El Kobra","Port Said",
            "Oena","Shebin El Kom","Sohag","Suez","Tanta"
        };

        public static string[] EstoniaCityNames = new string[]
        {
            "Haapsalu","Jõgeva","Kärdla","Kohtla-Järve","Kuressaare","Narva","Paide","Pärnu","Põlva","Rakvere","Rapla",
            "Sillamäe","Tallinn","Tartu","Valga","Viljandi","Võru"
        };

        public static string[] EthiopiaCityNames = new string[]
        {
            "Addis Adaba","Assab","Dire Dawa"
        };

        public static string[] FinlandCityNames = new string[]
        {
            "Espoo-Esbo","Forssa","Helsinki","Joensuu","Jyvaskyla","Kajanni","Kemi","Kotka","Kuopio","Kuusamo","Lahti","Lappeenranta",
            "Mariehamn","Mikkeli","Oulu","Pori","Rovaniemi","Savonlinna","Tammefors","Tampere","Turku","Uleaborg","Vassa","Vanda, Vanta","Varkaus"
        };

        public static string[] FranceCityNames = new string[]
        {
            "Aix-En-Provence","Biarritz","Bordeaux","Cannes","Cherbourg","Corsica","Grenoble","Le Havre","Lille","Lourdes","Lyon","Marseille",
            "Montpellier","Nantes","Nice","Paris","Reims","Rouen","St. Etienne","St. Tropez","Strasbourg","Toulon","Toulouse","Tours","Vichy"
        };

        public static string[] GermanyCityNames = new string[]
        {
            "Achim","Augsberg","Baden-Baden","Bayreuth","Berlin","Bonn","Bremen","Bremerhaven","Cologne","Dortmund","Dresden","Dussledorf",
            "Essen","Frankfurt","Friedrichshafen","Hamburg","Hanover","Heidelberg","Hof","Karlsruhe","Kassel","Kiel","Koblenz","Leipzig",
            "Magdeburg","Muenster","Munich","Numberg","Oberhausen","Pforzheim","Solingen","Stuttgart","Trier","Wiesbaden","Wuerzburg"
        };

        public static string[] GhanaCityNames = new string[]
        {
            "Accra","Koforidua","Kumasi","Tamale"
        };

        public static string[] GreeceCityNames = new string[]
        {
            "Alexandroupolis","Argos","Athens","Chania, Crete","Corfu","Corinth","Crete","Elevsis","Heraklion","Hydra","Kalamata","Kavala",
            "Kos","Larissa","Mikonos Island","Milos","Mytilene","Patras","Piraeus","Rhodes","Salonika","Samos Island","Skiathos","Sparta",
            "Thessaloniki","Tripolis","Volos","Zagora"
        };

        public static string[] GrenadinCityNames = new string[]
        {
            "Bequia","Mustique","Palm Island","Union Island"
        };

        public static string[] GuantemalaCityNames = new string[]
        {
            "Antigue","Guatemala","Quezaltenango"
        };

        public static string[] GuyanaCityNames = new string[]
        {
            "Bartica","Georgetown","New Amsterdam"
        };

        public static string[] HungaryCityNames = new string[]
        {
            "Abasar","Balatonaliga","Budapest","Debrecan","Dorgicxe","Fertoboz","Gyongyos","Gyor","Kaposvar","Kazincbarcik","Komio","Miskolc",
            "Nagulamsozsa","Szekesfehervar","Szeged","Szolnok","Varpalota","Veszprem","Zalaegerszeg"
        };

        public static string[] IndianCityNames = new string[]
        {
            "Ahmedabad","Amristsar","Bangalore","Baroda","Bhopal","Bombay","Calcutta","Chandigarh","Delhi","Hyderabad","Jaipur",
            "Jullundur","Kanpur","Madras","New Delhi","Poona","Surat"
        };

        public static string[] IndonesiaCityNames = new string[]
        {
            "Ambona","Balikpapan","Bandung","Blitar","Cipanas","Cirebon","Denpasar","Jakarta","Jayapura","Kupang","Madiun","Malang","Medan",
            "Padang","Palembang","Semarang","Solo City","Surabaya","Tanjungkarang","Yogyankarta"
        };

        public static string[] IranCityNames = new string[]
        {
            "Isfahan","Mashhad","Tabriz","Tehran"
        };

        public static string[] IrelandCityNames = new string[]
        {
            "---------------------IRELAND CITIES---------------------",
            "Arklow","Cork","Dingle","Donegal","Drogheda","Dublin","Dundalk","Ennis","Galway","Kildare","Kilkenny","Killarney","Limerick",
            "Sligo","Tipperary","Tralee","Tullamore","Waterford","Wexford"
        };

        public static string[] IsraelCityNames = new string[]
        {
            "Acre","Afula","Arad","Ariel","Ashdod","Ashkelon","Azur","Bat Yam","Beer Sheva","Beit Shean","Bnei Brak","Carmiel","Dimona",
            "Eilat","Even Yehuda","Givatayim","Hadera","Haifa","Herzliya","Hod Hasharon","Holon","Jerusalem","Karkur","Kfar Saba","Kiryat Gat",
            "Kiryat Malachi","Kiryat Motzkin","Kiryat Ono","Kiryat Shmona","Kiryat Tivon","Kiryat Yam","Lod","Maale Adumim","Maalot Tarshiha",
            "Mevasseret Zion","Mount Carmel","Nahariya","Nazereth","Nes Ziona","Netanya","Netivot","Or Akiva","Pardes Hana","Petah Tikva",
            "Raanana","Ramle","Ramat Gan","Rehovot","Rishon Lezion","Rosh Haayin","Safed","Tel Aviv-Jaffa","Tiberias","Yavne","Zichron Yaacov"
        };

        public static string[] ItalyCityNames = new string[]
        {
            "Bari","Bergamo","Bologna","Brindisi","Cagliari","Capri","Catania","Como","Florence","Genoa","Messina","Milan","Modena","Naples",
            "Padova","Palermo","Pantelleria","Perugia","Pescara","Pisa","Pompei","Portofino","Reggio Clabria","Rome","Sorrento","Sondrio",
            "Taranto","Triesto","Turin","Vatican City","Venice","Verona","Vicenza"
        };

        public static string[] JapanCityNames = new string[]
        {
            "Aichi","Akita","Amagasaki","Chiba","Chuoko","Fuchu","Fukuoka","Gifu","Hiroshima","Kagoshima","Kanagawa","Kawasaki",
            "Kobe","Kochi","Kyoto","Mitatoku Tokyo","Miyazaki","Nagasaki","Nagoya","Naha","Niigata","Nishinomiya","Okayama","Osaka",
            "Saitamatan","Sappora","Sasebo","Sendai","Tachikawa","Takamatsu","Tokyo","oyama","Toyota","Yokohama","Yokosuka"
        };

        public static string[] JordanCityNames = new string[]
        {
           "Al-sareeh","Amman","Aqaba","Irbid","Jerash","Karak","Matraq","Ramtha","Zargu"
        };

        public static string[] KazakistanCityNames = new string[]
        {
           "Almaty","Karaganda","Kustanay","Shymkent","Zhezkazgan"
        };

        public static string[] KenyaCityNames = new string[]
        {
           "Busia","Eldorel","Kajiado","Kisumu","Maseno","Mombasa","Nairobi","Nakuru"
        };

        public static string[] KuwaitCityNames = new string[]
        {
           "Safat"
        };

        public static string[] KygyzstanCityNames = new string[]
        {
           "Bishkek","Karakol","Osh"
        };

        public static string[] LatviaCityNames = new string[]
        {
           "Jelgava","Liepajas Rajons","Riga","Valmiera"
        };

        public static string[] LebanonCityNames = new string[]
        {
            "Ajaltoun-Keserwan","Aley","Baabdat","Bartoun-North","Beirut","Bhamdoun","Bikfaya-Metn","Broumana","Faraya","Jounieh",
            "Jubail","North Bartoun","Saidon","South Tyre","Tripoli","Tyre-South","Zahle-Bekaa","Zghorta","Zouk Mikael","Mobile (Cellular)"
        };

        public static string[] LibyaCityNames = new string[]
        {
            "Benghazi","Misurata","Tripoli","Zawai"
        };

        public static string[] LithuaniaCityNames = new string[]
        {
            "Klaipeda","Kaunas","Vilnius"
        };

        public static string[] LuxembourgCityNames = new string[]
        {
            "Diedrich","Han/Lesse","Howard","Kirchberg","Plateau de Kirchberg","Rameldange"
        };

        public static string[] MecedoniaCityNames = new string[]
        {
            "Bitola","Gostivar","Ohrid","Prilep","Skopje","Strumica","Tetova"
        };

        public static string[] MalawiCityNames = new string[]
        {
           "Domasi"
        };

        public static string[] MalaysiaCityNames = new string[]
        {
            "Alor Setar","Baranang","Cheras","Degil","Ipoh","Joho Baharu","Kajang","Kepala Betas","Kuala Lumpur","Kuala Terengganu",
            "Machang","Malacca","Maran","Palau Pinang","Penang","Petaling Jaya","Port Dickson","Sclangor","Semenyih","Seremban","Serlang",
            "Shah Alan","Sungei Besi","Sungei Renggam","Sungei","Tawau, Sabah"
        };

        public static string[] MaltaCityNames = new string[]
        {
           "Valletta"
        };

        public static string[] MexicoCityNames = new string[]
        {
            "Acapulco","Cancun","Celaya","Chihuahua","Ciudad Juarez","Cozumel","Culiacan","Guadalajara","Hermosillo","La Paz",
            "Mazatlan","Merida","Mexicali","Mexico City","Monterrey","Puebla","Puerto Vallarta","San Luis Potosi","Tampico","Tecate","Tijuana","Torreon","Veracruz"
        };

        public static string[] MoroccoCityNames = new string[]
        {
            "Casablanc","Marrakech","Rabat","Tangiers"
        };

        public static string[] NamibiaCityNames = new string[]
        {
            "Keetmanshoop","Tsumeb","Windhoek"
        };

        public static string[] NethAntillesCityNames = new string[]
        {
            "Bonaire","Curacao","St. Eustatius","St. Maarten"
        };

        public static string[] NewZealandCityNames = new string[]
        {
            "Auckland","Bay of Plenty","Christchurch","Dunedin","Hamilton","Hastings","Invercargill","Manawatu","Napier","Nelson",
            "New Plymouth","Palmerston North","Queenstown","Rotorua","The South Island","Tauranga","Timaru","Wairarapa","Wanganui","Wellington","Whangarei"
        };

        public static string[] NetherlandCityNames = new string[]
        {
            "Amsterdam","Arnhem","Breda","Delft","Dordrecht","Eindhoven","Enschede","Gouda","Groningen","Haalrlem","Heemstede",
            "Heerlen","Hillegersberg","Hilversum","Hoensbroek","Hoogkerk","Hoogvliet","Leeuwarden","Leiden","Loosduinen","Maastricht","Nijmegen",
            "Oud Zuilen","Rotterdam","The Hague","Tilburg","Utrecht"
        };

        public static string[] NicaraguaCityNames = new string[]
        {
            "Chinandega","Diriamba","Leon","Managua"
        };

        public static string[] NigeriaCityNames = new string[]
        {
            "Abeokuta","Abuja","Benin City","Calabar","Edo State","Enugu","Ibadan","Ikoi","Ile-Ife","Jos",
            "Kaduna","Lagos","Nsukka","Owerri","Port-Harcourt","Zaria"
        };

        public static string[] NorwayCityNames = new string[]
        {
            "Bergen","Drammen","Halden","Lysaker","Oslo","Tromso"
        };

        public static string[] OceansCityNames = new string[]
        {
            "East Atlantic Ocean","Indian Ocean","Pacific Ocean","West Atlantic Ocean"
        };

        public static string[] PakistanCityNames = new string[]
        {
            "Hyderabad","Islamabad","Karachi","Lahore"
        };

        public static string[] PalestineCityNames = new string[]
        {
            "Al-Toufah","Beit-Jala","Beit Sahour","Bethlehem","Birzeit","Hebron","Nablus","Ramallah"
        };

        public static string[] ParaguayCityNames = new string[]
        {
            "Asuncion","Concepcion"
        };

        public static string[] PeruCityNames = new string[]
        {
            "Arequipa","Callao","Cusco","Huancayo","Ica","Iquitos","Lima","Piura/Chiclayo","Trujillo"
        };

        public static string[] PhilippinesCityNames = new string[]
        {
            "Angeles, Luzon","Bacolod","Baguio","Cebu","ClarkField","Dugupan","Davao","Iloilo","Lucena, Luzon","Makait, Luzon",
            "Manila","Ozamiz City","SanFernando","San Fernando Pampanga","SanPablo","Subic","Tarlac","Zamboanga"
        };

        public static string[] PolandCityNames = new string[]
        {
            "Bialystok","Bielsko-Biala","Bydogoszcz","Bytom","Gdansk","Gdynia","Gliwice","Gora","Jozefow","Katowice","Koszecin",
            "Koszalin","Krakow","Legnica","Leszno","Lodz","Lomianki","Lublin","Myslenice","Olsztyn","Opole","Ostrowiec","Poznan","Pruszkow",
            "Radom","Sejny","Sopot","Sosnowiec","Szczecin","Torun","Tychy","Warsaw","Wroclaw"
        };

        public static string[] PortugalCityNames = new string[]
        {
            "Almada","Angra Do Heroismo","Aviero","Barreiro","Beja","Braga","Caldas Da Rainha","Cascais","Coimbra","Cova da Picade",
            "Estoril","Evora","Faro","Figueira Da Foz","Funchal","Horta","Lagos","Lajes","Leiria","Lisbon","Madalena","Madeira Islands",
            "Montijo","Nazare","Oeiras","Peniche","Ponta Delgada","Portela-Lrs","Porto","Porto Santo","Riba de Ave","Santa Cruz","Santarem",
            "Setubal","Sintra","Velas","Viana Do Castelo","Villa Real","Vita Do Porto","Viseu"
        };

        public static string[] RomaniaCityNames = new string[]
        {
            "Alba-lulia","Arad","Bacau","Baia-Mare","Bistrita Nasaud","Botosani","Braila","Brasov","Bucuresti","Buzau","Calarasi",
            "Cernavoda","Chisineu Cris","Cluj","Cluj-Napoca","Constanta","Craiova","Deva","Drobeta Turnu-Severin","Efarie","Focsani","Galati",
            "Giurgiu","Iasi","Lipova","Marnaia","Miercurea-Ciuc","Odorheiu","Oradea","Orsova","Piatra-Neamt","Pitesti","Ploiesti","Radauti",
            "Ramnicu-Valcea","Resita","Satu-Mare","Sfantu-Gheorghe","Sibiu","Sighisoara","Slatina","Slobozia","Suceava","Szatmar","Targoviste",
            "Targu-Jiu","Tirgu-Mures","Timisoara","Tulcea","Turna Magurele","Vaslui","Zalau"
        };

        public static string[] RussiaCityNames = new string[]
        {
            "Irkutsk","Kazan","Krasnodar","Moscow","Nizhny Novgorod","Novosibirsk","St. Petersburg","Vladivostok",
            "Volgograd","Voronezh","Yakutsk","Yaroslavl","Yekaterinburg"
        };

        public static string[] SaipanCityNames = new string[]
        {
            "Rota","Susupe","Tinlan"
        };

        public static string[] SaudiaArabiaCityNames = new string[]
        {
            "Abha","Abqaiq","Al Khobar","Al Markazi","Al Ulaya","Damman","Dhahran","Hofuf","Jeddah","Khamis Mushaait",
            "Mecca","Medina","Najran","Qatif","Riyadh","Tabuk","Taif","Yenbu"
        };

        public static string[] SierraCityNames = new string[]
        {
            "Bo","Freetown","Makeni"
        };

        public static string[] SlovakiaCityNames = new string[]
        {
            "Banska Bystrica","Bratislava","Dolny Kubin","Dunajska Luzna","Jinan","Kosice","Nitra","Pezinok","Poniky",
            "Presov","Stara Tura","Topolcany","Trnava","Zilina"
        };

        public static string[] SloveniaCityNames = new string[]
        {
            "Dob","Domzale","Kamnik","Kranj","Ljubljana","Maribor","Menges","Naklo","Skfja Loka","Trboulje"
        };

        public static string[] SomaliaCityNames = new string[]
        {
           "Mogadishu"
        };

        public static string[] SouthAfricaCityNames = new string[]
        {
            "Acornhock","Alberton","Alice","Amanzimtoti","Athlone","Auckland Park","Belville","Berea","Bloenfortein","Boksburg",
            "Braamfontein","Cape Town","Centurion","Crawford","Dalbridge","Daveyton","Dube","Durban","East London","Emmarentia","Empangeni",
            "Fort Beaufort","Gauteng","George","Giyani","Grahamstown","Johannesburg","Kenwyn","King Williams","Klerksdorp","La Montagne",
            "Lady Smith","Lenasia","Lenyene","Mangauno","Mankurwane","Maraisburg","Mitchells Plain","Mulbarton","Natal","Nigel","Parkview",
            "Pietersburg","Pietermaritzburg","Pinelands","Pinetown","Port Elizabeth","Pretoria","Rethabile","Rivonia","Rondebosch","Salt River",
            "Sandton","Scottsville","Seshego","Sovenga","Soweto","Umtata","Valezia","Vlaeberg","Wits"
        };

        public static string[] SouthKoreaCityNames = new string[]
        {
            "Anyang","Cheju","Chungju","Gumi","Icheon","Inchon","Jeonju","Kwangju","Kyonggi-do","Masan","Osan","Pohang","Pusan",
            "Seongnam","Seoul","Suwon","Taegu","Ulsan","Wonju"
        };

        public static string[] SrilankaCityNames = new string[]
        {
            "Battargmulb","Boralesgamuwa","Colombo Central","Deniwala","Kandy","Kelaniya","Kohuwela","Kotte","Maharagana",
            "Mattara","Moratuwa","Nuggoda","Peradeniya","Wattala"
        };

        public static string[] SudanCityNames = new string[]
        {
            "Khartoum"
        };

        public static string[] SwitzerlandCityNames = new string[]
        {
            "Baar","Baden","Basle","Batel","Begnins","Belg","Bellevue","Belp","Berne","Biel","Blonay","Bogis-Bassel","Bollingen",
            "Bottmingen bei Basel","Brug","Carouge","Chambesy","Chateau d'Oex","Chur","Crans","Dardagny","Davos","Feldmeilen","Fribourg",
            "Froideville","Gattikon","Geneva","Grand-Lancy","Grandes-Paccot","Grenchen","Gruet","Gstaad","Henggart","Hilterfingen","Horgen",
            "Interlaken","Ittingen","Kilchberg","Kriens","La Chaux-de-Fonds","Lausanne","Locarno","Lugano","Lucerne","Mannedorf","Mettmensletten",
            "Metzerlen","Montreux","Muri","Neuchatel","Nyon","Oberdiesbach","Oberwill","Opfikon","Port","Pragassona","Pully","Riehen","Rivaz",
            "Sankt Moritz","Sankt Gallen","Schofthauser","Seftigen","Sion","Solothurn","Stetten","Sursee","Vessy","Vevey","Wabern","Weggus",
            "Wengen","Windish","WInterthur","Yverdom les Bains","Zell","Zermatt","Zollikerberg","Zug","Zumikon","Zurich","Zurzach"
        };

        public static string[] SyriaCityNames = new string[]
        {
            "Aleppo","Baniyas","Bloudan","Damascus","Dera","Deir al-Zour","Hamah","al-Hasakah","Homs","Idleb","Jableh","Jisr al-Shughur",
            "Kordaha","Latakia","Ma'anbej","Ma'arret al-Nouman","al-Nabk","Palmyra","al-Qamishli","Quneitra","al-Raqqah","Safita","Sweida",
            "Tartous","Yabroud","Zabadani"
        };

        public static string[] TaiwanCityNames = new string[]
        {
            "Changhua","Chiy-Yi","Chungli","Chunan","Chunghsing-Hsintsun","Fengyuan","Hualien","Huwei","Llan","Kaohsiun","Keelung",
            "Lotung","Lukang","Makung","Miaoli","Nantou","Panchiao","Pingtung","Sunchung","Taichung","Tainan","Taipei","Taitung","Taoyuan",
            "Tchou-Nan","Wuchi","Yungho"
        };

        public static string[] TajiksitanCityNames = new string[]
        {
            "Isfara","Karubadam","Khujad"
        };

        public static string[] TanzaniaCityNames = new string[]
        {
             "Dar es Salaam","Dodma","Mtwara","Mwanza","Tanga","Zanzibar",
        };

        public static string[] ThailandCityNames = new string[]
        {
            "Bangkok","Buriram","Chiang Mai","Chaing Rai","Chon Buri","Chanthabuir","Hatyai","Lampang","Nakhon Sawan","Nong Khai",
            "Pathumthani","Pattaya Beach","Phetchaburi","Phitsanulok","Ratchabuir","Sara Buri","Phuket","Songkhia","Tak","Trang","Ubon Ratchathani","Udon Thani"
        };

        public static string[] TrinidadandTobagoCityNames = new string[]
        {
            "Cascade","Port of Spain","Chiang Mai","Tunapa"
        };

        public static string[] TunisiaCityNames = new string[]
    {
            "Ariana","Bizerte","Carthage","Cite El Khadhra","Dar Chaabane","El Menzah","Hammon Luif","Kairouan","La Manouba",
            "Marsaville","Megrine Coteaux","Menzel Bourguiba","Port El Kantaoui","Sfax","Tunis"
    };

        public static string[] TurkeyCityNames = new string[]
        {
            "Adana","Adiyaman","Afyon","Agri","Aksaray","Amasya","Ankara","Antalya","Ardahan","Artvin","Aydin","Balikesir","Bartin",
            "Batman","Bayburt","Bilecik","Bingo","Bitus","Bolu","Bornoua","Burdur","Bursa","Canakkale","Cankiri","Corum","Denizli","Diyarbakir",
            "Edirne","Elazig","Erzincan","Erzurum","Eskisehir","Gaziantep","Giresun","Gumushane","Hatay","Hakkari","Igdir","Isparta","Icel",
            "Istanbul","Izmir","Kahramanmaras","Karaman","Kars","Kastamonu","Kayseri","Kirikkale","Kirklareli","Kirsehir","Kocaeli","Konya",
            "Kutahya","Lefkosa","Malatya","Manisa","Mardin","Mersin","Mugla","Mus","Nevsehir","Nigde","Ordu","Rize","Sakarya","Samsun","Siirt",
            "Sinop","Sivas","Sanliurfa","Sirnak","Tekirdag","Tokat","Trabzon","Tunceli","Usak","Van","Yozgat","Zonguldak"
        };

        public static string[] TurkmenistanCityNames = new string[]
        {
           "Ashgabad"
        };

        public static string[] UgandaCityNames = new string[]
        {
           "Entebbe","Jinja","Kalisizo","Kampala","Kyambogo","Masaka"
        };

        public static string[] UkraineCityNames = new string[]
        {
            "Cherkassy","Chernivitsi","Crimea","Denepropetrovsk","Donetsk","Ivano-Frankiusk","Kharkov","Kiev","Kirovohrad",
            "Lugansk","Lviv","Mykilaiv","Odessa","Slavyansk","Ternopil","Umani","Vinnytsia","Zhitomir"
        };

        public static string[] UnitedArabEmritesCityNames = new string[]
        {
            "Abu Dhabi","Ajman","Al ain","Asab","Aweir","Bita Zayed","Buhasa","Dhayd","Dibba","Dubai","Falaj-Al-Moalia","Fujairah",
            "Habshan","Jebel Ali","Jebel Dhana","Khawanij","Mafrak","Ras-Al-Khaimah","Sharjah","Tarif","Umm-ai-Quwain","Wadi Hatta"
        };

        public static string[] UnitedKingdomCityNames = new string[]
        {
            "Aberdeen","Aberystwyth","Bangor","Bath","Belfast","Birmingham","Blackpool","Bournemouth","Bradford","Brighton",
            "Bristol","Cambridge","Canterbury","Cardiff","Carlisle","Carmarthenshire","Coventry","Dover","Dundee","Durham","Edinburgh","Exeter",
            "Fife","Glasgow","Gloucester","Greenock","Guernsey, Channel Islands","Haddington","Harrogate","Hull","Ipswich","Jersey, Channel Islands",
            "Kenilworth","Leeds","Leicester","Liverpool","London","Londonderry","Manchester","Newcastle","Northampton","Norwich","Nottingham",
            "Oban","Oxford","Penzance","Plymouth","Portsmouth","Prestwick","Reading","Sheffield","Southampton","Swansea"
        };

        public static string[] UnitedKingdomStatesCityNames = new string[]
        {
            "Bath and North-East Somerset","Brighton","Bristol","Cumbria","Darlington","Derby","Derbyshire","Durham","East Riding of Yorkshire",
            "East Sussex","Gloucestershire","Hampshire","Herefordshire","Hertfordshire","Hove","Isle of Wight","Kingston upon Hull","Lincolnshire",
            "Northamptonshire","North East Lincolnshire","North Lincolnshire","North London Boroughs","North Somerset","North Yorkshire",
            "Northumberland","Nottingham","Nottinghamshire","Oxfordshire","Portsmouth","Somerset","South Gloucestershire","South London Boroughs",
            "Southampton","Staffordshire","Stoke-on-Trent","Suffolk","Surrey","Swindon","Warwickshire","Wiltshire"
        };

        public static string[] UruguayCityNames = new string[]
        {
            "Canelones","Mercedes","Montevideo","U.S. Virgin Islands"
        };

        public static string[] USACityNames = new string[]
        {
            "Acworth","Akron","Albany","Allentown","Alton","Altoona","Anaheim","Anguilla","Ann Arbor","Annapolis","Asheville",
            "Ashland","Aspen","Atlanta","Atlantic City","Augusta","Aurora","Bakersfield","Baltimore","Barstow","Baton Rouge","Battle Creek",
            "Bay City","Bel Air","Belle Glade","Belleville","Berkeley","Binghamtom","Birmingham","Bloomington","Boston","Boulder","Bowling Green",
            "Bradford","Breckenridge","Bridgeport","Brockton","Bronx","Brooklyn","Buffalo","Cairo","Cambridge","Camden","Canton","Cape May",
            "Carson City","Cedar Rapids","Chamblee","Charlotte","Chicago","Cincinnati","Clearwater","Cleveland","Colorado Springs","Columbia",
            "Columbus","Cortland","Council Bluffs","Cumberland","Danbury","Davenport","Dayton","Daytona Beach","Delaware","Denver","Des Moines",
            "Detroit","Dodge City","Dubuque","Easton","Elizabeth","Elkhart","Elmira","Enid","Erie","Eureka","Evanston","Evansville","Fairfield",
            "Fayetteville","Flagstaff","Flint","Fort Collins","Fort Lauderdale","Fort Pierce","Framingham","Frederick","Freehold","Fresno",
            "Ft. Myers","Gainesville","Gary","Grand Island","Grand Junction","Grand Rapids","Greensboro","Hackensack","Hagerstown","Hammond",
            "Harrisburg","Hartford","Hawaii","Hempstead","Hollywood","Hudson","Huntsville","Hutchinson","Idaho","Independence","Indianapolis",
            "Ithaca","Jackson","Jacksonville","Jefferson City","Jefferson","Jersey City","Joliet","Joplin","Kansas City","Key West","Kissimmee",
            "Kokomo","La Plata","La Salle","Lake Charles","Lancaster","Lansing","Las Vagas","Laurel","Lawrence","Lawton","Lebanon","Lexington",
            "Lincoln","Litchfield","Lockport","Long Beach","Long Island","Los Angeles","Louisville","Lowell","Macon","Maine","Manhattan",
            "Mansfield","Marietta","Miami","Middlesex","Minneapolis","Mississippi","Modesto","Monroe","Montana","Monterey","Montgomery",
            "Morristown","Mount Vernon","Muskogee","Naperville","Naples","New Bedford","New Haven","New London","New Orleans","New York City",
            "Newark","Niagara Falls","Norristown","North Platte","Northampton","Oak Brook","Oakland","Ocean City","Oklahoma City","Omaha",
            "Orange","Orlando","Owensboro","Paducah","Palm Springs","Paterson","Peekskill","Pensacola","Peoria","Philadelphia","Phoenix",
            "Pittsburgh","Pittsfield","Poipu","Pompano Beach","Portland","Pottstown","Poughkeepsie","Pueblo","Queens","Quincy","Raleigh",
            "Reading","Riverside","Rochester","Rock Island","Rockford","Rockville","Rome","Sacramento","Salem","Salina","Salisbury","San Bernardino",
            "San Diego","San Francisco","San Jose","Sanford","Santa Barbara","Santa Claus","Santa Fe","Santa Rosa","Sarasota","Savannah",
            "Schenectady","Scotsdale","Scottsbluff","Scranton","Sebastian","Shreveport","Shron","Sioux City","South Bend","Springfield",
            "St. Charles","St. Cloud","St. Joseph ","St. Louis","St. Paul","St. Petersburg","Stamford","Staten Island","Steubenville","Stroudsburg",
            "Syracuse","Tallahassee","Tampa","Toledo","Tolland","Toms River","Topeka","Torrington","Towson ","Trenton","Troy","Tucson","Tulsa",
            "Utica","Vail","Vero Beach","Vineland","Walnut Creek","Waltham","Washington","Waterbury","Waukegan","West Palm Beach","White Plains",
            "Wichita","Winchester","Windham","Winslow","Winston-Salem","Woodbury","Worcester","Yonkers","Youngstown","Yuma"
        };

        public static string[] UzbekistanCityNames = new string[]
        {
            "Ferghana","Samarkand","Tashkent","Urgench"
        };

        public static string[] VietnamCityNames = new string[]
        {
            "Da Nang City","Hanoi","Ho Chi Minh City"
        };

        public static string[] VenezuelaCityNames = new string[]
        {
            "Barcelona","Barquisimeto","Cabimas","Caracas","Cuidad Bolivar","Coro","Cumana","Guanare","Los Teques","Maigueita",
            "Maracaibo","Maracay","Maturin","Meridan","Miranda","Puerto Cabello","Punto Fijo","San Cristobal","San Juan De Los Morros",
            "Valencia","Zaraza"
        };

        public static string[] YemaenCityNames = new string[]
        {
           "Aden","Amran","Hodeidah","Mukalla","Sana'a","Taiz","Thumar","Yarim","Zabid"
        };

        public static string[] YugoslaviaCityNames = new string[]
        {
           "Ada","Belgrade","Nis","Novi Beograd","Novi Sad","Subotica","Zemun"
        };

        public static string[] ZaireCityNames = new string[]
        {
           "Kinshasa","Lubumbashi"
        };

        public static string[] ZambiaCityNames = new string[]
        {
           "Chingola","Kitwe","Luanshya","Lusaka","Ndola"
        };

        public static string[] ZimbabweCityNames = new string[]
        {
           "Bulawayo","Chiredzi","Harare","Mutare"
        };

        #endregion
    }
}

