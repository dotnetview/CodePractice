﻿/*
 * Write a program to detect the first unique character in the given string (By Neil)
 */
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewProject
{
    public class FindFirstUniqueCharInString
    {
        public static char FindFirstUniqueCharInStringImp(string s)
        {
            int[] wordsCount = new int[256];
            int[] wordsPosition = new int[256];

            int index = 0;
            foreach (char c in s)
            {
                index++;
                int charCode = Convert.ToInt16(c);

                wordsCount[charCode]++;

                if (wordsPosition[charCode] == 0)
                {
                    wordsPosition[charCode] = index;
                }
            }

            char firstCh = '\n';
            int Positon = int.MaxValue;

            for (int i = 0; i< 256; i++)
            {
                if (wordsCount[i] == 1 && Positon > wordsPosition[i])
                {
                    firstCh = Convert.ToChar(i);
                    Positon = wordsPosition[i];
                }
            }

            return firstCh;
        }
    }


    [TestFixture]
    public class UTFindFirstUniqueCharInString
    {
        [Test]
        public void TestFindFirstUniqueCharInStringBegin()
        {
            string teststring = "c,hello, this is a test!";
            var ch = FindFirstUniqueCharInString.FindFirstUniqueCharInStringImp(teststring);

            Assert.IsTrue(ch == 'c', "first char is {0}", ch);
        }

        [Test]
        public void TestFindFirstUniqueCharInStringEnd()
        {
            string teststring = "hello, hello, hello, a!";
            var ch = FindFirstUniqueCharInString.FindFirstUniqueCharInStringImp(teststring);

            Assert.IsTrue(ch == 'a', "first char is {0}", ch);
        }
        
        [Test]
        public void TestFindFirstUniqueCharInLongString()
        {
            string teststring = "jnaprrmwbbujwrgqqtccvkjvxwiimcvmokrdsbgpubcwlveeqeprvoofeepsntdrujehsthrdwunjfedhltnarwsqjxbtuwnnkklsqqmhxthicnwthvenkcvuxhxvpxihelaqariwlxtamqmocwawtcnbmilvswcurgffljwjlhbjknfpkwqckvtfbjwsosetpttjabnjxdcmwtcnievjilfcgtxmdmwmheivjrfvxvnxosrsmiwtvgnwdnwtbtogrwwxuhpetcdmttnvgttxilclxiuhpaodvmnbkwkakncbvwdgwfmitvfamuxapsfsculbtmwqvteqmsvndnctebfvaqkghculsgcjoctdmhaxqasspmermcsbencbaabxdlkxfpcdpxhaaxdnabtclwfwpcrrstxeodjnoechotqkvqoxovnoqvflligxumlttvbccimhqelfxlnotqvwfbkqogjjisxujsjgrehlosbiwpqtoraqihuvkvtaugcirbkrthlmjernseopgqansjutvvtfjxufudllhkaqgtldcupaexegdpbqxvrgxownqameonhaqwxtxetaitmctblfcfwvfdhwghvejhpuwootbxkvkhiarwlcegbrffpcfixtgbqfpthuqknrrbrkpwqqpakrnepxhmrsvktrmudomimlxjhhlkknbtspocopsdlxqtxcnjabnhnksqaxocsltfhcqmmrhmotndmwseqgshsitfgcxfhjebektvrfoqbhfdlxlkdlebsubsiiqerwwngxwlotppejqddepopkdfwoomxrpgjmhbhblwslrqidgsuexnwbpkfgbnknwuokahoiqhofvtmdxjhbtkqcpbpubnbutvqibeuewobrmbidsptstdlenbeqpuewwcinkshfncdhesvsqfahharpptnddjmtjtetsbbeeduhvvsirsoiwcjkwpjleeautxhjlbsxntfcjdpmfhwfbbehkurjuoihdhoitbiawhnggtfielhwrubvcctwbpvocstgdjnfisevfgstghcddmiuqtramowhqrnelsratclnwdjvktfvcijmcudbvmlundeckmsxghjqblpxbodknbvvbqxheivtqrbrcosmdsomwwwplrbldplinnxuqdlgkcthbbbwqtllmlngatrjfrmlwlswlmfmexkgquvuobxmflmupncsdhgxttrplmevmihmhaaafnswpnmccweivtlnwmdgbdwbsmbdwejjfovtdsuoxhqctsdlnqadvioaimqrejrhwvgcijmchiepmxmdjujwotjcexnidhpchsatatnucadrbhilrkuxogbxxgpprvdcjmagjaowxpcpsvpnxceolpfhkboopmniudiluxxxqpdbpppqjuglggvcspdnmtwcaqplrbjodfnpqvctjouwhesqsiuuktnrelveavtvjerbmixantnagalcifutptcncdlxrdvtkcopmipwvjrhktrwggikfmghibimdfxqfpujburftrbeensocscrcoafhefuxrsumudxavvvvsequnaavkrqwiabhnqnfhvhnjmrestgnmcbkedognnpdcpsqetbfabbrvwameeqbburorboxmxhxfuxjinxxefkibbspdxdkprpavukwxwgmrxktkhgckrtsuwagofqhojspxtjevkwinbsojaaptvkhpmtjvunkpfeeqhljoefmsbxkgieowsiojtkarotjkeuhqxqfelfhqxrhqqspmxwqlmulcttfookqwlqiehfdgdifixskmusnfoljxbdoddohtttrjrmweomtfvupxsovgbwljcnmtualgajbbqebdpvcasivvaaioomrawaxdiavabkquuumlxdsjxwfvwcvhmxldtlogagnixwwdgmpluodptghxvtnolorktqcskslhavlvmmkmigvtxqlmdtawtrsofwlpbvxnhaouquewdmhubfqulcwffahhsfrwkvibrnjvsmoqegktllqxshxlqmrmrvmhhlqlqokdreaklogxftrdsmcbfdnocwdjxqfutjclfesniktbfomtcrbxsowmfqxvckaukqiqofmbuubrncjnlekmjntptlicrtisnboqvfnffkxgvrxbtwgacjtxthwrtkxxngklbfgkwgpatkaruxmfdahtgmbbawtlcwfscwhpuxxqjuscwhgjguhlclilijfvcjhvroinjvigwropipseddtabcfxecfvhxidnpjdeajktaunsfkxqptcddwutbteaqanwqjkoaeshbeputljhpwqwemcogpswmocviksovpjkmvdxxidasvdupxturqoxllljbksmhtvejrjslqfbcqtncoevkqbofhpscstqwqgoiocfgsoegxxxxtirrfsikkxitjmdkgwhrvwihipiocpufefjohcpsetmebgumvsafwmeiqxwsimductmkirsgmsnnaqtkmuxkavqqtpnclgventdlpojmunegidbvemprfifxipngbebvmnusdbvgstihxwvwfkvttwcfbggodhphbibafmvswfjindpdxvtwtxpsuejliohsknsdfejsccxsmhqwsvaufkugctndkcsgilfvdmcuvtdtcmxofletixkjtisxxtptltmvgjhcgpufbcmtchxvgpaepgjqqixjlegsqgatoiswxiauxqcjncpvncrenrrjxpuwhjfxvtoafhctnxfpwxvvxxkngpvrimnqecpodkpbcxcptlohrhmvllfstclkpkrixkgqivftapqqlnpiocutsojctjunkcbghjavtlbfvhvwlehumodbmboppvpbbddkgohfvfcociarurptuwtfiuvapgungwkmsckaoliqhssrgunlhqujqwefdtdlpsleuvbgwedsmukpbmundvumcqowdmnsfiikuffxfquejxqbfsrrqufohrqlgksbqxagjnnmkqswvtmijnwpawwxpsuuovakialjnlclguoajoxfwgsabcaxcljbrmjuvlkjwicobdhcndioemfcujkghlasiqepgpuivlhltgvnbqhvtqqpcsuupcxxkiktnvbucnammeqhvovqdssnaowbsbqbbnbriekhnnoxmwjjiebblrdgjnjvqilolxtxavghfmqokuhmdltpfnurtoeijowxrfigmxfomboaxvcgokdchiefachlvelvlppwwtativbfljlrrccbcpdewqlelcchroqiujgwcqqvwkjdmkpgwfjvwjxumhjmdclchahhsbtixfuwgtdqcihapeeeqlcgqsbwhbdwpacwifnrrfnxpievlcqshhmejxjsutttdxoxhalmthfuwwbeitfajlinobdivxgoudwtvgoonkdfvkvnxocnfwnthxppuuvhdhlssawjovqdmlqailiaejlvubgwpthwijdvwgeuardgnrcvluodwdtdmqapxlettbasqhpxjnvhoouvqomndflnbedjmfuhlikkbdqkdkeurangwmlothgtbmjmgjaqbgqgrmogmxkpehfkwejwfajwnbbqughqgcjeihbrmoxwpunhigrftawmesenhvbvxfqogxjuvublegupmtaltauoqaithnhbpwklskphvlkukosasdqawitfhdiduxqknojswiclotrtieqervinuhmhccrdgkucqevvikcwgtxxpxnkcbaiewoojnnuehlijretbqqsgedaxirjwrjshuramvlxiggmqfqubjlgfongqgndkdcuwsohdslcignwfxaihglrvqgjjchhbplupiusftgxvqooiqfxforvmcejemkncwfmsflidrtupttuipnjbsurlvswxddfuphlbsttnuslvaligftgermfkjfilpehqujaswfsdducaggksjugwmrijfhppjueosufhkbnfoptbgnkmucsgteeakhufrtkwtpbovnmcgwvoxxiufuaoveagxfftgcsphseqidputgaqtvvjnkjedsnmfkltranlffwukkgrmjuwxvhfefgbmvrcmvhdjfbiwjpmucrksojsfrhorufvbvnqlghexkhhkfpgoubomgxsfbgvfxqabcjotovnloaqicwlxhextxwhgltjpxgjvnwtdmaamjdsaxelaedlpmgbbjvealwknfsamihtdmphumrgqjptxcapgdweadcrqcpfvdexxgwvrbwdaiohdtsdupftoxbhwndkhtgebxxfjhbmhbchmwndtpspkileavqxjlvcaisxenthwcjlsdcamkuivfahocutmirivqxlstnnnfncelpkxrnqxhikhfbaqmsaxhwassvgtbnftngrltmvpnlduuoemwiipfxaurfjbhjmxjwfrqsrghrdnclirhlrntsjbauaowrxhiwviqfcdvskbmitwfulaqpmbqkrdgvgtbasbewqhipxqenpekbfjvoblqwfhxfiemleedvncxgudbsccolrxqahiqcudkrpsjhlqvtidkqhkupojxlvtldipqvoggjjermhfdgqcsgjelmraxpsegqcrrpkbmvhdtshmuhgqooccbjdagrqlhiggcqsednqwajefqpsnwcktlwojshoqijmveimodsooxbphqfuitjiqduasvlosjnlwnirausxdicndlilkesorqjtupmorqtfsaoajhwemdurrbcbdrxcvshvogrhohdqjkttclpvrbqkqdsesdpnfsmpjuerjvufknqacimklrmhaihfhbkwqpkavaeecdimgitqcpulclcbcalmltqhobxkjlrppaonulflkxrxvqaagdfqwbrgjjvlfutedmwhnhxjbakpvpqmdkvthunfpfduktcrmhqdbdikxcgdkqqekeddhlukiijfiapxcsekxphnogxdtucscsajfxwwvhpwwmagxekkadgmdtupicneudcnswmqoufpvoofagttlauvbsvwksrlqxkwosukkodpmgjwhgfhbgjaosssrewhnoqwqdxsbojxenkhmxjmjdnxstlberehljvlrporvcxhvkxrpwimujqrgnjemqdvdpxoiqxhtufxofkuxnqnrpsvcrckqslxfiihnoumgumpahcqetdhrwlmfopvrwuoavogchuxmbswchguhixuuedoiurlxuwcnfllnvorftanuvajaugkbtslseovbezjduqwfgaetkchmqcxpoqptrljsuvatxpoamppvwwvtdhvlmvtwcmkndsgvnxvnsedtvintfbbjxrmsawugtghrisccgdxdstjcawshkaqhpqtinfshsaowxdokhafmgfjgngnavusdcubhddnqgrxgrdrfpwwrxbjglcwiadhhroavbxfcikspweksooucvxtmljvfiaprlgpdpskfqrhcvwdlfxoppawgeulaiqcjrcoqpsujfbohwptgujmqvdsgprgbofjrdmnghbtfihxgtrjmlmguaqosekxasgciatedphqlivkxjlpvijefqhekshomntgnbqtjqljrgsabtouagpgrmjlqjougxfwjfjcwjfiqjgxnpjahtpejvvtcdrhhhlqevabclvlqksjlvulaahpuceesfibmofwfavrpguebrvetopfmmkfmmfhokbialepwhhqtrikkvxcvcdxlxfpplqspxwwsxxkfsoqqfmumgbcaahpvdkgowvgmphsrrgrmichmbfuaoslvaegcvqqjvflhqctgkbtarmxionbtkkhveifbqpxirxkgsrlbkjqmolwdmllqvbnnjnktsqbdctrkgtrkinqpphwpsicgvanictpaljijxsslmjnbvoliliocadwmsohnfasaenllrdlrlcpvitbqtpfvpuhlfmtlkwftfbcrqogmewxxkmsphufqxdflwjjdsvgqvpfllmctwvvhkjgfovfdpbammnjvvlhangmjkuwxkaknjdwcienoavbgpaujkcpdmxhkoguaagmjobqvwqfibpwartiwcjgjdboqpcdohpmcsdviqcfctiilavowmbmscebjerdraetkvkgrfifewhahugxhrrjfiqqwgteqkehxgnrbouogjevmghbcrrnevwtoewomficsoeihlwgqnigsnxoxdbqvtvdtpurvdokkmasfknojrsfisgeghksjhvwtxuotcijjjqgborhsfsjqffvwwllpmpfptotgcfgfuuwefcpdljbiftaiiuubxcjpldjwugqawvbwibaubgprtivumwtnlwbdqkjchkrqpchhgmifprksovlkdqcvgemtklblvbavodapiojnoccfxqucnshpqdmoahkjlmnruiuvfmkoochiwuhdjvulctqftfvmlbisisdcwadwoijekgmhpqhdunpqlfrdvcjklafosrtgwvartaemilsffadhgafabpapedkbsieoiqvhkrflmxmlgelshndbnhgsebtlgmnfsjooxrqmklftwjxammshukrsdewtfvomeaefjbnotxmwwiplwgskuqkrimmlxthuhgqfbifdgmdtoalbmjljoscvthwjgxjtscagwggjeajufkedpinobxppvxsohikbwegabmsbuwwxduiioiaxvxlxoecjnxtalvalkrxdhllvjaqkslevetunvufeosmximawanxgfrggpwvhsqbamsmqdjkfkdgfobflejqmfxikuufqaxiaveckqctfkcxtumpanmudqfjqbukvbbhuasvbtaxuonjbdonoewsenmscogkgxfhfflpwmcwsnwkwtobmaqchflrosahtsdrulhxrmaaxaneudvcecjuupsafneidrulpkgvrddvsgawbdkaurrikesfpismxfhpgerriibnuajiwunewwaglmckldinhoeudoxtmmmannpslwgmprponwsnlviktkmbetjdgomgngddiaorcjfqbttinxjdtuwikrvjoxaqedevfletoxluwceckquigskafafglpamrtcxbwjlskhtodfdcrqrgnbrfrrixvmevhfknsdxitldpaodvrvwbubtkuijqjnobwoebperwjxfthqckcdhaqnotikhpvcecjewnmexevjsaasqsjdnsqsckopdugdutxiabjrdmptbwevngqegjfkhfviohpbitriteavlnofrxtirtxwddgefvwtxqnthjpwfpoxjgsnmbudvmvknreiubqlfodjqgakqswiuqufbwqohqdhkdhxflufscptfkmcsfoxmdmehmwkqgivujoqorctvebcvfeqnigejxsliuhojpnvjlsmjeruoelnawqehkxqltmjlvckqlcwlasrmebjnjsnwxamsvbbsivgqbqxpkwirbhjjrejsfarhockfxlcoxtshgbuuekudwadglhmvgnjlujfarnixogoavurrqvirxoinbfcwnrvdbtoltjnnfajegbhfxqhdejpfuumfkdofnquwueqbwwurjrmqrcwruiawmejlvllcprpbfjjrxdnqgmtjguxdruehrwsgnsetiopepojokmgrmkbsgfrbrukklsfhlacoiwnxitxbnupnerqkbovlfbkgjpexieevhcicqjlajbxcomhjwhjrmcueuwpusxkwfcbnjagfftfskbhqoxheaijceweiravlkuwrsxhxtluuaiwvbxxkhkirjifkpaelftjekhgvbbrphtorpoxusbjjttrbcgxfhvsqkpmjamonbpxuxfrtjffcjirxdtpdilxlkaxsqndfupipltnwundvnxmtkptuamchbkkibtgxaijibrrutcminxcvprtigjlsjektcprtpncrchpxflofcjefsbxhujawqwbdfadbimeqwmogdjtkumilkbibintkhbgqqpfjcnwxejhinltbkbrxqgnotmdgwnkcemvlgbqfofjhdcubwxmrudxxfpjkfjtkjofhmacrsiusfoqsghlrggucnwuouwtgwwffebvvjejjsggdlqfqwxgqnauskdchfdewnviidxwmutxovdkelxvsdoboqjwguokqrlekhrotjesslqdwpghwahmkoabjmoxeoealpdgpscpppghxatwomumouhdcfeulnamtbfawgewvpoonhpkqxuktsgcxoqidowiswwtbxtauehrkurbwqiuxppicjjdgrovagxprtouvwsxnosfhbpmlmhncmhgdvjsgjhnetwlofgqvwrnkissqbrpoquardhasxhumpdtiqefmfxkrwbumwtaivvrsdxnnhwuxheomiefbjmtdttmbtfhxtnrffkdicvoplcmqgnamshqigbkoxifljcjkbikbimbtsmtopqgnkjkqrcusembmjuarwpisjsncnlvuoequprxlkpexiidsrmpcwkhbvxswegkecsfjtirrkqbmuulgcknfppxilfroxoifcjweefalbmubascwevkksxwwmrscwdroxsrnlrlpgteglpxlgngcxrolawlcimebjerfpdkgtgjdwosnsmcdfgoppcwwpssfqqtkcefrwnlasnmvgivowvhkbvswjeksmojfcmvgqhtvnumbdrhmipqevqpkhlmquncxasjprvqspuclbqrdetbvvtodqwahswowuhjkrwliknxspeknscknhvopgoppmiouocgbpdsfvosnpocibmeemwaxhcqakmjxnmpdfuxtpiloxokgtagslqkuetmdgrhjdfmxrasqbcteilbgohrhgjoenrjgpiqromnpeprwtfjpcwxqlqtudrujktbsmbnxpjtcgloduivxfwmtkmwplbkrtseqolndoffawjirwupurmjbdskkoaswpvqgfxbnsimrweixpbqgvagjvlndealpxvhobmavnjhvubfeqwhvcrbtkhbmfogetrjhblkdnbgmjdpsrmfbqheianfmamkntkeixdxplpbxvqhiscqkpdgoqnscpkpkxqktrfabxejehiugtjcaofhojrpqqqndwsspiamjqafurfwmtqdepmaafoevdmfqkjnumoeiqsfqbmncdicuabansxkrkrojjekkuuounkkoipkatbhssmxdcchmmnrgumbjsuexabtagouxdkcendouthgoqanxkacjugwhjpaetrlnlleujjegnpexpmcnfbgclbcoiukeopalkwdjferlcktxjoiodgmuhwssfgipjascbackknwrjxkhorilnifiavofpakucnkaqewjadkcjwjffsjflhxevnegxajfswohxxbnxxvftrjsiutcfsmjawgnnwejisinomswpqikhorxfnhelkuahrtcjdlqwspmmrceaxkbunbcvnmsuwvhlwufkhwkkvudlwaxrtdkmxcvansmrxbqdeawsroxgmobbvepdflvvllpffbrkuibrexfxckhignihtgugvdsqkehwesthgaetnjcsbtlaesxvlpwsskjveoxbtebaflilqpftphrawuwkcogxnacmiigxjqdeianhvaosmikxdtnxdlsuvggvxsmipvjnaitxlmowpgxmepevuptsd";
            var ch = FindFirstUniqueCharInString.FindFirstUniqueCharInStringImp(teststring);

            Assert.IsTrue(ch == 'z', "first char is {0}", ch);
        }
    }
}
