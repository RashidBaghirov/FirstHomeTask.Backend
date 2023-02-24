using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class TogetherVM
    {
        public List<Teachers> Teachers;
        public List<Category> Categories;

        public TogetherVM()
        {
            Teachers = new List<Teachers>()
            {
                new Teachers()
                {
                    Id = 1,
                    Name="Javid Asadullayev",
                    Profession="Full-stack",
                    Description="Proqramlaşdırma təhsilini Code Academy-də alan Cavid bakalavr təhsilini isə İqtisad Universitetinin Biznesin idarəedilməsi ixtisası üzrə tamamlamışdır. İlk iş yeri CA Supply şirkəti olmuş, orada 1 il Satınalma Menecerinin köməkçisi vəzifəsində işləmişdir. Code Academy-də təhsilini uğurla bitirdikdən sonra Akademiyada mentor olaraq fəaliyyətinə davam etmişdir. Proqramlaşdırma sahəsində Front end və Back end bilikləri və təcrübələrini inkişaf etdirmək məqsədilə “Starex” şirkətinin vebsaytını hazırlamışdır. Əlavə olaraq tanınmış kitab mağazalarından olan “Bakumoz” şirkətinin e-commerce vebsaytını və  texno musiqi növü üzrə istiqamətlənən “Bermooda” təşkilatının vebsaytını full stack olaraq bitirmişdir. Daha sonra isə Müəllim Yetişdirmə Proqramına qoşulmuş və uğurla başa vurması nəticəsində hazırda Akdemiyamızda Proqramlaşdırma üzrə İnstruktor olaraq fəaliyyətini davam etdirir.",
                    Image="https://code.edu.az/wp-content/uploads/2022/11/Cavid-Asadullayev.png"


                },
                  new Teachers()
                {
                    Id = 2,
                    Name="Mahmud Qəribov",
                    Profession="Full-stack",
                    Description="Mahmud 4 ilə yaxındır ki, proqramlaşdırma sahəsindədir və bu müddət ərzində o, 3 fərqli şirkətdə işləmişdir. İlk təcrübəsi “Labrin” şirkətində back-end developer vəzifəsi olmuşdur. Mahmud burada proqramlaşdırma ilə yanaşı komanda ilə işləmə təcrübəsi də qazanmışdır və bir müddət işlədikdən sonra “Chevre” startup şirkətindən təklif alaraq, burada Team Lead olaraq fəaliyyətinə davam etmişdir. Startup-da işlədiyi dövrdə Pragmatech Education və Smart Electronics şirkətlərinin daxili CRM layihələri üzərində də işləmişdir. Hal-hazırda “Smart Solutions” şirkətində .NET developer vəzifəsində olan Mahmud 23 may tarixindən etibarən isə akademiyamızda Proqramlaşdırma üzrə İnstruktor olaraq fəaliyyətə başlayıb.",
                    Image="https://code.edu.az/wp-content/uploads/2022/11/Mahmud.png"


                },
                   new Teachers()
                {
                    Id = 3,
                    Name="Knyaz Yaqubov",
                    Profession="UX/UI Dizayn",
                    Description="Knyaz Yaqubov 10 ildir ki dizayn ilə məşğuldur. Müxtəlif mətbəələrdə, reklam şirkətlərində, Safaroff Creative Agentliyində qrafik və veb dizayner olaraq fəaliyyət göstərmiş, Nəqliyyat, Rabitə və Yüksək Texnologiyalar Nazirliyi Məlumat Hesablama Mərkəzində dizayn rəhbəri vəzifəsində çalışmışdır. Bu günə qədər bir çox bootcamp-larda iştirak etmiş və bir çox dizayn müsabiqələrinin qalibi olmuşdur. Adobe Certified Expert (ACE) ünvanına sahib olan Knyaz Yaqubov 2017-ci ildən Code Academy komandasına qoşulub. Knyaz müəllim akademiyada Qrafik və Veb Dizayn tədris proqramının rəhbəri olaraq fəaliyyət göstərir.\r\n",
                    Image="https://code.edu.az/wp-content/uploads/2021/07/Rectangle-1.png"


                },
                         new Teachers()
                {
                    Id = 4,
                    Name="Günay Əliyeva",
                    Profession="Web Design",
                    Description="Bakalavr təhsilini Bakı Dövlət Universitetində Kompüter Elmləri ixtisası üzrə bitirən Günay məzun olduqdan sonra 2020-ci ildə Code Academy-də Qrafik və Veb dizayn tədrisinə başlamış və tədrisi yüksək şərəf diplomu ilə bitirib. Həmin ildə rəsm çəkməyə başlayaraq qısa müddətdə uğurlu nəticələr əldə edib. Günay 2 ilə yaxındır ki, dizayn sahəsindədir və ilk təcrübəsinə ATL Tech şirkətində UI/UX Dizayn üzrə intern olaraq başlayıb, təcrübə müddətini uğurla başa vuraraq 1 il müddətində UI/UX Dizayner olaraq fəaliyyət göstərib. Həmin illərdə paralel olaraq freelance layihələrlə təcrübəsini daha da artırmağa davam edib. A-Group sığorta şirkəti üçün mobil tətbiq, Dövlət Vergi Xidməti üçün daxili sistem, Time Academy vebsaytı kimi layihələrin veb dizaynını hazırlayıb. Əlavə olaraq Rizvan Bağırlının Tipoqrafika kitabında da Günayın dizaynları yer alıbdır. Qeyd edək ki, Günay hal-hazırda Expressbankda Məhsul Dizayneri olaraq da fəaliyyətinə davam edir. 2021-ci ildən Code Academy-də müəllim yetişdirmə proqramına qoşularaq uğurla məzun olan Günay 23 may tarixindən etibarən Qrafik və Veb dizayn üzrə İnstruktor olaraq akademiyamızda fəaliyyətinə başlayıb.\r\n",
                    Image="https://code.edu.az/wp-content/uploads/2022/11/Gunay-qrafik.png"


                },
                               new Teachers()
                {
                    Id = 5,
                    Name="Fərid\r\nRzazadə",
                    Profession="Web Design",
                    Description="Fərid 14 ildir ki, dizayn sahəsində fəaliyyət göstərir. Dizayn fəaliyyətinə Veb dizayner olaraq başlasa da, daha sonra Qrafik dizayn sahəsinə yönəlmişdir. Karyerasının ilk vaxtlarında müxtəlif dizayn studiyalarında Qrafik və Veb dizayner kimi, 2014-2019-cu illərdə isə DDB və FCB qlobal reklam agentliyində Art direktor vəzifəsində işləmişdir. Daha sonra Uptime reklam agentliyində Kreativ direktor olaraq karyerasına davam etmişdir. 2020-2022-ci illərdə Azərbaycanın ən böyük pərakəndə satış şəbəkələrindən biri olan Kontakt Home-da işləmişdir. Bundan başqa bu illər ərzində Fərid Azercell, Bakcell, Azərbaycan Hava Yolları, Paşa Bank, Kapital Bank, Access Bank, Xırdalan, Bravo, Saffron Group, Topaz, InvestAz kimi yerli, Unilever, Audi, Volkswagen, Mcdonald’s, Holcim, Coca-Cola, Starbucks, Entree və Beeline kimi qlobal şirkətlərlərlə də işləmişdir. O, Azercell və AZAL markalarının rebranding prosesində agentlik adından Dizayn və Art istiqaməti üzrə menecer rolunu uğurla icra etmişdir. Əlavə olaraq Kontakt markasının isə rebranding prosesindən sonra yaradıcı və dizayn kommunikasiyasını formalaşdırmışdır. 23 maydan etibarən Akademiyamızda Korporativ Dizayn rəhbəri olaraq fəaliyyətə başlamış və iyun 2022-ci ildən etibarən isə Qrafik və Veb Dizayn müəllimi kimi də rol alır.\r\n",
                    Image="https://code.edu.az/wp-content/uploads/2022/10/farid.png"


                },
                                                 new Teachers()
                {
                    Id = 6,
                    Name="Murad Əsədov",
                    Profession="Web Design",
                    Description="Murad Əsədov rəssam ailəsində anadan olub. Dizayner olaraq ilk dəfə 2006-cı ildə İnformasiya Texnologiyaları İnstitutunda Qrafik Dizayner vəzifəsində işləməyə başlayıb. 2009-cu ildə həmkarları ilə “Yello AD” reklam agentliyini təsis edib. 2001-ci ildə UNESCO-nun dəstəyi ilə keçirilən “Narkomaniya və AİDS mənim gözümlə” rəsm-plakat müsabiqəsinin, 2010-cu ilin aprel ayında isə Maxmedia reklam agentliyinin “Ağ ölümə-Qara bayram!” adlı ən yaxşı sosial reklam posteri müsabiqəsinin qalibi olub. 2010-cu ilin dekabr ayında “Tütünçəkmənin zərərləri – karikaturaçı rəssamların gözü ilə” müsabiqəsində ikinci yerə layiq görülüb.\r\n\r\n2011-2018-ci illər ərzində qlobal reklam agentlikləri olan Organic Ogilvy, McCan Baku və DDB Azerbaijan-da Qrafik Dizayner və Art Direktor vəzifələrində işləyib. 2013-cü ildən Heydər Əliyev Mərkəzi və Heydər Əliyev Fondu ilə əməkdaşlıq edir. BP, Samsung, Nokia, Sharp, McDonalds, Coca-Cola, Uniliver və başqa qlobal brendlərlə yanaşı Azercell, Bakcell və digər yerli şirkətlərlə işləyib. Murad Əsədov 2019-cu ilin sentyabr ayından Code Academy-nin qrafik və veb dizayn müəllimi olaraq fəaliyyət göstərir.\r\n",
                    Image="https://code.edu.az/wp-content/uploads/2021/10/Murad.png"


                },
                                                                   new Teachers()
                {
                    Id = 7,
                    Name="Fuad\r\nQonaqov",
                    Profession="Web Design",
                    Description="Fuad 15 ildən çoxdur ki, qrafik dizayn sahəsindədir və bu müddət ərzində o, fərqli dizayn şirkətlərində işləmişdir. İlk təcrübəsi təhsil sahəsi ilə əlaqədar olmuş və “Magnum Agency” şirkətində Qrafik dizayner olaraq fəaliyyət göstərmişdir. Fuad burada qrafik dizayn ilə yanaşı veb dizaynla da bağlı təcrübə qazanmışdır və Amnesty International Türkiyə söbəsi üçün imza kampaniyasını dəstəkləyən sosial reklamın, Muğan Bank üçün İllik hesabatın hazırlanmasında iştirak etmişdir. Təhsilini bitirdikdən sonra “Baxçasaray”da Qrafik dizayner vəzifəsində fəaliyyətinə davam etmiş və Bakı şəhərində tanınmış Maestro, Il Mosaica, Avenue, Hong Kong Chinese və digər bizneslərin brendinqini hazırlamışdır. Daha sonra Fuad “Paradox Branding Studio”da Qrafik dizayner vəzifəsində fəaliyyətinə davam etmişdir. Burada işlədiyi müddətdə Fuad “SOCAR Polymer” zavodunun açılışının dizaynında fəal iştirak etmişdir. Bundan əlavə, “Tufandağ” istirahət mərkəzinin brend üslubunu, “İçərişəhər”in xəritəsini, “Formula 1” üçün promo məhsullarını və “2017 Baku Marshal’s Club” üçün maskot hazırlamışdır. Fuad 6 dekabr 2021-ci ildən etibarən akademiyamızda Qrafik və Veb Dizayn müəllimi olaraq fəaliyyət göstərir.\r\n",
                    Image="https://code.edu.az/wp-content/uploads/2022/01/Rectangle-1-1.png"


                }

            };
            Categories = new List<Category>()
            {
                new Category
                {
                    Id=1,
                    Name="Programing",
                    Image="https://zendenwebdesign.com/wp-content/uploads/2017/10/Top-7-Programing-Languages-for-Web-Development.jpg",
                    Description="A full stack web developer is a person who can develop both client and server software. In addition to mastering HTML and CSS, he/she also knows how to: Program a browser (like using JavaScript, jQuery, Angular, or Vue) Program a server (like using PHP, ASP, Python, or Node)"

                },
                 new Category
                {
                    Id=2,
                    Name="Design",
                    Image="https://www.incimages.com/uploaded_files/image/1920x1080/getty_537311951_100178.jpg",
                    Description="Desing offers a wide variety of Osmotic dehydrated fruits to customers. Using TurBiCon technology we retained fruit´s natural flavor, unique color, texture and nutritional composition. Osmotic dehydration is an effective method for the preservation of fruits and vegetables."

                },
                  new Category
                {
                    Id=3,
                    Name="Help-Desk",
                    Image="https://cdn.ttgtmedia.com/visuals/German/article/IT-help-desk-adobe.jpg",
                    Description="A help desk is a department or person that provides assistance and information, usually for electronic or computer problems. In the mid-1990s, research by Iain Middleton of Robert Gordon University studied the value of an organization's help desks."
                },
                      new Category
                {
                    Id=4,
                    Name="Digital-Marketing",
                    Image="https://www.simplilearn.com/ice9/free_resources_article_thumb/history_and_evolution_of_digital_marketing.jpg",
                    Description="Digital marketing, also called online marketing, is the promotion of brands to connect with potential customers using the internet and other forms of digital communication. This includes not only email, social media, and web-based advertising, but also text and multimedia messages as a marketing channel."
                }
            };
        }
    }
}
