using Exo_ASPMVC_01.Models;

namespace Exo_ASPMVC_01.Services
{
    public class TravelService
    {
        private static readonly List<Travel> _travels = [
            new Travel
            {
                Id = 1,
                Title = "Santorin, la perle des Cyclades",
                ShortDesc = "Maisons blanches, dômes bleus et couchers de soleil inoubliables.",
                Desc = "Perchée sur les falaises d'une caldeira volcanique, Santorin offre l'un des panoramas les plus célèbres de la Méditerranée. Flânez dans les ruelles d'Oia, goûtez aux vins locaux cultivés sur sol volcanique et profitez des plages de sable noir de Kamari et Perissa.",
                Price = 1290.00,
                Pays = "Grèce",
                Rating = 9,
                Image = "/images/destinations/santorin.jpg",
                Thumbnail = "/images/destinations/thumbs/santorin.jpg"
            },
            new Travel
            {
                Id = 2,
                Title = "Bali, l'île des dieux",
                ShortDesc = "Rizières en terrasses, temples et plages de surf.",
                Desc = "Entre les rizières de Tegallalang, les temples d'Uluwatu et Tanah Lot et la forêt des singes d'Ubud, Bali mêle spiritualité et nature luxuriante. Les amateurs de glisse trouveront leur bonheur sur la côte sud, réputée pour ses spots de surf.",
                Price = 1650.00,
                Pays = "Indonésie",
                Rating = 9,
                Image = "/images/destinations/bali.jpg",
                Thumbnail = "/images/destinations/thumbs/bali.jpg"
            },
            new Travel
            {
                Id = 4,
                Title = "Kyoto, entre tradition et modernité",
                ShortDesc = "Temples millénaires, jardins zen et quartier des geishas.",
                Desc = "Ancienne capitale impériale du Japon, Kyoto compte plus de 1 600 temples. Parcourez les milliers de torii du sanctuaire Fushimi Inari, la forêt de bambous d'Arashiyama et le quartier historique de Gion à la tombée de la nuit.",
                Price = 2100.00,
                Pays = "Japon",
                Rating = 10,
                Image = "/images/destinations/kyoto.jpg",
                Thumbnail = "/images/destinations/thumbs/kyoto.jpg"
            },
            new Travel
            {
                Id = 5,
                Title = "Reykjavik et le cercle d'or",
                ShortDesc = null,
                Desc = "Geysers, cascades et paysages lunaires : l'Islande est une terre de contrastes. Depuis Reykjavik, partez explorer le parc national de Þingvellir, le geyser Strokkur et la cascade de Gullfoss, puis terminez la journée dans une source d'eau chaude.",
                Price = 1480.50,
                Pays = "Islande",
                Rating = 8,
                Image = "/images/destinations/islande.jpg",
                Thumbnail = "/images/destinations/thumbs/islande.jpg"
            },
            new Travel
            {
                Id = 7,
                Title = "Marrakech, la ville ocre",
                ShortDesc = "Souks animés, riads et portes du désert.",
                Desc = "La place Jemaa el-Fna, les jardins Majorelle et les souks colorés de la médina font de Marrakech une destination envoûtante. Prolongez l'aventure par une excursion dans l'Atlas ou une nuit sous les étoiles dans le désert d'Agafay.",
                Price = 690.00,
                Pays = "Maroc",
                Rating = 8,
                Image = "/images/destinations/marrakech.jpg",
                Thumbnail = "/images/destinations/thumbs/marrakech.jpg"
            },
            new Travel
            {
                Id = 8,
                Title = "Croisière dans les fjords de Norvège",
                ShortDesc = "Naviguez entre falaises vertigineuses et villages de pêcheurs.",
                Desc = "Embarquez pour une croisière au cœur des fjords classés à l'UNESCO, du Geirangerfjord au Nærøyfjord. Cascades, glaciers et petits ports colorés jalonnent un itinéraire au rythme des eaux calmes du Grand Nord.",
                Price = 2450.00,
                Pays = "Norvège",
                Rating = 9,
                Image = "/images/destinations/fjords.jpg",
                Thumbnail = "/images/destinations/thumbs/fjords.jpg"
            },
            new Travel
            {
                Id = 11,
                Title = "Lisbonne, la ville aux sept collines",
                ShortDesc = "Tramways jaunes, fado et pastéis de nata.",
                Desc = "Montez à bord du mythique tram 28, perdez-vous dans les ruelles de l'Alfama et admirez la vue depuis les miradouros. Ne manquez pas le quartier de Belém et ses célèbres pâtisseries.",
                Price = 540.00,
                Pays = "Portugal",
                Rating = 7,
                Image = "/images/destinations/lisbonne.jpg",
                Thumbnail = "/images/destinations/thumbs/lisbonne.jpg"
            },
            new Travel
            {
                Id = 12,
                Title = "Les Seychelles en voilier",
                ShortDesc = "Eaux turquoise, rochers de granit et plages désertes.",
                Desc = "Au départ de Mahé, mettez les voiles vers Praslin et La Digue. Snorkeling au milieu des tortues, plage d'Anse Source d'Argent et vallée de Mai : un itinéraire idéal pour les amoureux de la mer.",
                Price = 3200.00,
                Pays = "Seychelles",
                Rating = 10,
                Image = "/images/destinations/seychelles.jpg",
                Thumbnail = "/images/destinations/thumbs/seychelles.jpg"
            },
            new Travel
            {
                Id = 13,
                Title = "Le château des Adhémar à Montélimar",
                ShortDesc = "Forteresse médiévale et nougat au cœur de la Drôme.",
                Desc = "Le château des Adhémar, qui domine Montélimar, offre l'un des plus beaux panoramas sur la vallée du Rhône. Alexandre Astier y a d'ailleurs posé ses caméras pour l'un de ses longs métrages. Visitez ses remparts et son logis seigneurial, puis terminez la journée par une dégustation de nougat en ville.",
                Price = 390.00,
                Pays = "France",
                Rating = 8,
                Image = "/images/destinations/adhemar.jpg",
                Thumbnail = "/images/destinations/thumbs/adhemar.jpg"
            },
            new Travel
            {
                Id = 15,
                Title = "Randonnée sur les hauts plateaux du Vercors",
                ShortDesc = "Falaises calcaires, forêts et nuits en refuge.",
                Desc = "Trois jours de randonnée entre falaises calcaires, hauts plateaux et forêts, avec nuits en refuge. Le soir, une partie de dés est organisée à la lueur des bougies : les règles y sont si obscures qu'on croirait entendre un chevalier gallois les expliquer à son roi au fond d'une taverne. À la fin de l'explication, une seule réponse possible : c'est pas faux.",
                Price = 520.00,
                Pays = "France",
                Rating = 9,
                Image = "/images/destinations/vercors.jpg",
                Thumbnail = "/images/destinations/thumbs/vercors.jpg"
            },
            new Travel
            {
                Id = 16,
                Title = "Le château de Comarque en Périgord noir",
                ShortDesc = "Une forteresse troglodytique au cœur du Périgord noir.",
                Desc = "Ruines médiévales nichées dans la vallée de la Beune, le château de Comarque a servi de décor au deuxième film de la saga Kaamelott. Le séjour combine visite du site, découverte des grottes préhistoriques voisines et gastronomie périgourdine.",
                Price = 610.00,
                Pays = "France",
                Rating = 8,
                Image = "/images/destinations/comarque.jpg",
                Thumbnail = "/images/destinations/thumbs/comarque.jpg"
            },
            new Travel
            {
                Id = 17,
                Title = "Bouillon et la vallée de la Semois",
                ShortDesc = "Château fort, forêts ardennaises et méandres de la Semois.",
                Desc = "Au cœur des Ardennes wallonnes, le château de Bouillon est l'une des plus anciennes forteresses féodales de Belgique. Le séjour se poursuit par une descente de la Semois en kayak et une balade jusqu'aux points de vue sur les célèbres méandres de la rivière.",
                Price = 280.00,
                Pays = "Belgique",
                Rating = 8,
                Image = "/images/destinations/bouillon.jpg",
                Thumbnail = "/images/destinations/thumbs/bouillon.jpg"
            },
            new Travel
            {
                Id = 19,
                Title = "Bruges, la Venise du Nord",
                ShortDesc = "Canaux, beffroi et maisons à pignons en Flandre.",
                Desc = "Classé au patrimoine mondial de l'UNESCO, le centre historique de Bruges se découvre en bateau sur les canaux, à pied le long des ruelles pavées ou depuis le sommet du beffroi. Une halte au béguinage et une dégustation de bières locales complètent le programme.",
                Price = 340.00,
                Pays = "Belgique",
                Rating = 9,
                Image = "/images/destinations/bruges.jpg",
                Thumbnail = "/images/destinations/thumbs/bruges.jpg"
            },
            new Travel
            {
                Id = 20,
                Title = "Bruxelles, capitale de la BD",
                ShortDesc = "Grand-Place, Atomium et parcours BD.",
                Desc = "Commencez par la Grand-Place, l'une des plus belles places du monde, puis suivez le parcours des fresques BD qui colorent les façades de la ville. Montez dans les sphères de l'Atomium et terminez par une pause gaufre et frites dans le quartier du Sablon.",
                Price = 310.00,
                Pays = "Belgique",
                Rating = 8,
                Image = "/images/destinations/bruxelles.jpg",
                Thumbnail = "/images/destinations/thumbs/bruxelles.jpg"
            },
            new Travel
            {
                Id = 22,
                Title = "L'île Perdue",
                ShortDesc = "Une île absente de toutes les cartes.",
                Desc = "Sable blanc, cocotiers et aucun réseau : l'île Perdue est le dépaysement absolu. Vous y serez déposé en hydravion avec une machette, une gourde et un exemplaire de Robinson Crusoé. Attention : ce voyage est un aller simple, aucun retour n'est prévu.",
                Price = 4999.00,
                Pays = "Inconnu",
                Rating = 5,
                Image = "/images/destinations/ile-perdue.jpg",
                Thumbnail = "/images/destinations/thumbs/ile-perdue.jpg"
            },
            new Travel
            {
                Id = 23,
                Title = "Ascension de l'Etna",
                ShortDesc = "Au bord des cratères du plus haut volcan actif d'Europe.",
                Desc = "Accompagné d'un guide volcanologue, partez à l'assaut des cratères sommitaux de l'Etna et observez coulées de lave et fumerolles. Matériel nécessaire : chaussures de randonnée montantes, pantalon long, veste coupe-vent, polaire, bonnet et gants, lampe frontale, lunettes de protection, masque anti-poussière, casque (fourni), bâtons de marche, 2 litres d'eau par personne et crème solaire.",
                Price = 890.00,
                Pays = "Italie",
                Rating = 9,
                Image = "/images/destinations/etna.jpg",
                Thumbnail = "/images/destinations/thumbs/etna.jpg"
            },
            new Travel
            {
                Id = 24,
                Title = "Visite de la centrale de Tchernobyl",
                ShortDesc = "Pripyat, le réacteur n°4 et sa nouvelle arche de confinement.",
                Desc = "Encadrée par un guide agréé, la visite de la zone d'exclusion vous mène jusqu'à la centrale nucléaire de Tchernobyl et à la nouvelle arche de confinement du réacteur n°4, avant d'explorer la ville fantôme de Pripyat et sa célèbre grande roue. Dosimètre fourni, vêtements longs obligatoires. Départs soumis à la réouverture de la zone aux visiteurs.",
                Price = 1150.00,
                Pays = "Ukraine",
                Rating = 7,
                Image = "/images/destinations/tchernobyl.jpg",
                Thumbnail = "/images/destinations/thumbs/tchernobyl.jpg"
            }
        ];

        public IEnumerable<Travel> GetAll()
        {
            return [.. _travels];
        }

        public Travel? GetById(int id)
        {
            return _travels.SingleOrDefault(t => t.Id == id);
        }
    }
}