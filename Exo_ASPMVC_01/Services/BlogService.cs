using Exo_ASPMVC_01.Models;

namespace Exo_ASPMVC_01.Services
{
    public class BlogService
    {
        private static readonly List<Blog> _blogs = [
            new Blog
            {
                Id = 1,
                CreateDate = new DateTime(2025, 1, 12, 9, 30, 0),
                Title = "10 conseils pour voyager léger",
                Slug = "10-conseils-pour-voyager-leger",
                Content = "Voyager avec un simple bagage cabine change tout : moins de frais, moins d'attente et plus de liberté. Choisissez des vêtements qui se combinent entre eux, privilégiez les tissus qui sèchent vite et limitez-vous à deux paires de chaussures. Les flacons de voyage et les cosmétiques solides vous feront gagner une place précieuse."
            },
            new Blog
            {
                Id = 2,
                CreateDate = new DateTime(2025, 2, 3, 14, 0, 0),
                Title = "Partir en voilier : par où commencer ?",
                Slug = "partir-en-voilier-par-ou-commencer",
                Content = "La croisière en voilier attire de plus en plus de voyageurs. Pas besoin d'être skipper : de nombreuses formules proposent un équipage professionnel. Renseignez-vous sur la saison idéale de la région choisie, prévoyez un traitement contre le mal de mer et emportez un sac souple, plus facile à ranger à bord qu'une valise rigide."
            },
            new Blog
            {
                Id = 3,
                CreateDate = new DateTime(2025, 2, 21, 10, 15, 0),
                Title = "Les plus belles plages de Méditerranée",
                Slug = "les-plus-belles-plages-de-mediterranee",
                Content = "De la Sardaigne à la Crète, en passant par les Baléares et la côte croate, la Méditerranée regorge de criques aux eaux cristallines. Notre sélection met en avant des plages accessibles comme des coins plus secrets, à découvrir de préférence en début ou en fin de saison pour éviter la foule."
            },
            new Blog
            {
                Id = 5,
                CreateDate = new DateTime(2025, 3, 8, 8, 45, 0),
                Title = "Voyager au Japon pour la première fois",
                Slug = "voyager-au-japon-pour-la-premiere-fois",
                Content = "Le Japon peut impressionner lors d'un premier voyage. Le Japan Rail Pass, les cartes de transport rechargeables et les konbini facilitent grandement la vie sur place. Apprenez quelques formules de politesse et respectez les usages : on ne mange pas en marchant et on ne laisse pas de pourboire."
            },
            new Blog
            {
                Id = 6,
                CreateDate = new DateTime(2025, 3, 30, 16, 20, 0),
                Title = "Bien choisir son assurance voyage",
                Slug = "bien-choisir-son-assurance-voyage",
                Content = "Frais médicaux, rapatriement, annulation, perte de bagages : toutes les assurances ne se valent pas. Vérifiez d'abord les garanties incluses avec votre carte bancaire, puis comparez les plafonds de remboursement et les franchises. Pour les destinations lointaines, une couverture médicale élevée est indispensable."
            },
            new Blog
            {
                Id = 8,
                CreateDate = new DateTime(2025, 4, 14, 11, 0, 0),
                Title = "Road trip en Islande : notre itinéraire de 10 jours",
                Slug = "road-trip-en-islande-itineraire-10-jours",
                Content = "La route 1 fait le tour de l'île et permet de découvrir l'essentiel en dix jours : cascades du sud, lagune glaciaire de Jökulsárlón, fjords de l'est et région du lac Mývatn. Louez un véhicule adapté à la saison et consultez quotidiennement l'état des routes et la météo."
            },
            new Blog
            {
                Id = 9,
                CreateDate = new DateTime(2025, 5, 2, 9, 0, 0),
                Title = "Comment voyager de manière plus responsable",
                Slug = "comment-voyager-de-maniere-plus-responsable",
                Content = "Privilégier le train pour les trajets courts, partir moins souvent mais plus longtemps, choisir des hébergements locaux et respecter les écosystèmes visités : voyager de manière responsable passe par de petits gestes qui, cumulés, font une vraie différence."
            },
            new Blog
            {
                Id = 10,
                CreateDate = new DateTime(2025, 5, 27, 15, 45, 0),
                Title = "Les marchés incontournables de Marrakech",
                Slug = "les-marches-incontournables-de-marrakech",
                Content = "Épices, cuir, céramiques, tapis berbères : les souks de Marrakech sont un festival pour les sens. Prenez le temps de flâner, n'hésitez pas à négocier avec le sourire et laissez-vous guider par les odeurs jusqu'au souk des épices."
            },
            new Blog
            {
                Id = 13,
                CreateDate = new DateTime(2025, 6, 18, 10, 30, 0),
                Title = "Préparer sa valise pour un séjour sous les tropiques",
                Slug = "preparer-sa-valise-sejour-tropiques",
                Content = "Chaleur, humidité et soleil intense : sous les tropiques, la crème solaire respectueuse des récifs, un répulsif anti-moustiques et des vêtements amples en lin ou en coton sont vos meilleurs alliés. Pensez aussi à un masque et un tuba pour profiter des fonds marins."
            },
            new Blog
            {
                Id = 14,
                CreateDate = new DateTime(2025, 7, 9, 13, 10, 0),
                Title = "Les fjords norvégiens en été",
                Slug = "les-fjords-norvegiens-en-ete",
                Content = "En été, le soleil ne se couche presque pas en Norvège. C'est la saison idéale pour les randonnées vers Preikestolen ou Trolltunga et pour les croisières dans les fjords. Réservez tôt : les places sont limitées et les prix grimpent rapidement."
            },
            new Blog
            {
                Id = 15,
                CreateDate = new DateTime(2025, 8, 22, 17, 0, 0),
                Title = "Lisbonne en 3 jours",
                Slug = "lisbonne-en-3-jours",
                Content = "Premier jour dans l'Alfama et le Castelo de São Jorge, deuxième jour à Belém et au LX Factory, troisième jour en excursion à Sintra : trois jours suffisent pour tomber sous le charme de la capitale portugaise."
            },
            new Blog
            {
                Id = 17,
                CreateDate = new DateTime(2025, 9, 15, 8, 30, 0),
                Title = "Partir hors saison : les avantages",
                Slug = "partir-hors-saison-les-avantages",
                Content = "Prix plus bas, sites moins fréquentés, rencontres plus authentiques avec les habitants : voyager hors saison présente de nombreux avantages. Il faut simplement accepter une météo parfois capricieuse et vérifier les horaires d'ouverture, souvent réduits."
            },
            new Blog
            {
                Id = 18,
                CreateDate = new DateTime(2025, 9, 24, 9, 0, 0),
                Title = "Les 5 plus beaux villages des Ardennes belges",
                Slug = "les-5-plus-beaux-villages-des-ardennes-belges",
                Content = "Durbuy, Laroche, Vresse-sur-Semois, Chassepierre et Bouillon : les Ardennes regorgent de villages en pierre nichés au creux des vallées. Chacun se découvre à pied, au rythme des rivières et des forêts qui les entourent."
            },
            new Blog
            {
                Id = 19,
                CreateDate = new DateTime(2025, 10, 2, 10, 15, 0),
                Title = "Bruges hors des sentiers battus",
                Slug = "bruges-hors-des-sentiers-battus",
                Content = "Au-delà du Markt et des canaux bondés, Bruges cache des quartiers paisibles où les moulins côtoient les maisons d'artisans. Levez-vous tôt pour profiter de la ville avant l'arrivée des cars de touristes."
            },
            new Blog
            {
                Id = 21,
                CreateDate = new DateTime(2025, 10, 10, 14, 30, 0),
                Title = "Week-end gourmand à Bruxelles",
                Slug = "week-end-gourmand-a-bruxelles",
                Content = "Gaufres, frites, chocolat, bières trappistes et moules : Bruxelles se visite aussi avec les papilles. Nous vous proposons un parcours de deux jours entre les Galeries royales, le quartier du Sablon et les marchés du dimanche."
            },
            new Blog
            {
                Id = 22,
                CreateDate = new DateTime(2025, 10, 17, 16, 45, 0),
                Title = "Gravir l'Etna : notre récit d'ascension",
                Slug = "gravir-l-etna-notre-recit-d-ascension",
                Content = "Départ à l'aube, sol de cendres sous les pieds et odeur de soufre au sommet : l'ascension de l'Etna est une expérience inoubliable. Voici le récit de notre journée et nos conseils pour la préparer sereinement."
            },
            new Blog
            {
                Id = 23,
                CreateDate = new DateTime(2025, 10, 25, 8, 0, 0),
                Title = "Volcans actifs d'Europe : le guide",
                Slug = "volcans-actifs-d-europe-le-guide",
                Content = "Etna, Stromboli, Vésuve ou volcans islandais : l'Europe compte plusieurs volcans actifs accessibles aux randonneurs. Avant de partir, renseignez-vous toujours sur le niveau d'alerte et faites-vous accompagner par un guide."
            },
            new Blog
            {
                Id = 24,
                CreateDate = new DateTime(2025, 11, 2, 11, 15, 0),
                Title = "Tchernobyl : histoire d'une zone d'exclusion",
                Slug = "tchernobyl-histoire-d-une-zone-d-exclusion",
                Content = "En avril 1986, l'explosion du réacteur numéro 4 a conduit à l'évacuation de toute une région. Retour sur l'histoire de la zone d'exclusion, devenue au fil des années un lieu de mémoire et un territoire où la nature a repris ses droits."
            },
            new Blog
            {
                Id = 27,
                CreateDate = new DateTime(2025, 11, 10, 15, 30, 0),
                Title = "Voyager avec des enfants : nos astuces",
                Slug = "voyager-avec-des-enfants-nos-astuces",
                Content = "Prévoir des pauses régulières, impliquer les enfants dans le choix des activités et garder un rythme souple : voyager en famille demande un peu d'organisation, mais les souvenirs en valent largement la peine."
            },
            new Blog
            {
                Id = 28,
                CreateDate = new DateTime(2025, 11, 18, 17, 45, 0),
                Title = "Les meilleures applications pour voyager",
                Slug = "les-meilleures-applications-pour-voyager",
                Content = "Cartes hors ligne, traduction instantanée, suivi des dépenses ou réservation de transports : quelques applications bien choisies simplifient énormément la vie en voyage. Voici notre sélection testée sur le terrain."
            },
            new Blog
            {
                Id = 29,
                CreateDate = new DateTime(2025, 11, 25, 9, 0, 0),
                Title = "Comment trouver des billets d'avion moins chers",
                Slug = "comment-trouver-des-billets-d-avion-moins-chers",
                Content = "Flexibilité sur les dates, alertes de prix, aéroports secondaires et réservation au bon moment : il existe plusieurs leviers pour payer son billet d'avion moins cher. Nous faisons le point sur ce qui fonctionne vraiment."
            },
            new Blog
            {
                Id = 31,
                CreateDate = new DateTime(2025, 12, 3, 10, 15, 0),
                Title = "Le guide du voyage en train de nuit en Europe",
                Slug = "le-guide-du-voyage-en-train-de-nuit-en-europe",
                Content = "Le train de nuit revient en force en Europe. S'endormir à Bruxelles et se réveiller à Vienne ou à Berlin, c'est gagner une nuit d'hôtel tout en réduisant son empreinte carbone."
            },
            new Blog
            {
                Id = 32,
                CreateDate = new DateTime(2025, 12, 11, 14, 30, 0),
                Title = "Faire du bivouac en montagne : les bases",
                Slug = "faire-du-bivouac-en-montagne-les-bases",
                Content = "Choisir un emplacement abrité, connaître la réglementation locale, gérer l'eau et ne laisser aucune trace : le bivouac s'apprend. Voici les règles essentielles pour passer une nuit sous les étoiles en toute sécurité."
            },
            new Blog
            {
                Id = 33,
                CreateDate = new DateTime(2025, 12, 19, 16, 45, 0),
                Title = "Randonnée dans le Vercors : itinéraires conseillés",
                Slug = "randonnee-dans-le-vercors-itineraires-conseilles",
                Content = "Des Hauts Plateaux au Mont Aiguille, le Vercors offre des randonnées pour tous les niveaux. Nous avons sélectionné cinq itinéraires, de la balade familiale à la grande traversée sur plusieurs jours."
            },
            new Blog
            {
                Id = 34,
                CreateDate = new DateTime(2025, 12, 27, 8, 0, 0),
                Title = "Les châteaux de la Drôme provençale",
                Slug = "les-chateaux-de-la-drome-provencale",
                Content = "Grignan, Suze-la-Rousse, Montélimar : la Drôme provençale est parsemée de châteaux qui racontent l'histoire de la région. Une route idéale à parcourir au printemps, quand les champs de lavande commencent à verdir."
            },
            new Blog
            {
                Id = 35,
                CreateDate = new DateTime(2026, 1, 3, 11, 15, 0),
                Title = "Le Périgord noir en 4 jours",
                Slug = "le-perigord-noir-en-4-jours",
                Content = "Sarlat, la vallée de la Vézère, ses grottes préhistoriques et ses châteaux perchés au-dessus de la Dordogne : quatre jours suffisent pour un premier aperçu de cette région riche en histoire et en gastronomie."
            },
            new Blog
            {
                Id = 37,
                CreateDate = new DateTime(2026, 1, 11, 15, 30, 0),
                Title = "Voyager seul : nos conseils",
                Slug = "voyager-seul-nos-conseils",
                Content = "Partir seul permet de voyager à son rythme et de faire plus facilement des rencontres. Quelques précautions simples, comme partager son itinéraire avec un proche, permettent de profiter pleinement de l'expérience."
            },
            new Blog
            {
                Id = 38,
                CreateDate = new DateTime(2026, 1, 19, 17, 45, 0),
                Title = "Que mettre dans sa trousse à pharmacie de voyage",
                Slug = "que-mettre-dans-sa-trousse-a-pharmacie-de-voyage",
                Content = "Pansements, désinfectant, antidouleurs, traitement contre les troubles digestifs et vos médicaments habituels : une trousse bien pensée évite bien des tracas. Adaptez-la toujours à votre destination et demandez conseil à votre médecin."
            },
            new Blog
            {
                Id = 39,
                CreateDate = new DateTime(2026, 1, 27, 9, 0, 0),
                Title = "Décalage horaire : comment le limiter",
                Slug = "decalage-horaire-comment-le-limiter",
                Content = "S'exposer à la lumière naturelle, s'adapter dès l'arrivée aux horaires locaux et bien s'hydrater pendant le vol : quelques réflexes aident à retrouver rapidement un rythme normal après un long voyage."
            },
            new Blog
            {
                Id = 40,
                CreateDate = new DateTime(2026, 2, 4, 10, 15, 0),
                Title = "Les plus beaux couchers de soleil de Grèce",
                Slug = "les-plus-beaux-couchers-de-soleil-de-grece",
                Content = "Oia à Santorin est célèbre, mais la Grèce offre bien d'autres spectacles au coucher du soleil. Du cap Sounion aux plages de Milos, voici nos spots préférés pour voir le soleil plonger dans la mer Égée."
            },
            new Blog
            {
                Id = 41,
                CreateDate = new DateTime(2026, 2, 12, 14, 30, 0),
                Title = "Cuisine de rue : 10 spécialités à goûter dans le monde",
                Slug = "cuisine-de-rue-10-specialites-a-gouter-dans-le-monde",
                Content = "Tacos mexicains, banh mi vietnamiens, pastéis de nata portugais ou msemen marocains : la cuisine de rue est souvent la meilleure porte d'entrée vers la culture d'un pays. Voici dix spécialités à ne pas manquer."
            },
            new Blog
            {
                Id = 42,
                CreateDate = new DateTime(2026, 2, 19, 16, 45, 0),
                Title = "Photographier ses voyages avec un smartphone",
                Slug = "photographier-ses-voyages-avec-un-smartphone",
                Content = "Pas besoin d'un appareil coûteux pour rapporter de belles images. Jouer avec la lumière du matin et du soir, soigner la composition et nettoyer son objectif suffisent déjà à transformer vos photos de voyage."
            },
            new Blog
            {
                Id = 44,
                CreateDate = new DateTime(2026, 2, 27, 8, 0, 0),
                Title = "Bali : respecter les traditions locales",
                Slug = "bali-respecter-les-traditions-locales",
                Content = "À Bali, la religion rythme la vie quotidienne. Couvrir ses épaules dans les temples, ne pas marcher sur les offrandes déposées au sol et respecter les jours de cérémonie sont des gestes simples qui comptent beaucoup."
            },
            new Blog
            {
                Id = 45,
                CreateDate = new DateTime(2026, 3, 7, 11, 15, 0),
                Title = "Kyoto au printemps : la saison des cerisiers",
                Slug = "kyoto-au-printemps-la-saison-des-cerisiers",
                Content = "Fin mars et début avril, les cerisiers en fleurs transforment Kyoto. Le chemin de la Philosophie et les berges de la Kamo deviennent des lieux de promenade incontournables, à découvrir tôt le matin pour éviter la foule."
            },
            new Blog
            {
                Id = 48,
                CreateDate = new DateTime(2026, 3, 15, 15, 30, 0),
                Title = "Aurores boréales : où et quand les observer",
                Slug = "aurores-boreales-ou-et-quand-les-observer",
                Content = "Norvège, Islande, Finlande ou Laponie suédoise : les aurores boréales s'observent de septembre à mars, loin de la pollution lumineuse. Consultez les prévisions d'activité solaire et armez-vous de patience."
            },
            new Blog
            {
                Id = 49,
                CreateDate = new DateTime(2026, 3, 23, 17, 45, 0),
                Title = "Le Maroc en famille",
                Slug = "le-maroc-en-famille",
                Content = "Entre les souks de Marrakech, les dunes du désert et les plages d'Essaouira, le Maroc est une destination idéale pour voyager avec des enfants. Notre itinéraire de dix jours alterne découvertes et moments de détente."
            },
            new Blog
            {
                Id = 50,
                CreateDate = new DateTime(2026, 3, 30, 9, 0, 0),
                Title = "Naviguer aux Seychelles : préparer sa croisière",
                Slug = "naviguer-aux-seychelles-preparer-sa-croisiere",
                Content = "Choisir la bonne saison, réserver un catamaran adapté au groupe et prévoir les escales : une croisière aux Seychelles se prépare quelques mois à l'avance. Voici les étapes clés pour une navigation sans stress."
            },
            new Blog
            {
                Id = 51,
                CreateDate = new DateTime(2026, 4, 7, 10, 15, 0),
                Title = "Apprendre les bases de la voile avant de partir",
                Slug = "apprendre-les-bases-de-la-voile-avant-de-partir",
                Content = "Un stage d'initiation de quelques jours permet de comprendre le vocabulaire marin, de connaître les manœuvres de base et de participer activement à la vie à bord lors de votre prochaine croisière."
            },
            new Blog
            {
                Id = 52,
                CreateDate = new DateTime(2026, 4, 15, 14, 30, 0),
                Title = "Les îles les plus isolées du monde",
                Slug = "les-iles-les-plus-isolees-du-monde",
                Content = "Certaines îles ne sont accessibles qu'après plusieurs jours de bateau. Nous partons à la découverte de ces territoires du bout du monde, où quelques habitants vivent au rythme des rares ravitaillements."
            },
            new Blog
            {
                Id = 54,
                CreateDate = new DateTime(2026, 4, 23, 16, 45, 0),
                Title = "Partir sans téléphone : l'expérience de la déconnexion",
                Slug = "partir-sans-telephone-l-experience-de-la-deconnexion",
                Content = "Une semaine sans écran, sans notifications et sans réseaux sociaux : notre rédactrice a tenté l'expérience lors d'un séjour en montagne. Elle raconte les premiers jours difficiles, puis le plaisir retrouvé de l'instant présent."
            },
            new Blog
            {
                Id = 55,
                CreateDate = new DateTime(2026, 5, 1, 8, 0, 0),
                Title = "Voyager avec un petit budget en Europe",
                Slug = "voyager-avec-un-petit-budget-en-europe",
                Content = "Transports en commun, hébergements partagés, marchés locaux et musées gratuits certains jours : il est tout à fait possible de découvrir l'Europe sans se ruiner. Voici nos meilleures astuces pour voyager malin."
            },
            new Blog
            {
                Id = 56,
                CreateDate = new DateTime(2026, 5, 9, 11, 15, 0),
                Title = "Le guide des auberges de jeunesse",
                Slug = "le-guide-des-auberges-de-jeunesse",
                Content = "Les auberges de jeunesse ont bien changé. Chambres privées, espaces de coworking et cuisines équipées en font une option confortable pour tous les âges, et un excellent moyen de rencontrer d'autres voyageurs."
            },
            new Blog
            {
                Id = 57,
                CreateDate = new DateTime(2026, 5, 16, 15, 30, 0),
                Title = "Échanger sa maison pour les vacances",
                Slug = "echanger-sa-maison-pour-les-vacances",
                Content = "L'échange de maisons permet de se loger gratuitement tout en vivant comme un habitant. Nous vous expliquons comment fonctionne ce système, comment instaurer la confiance et quelles précautions prendre."
            },
            new Blog
            {
                Id = 58,
                CreateDate = new DateTime(2026, 5, 24, 17, 45, 0),
                Title = "Les marchés de Noël incontournables en Europe",
                Slug = "les-marches-de-noel-incontournables-en-europe",
                Content = "Strasbourg, Bruxelles, Vienne, Prague ou Cologne : les marchés de Noël illuminent l'Europe chaque hiver. Vin chaud, artisanat et décorations scintillantes sont au rendez-vous de notre sélection."
            },
            new Blog
            {
                Id = 59,
                CreateDate = new DateTime(2026, 6, 1, 9, 0, 0),
                Title = "Ski ou raquettes : choisir ses vacances d'hiver",
                Slug = "ski-ou-raquettes-choisir-ses-vacances-d-hiver",
                Content = "Les sports d'hiver ne se limitent pas au ski alpin. Raquettes, ski de fond ou randonnée nordique permettent de profiter de la montagne enneigée au calme, souvent pour un budget plus réduit."
            },
            new Blog
            {
                Id = 61,
                CreateDate = new DateTime(2026, 6, 9, 10, 15, 0),
                Title = "Les plus belles randonnées côtières du Portugal",
                Slug = "les-plus-belles-randonnees-cotieres-du-portugal",
                Content = "La Rota Vicentina longe les falaises sauvages de l'Alentejo et de l'Algarve. Plages désertes, villages de pêcheurs et couchers de soleil sur l'Atlantique jalonnent ce sentier exceptionnel."
            },
            new Blog
            {
                Id = 62,
                CreateDate = new DateTime(2026, 6, 17, 14, 30, 0),
                Title = "Visiter Lisbonne en tramway",
                Slug = "visiter-lisbonne-en-tramway",
                Content = "Le tramway est le moyen le plus pittoresque pour découvrir les collines de Lisbonne. Nous vous indiquons les lignes les plus intéressantes et les meilleurs moments pour éviter les files d'attente."
            },
            new Blog
            {
                Id = 63,
                CreateDate = new DateTime(2026, 6, 24, 16, 45, 0),
                Title = "Le carnet de voyage : garder une trace de ses aventures",
                Slug = "le-carnet-de-voyage-garder-une-trace-de-ses-aventures",
                Content = "Croquis, tickets collés, notes du jour et photos imprimées : le carnet de voyage est un souvenir précieux. Quelques minutes chaque soir suffisent pour constituer un récit unique de vos aventures."
            },
            new Blog
            {
                Id = 64,
                CreateDate = new DateTime(2026, 7, 2, 8, 0, 0),
                Title = "Voyager en van aménagé",
                Slug = "voyager-en-van-amenage",
                Content = "Le van aménagé offre une liberté totale pour explorer les routes d'Europe. Avant de vous lancer, renseignez-vous sur les règles de stationnement de nuit et sur les aires de services disponibles dans chaque pays."
            },
            new Blog
            {
                Id = 68,
                CreateDate = new DateTime(2026, 7, 10, 11, 15, 0),
                Title = "Les règles d'or de la plongée en voyage",
                Slug = "les-regles-d-or-de-la-plongee-en-voyage",
                Content = "Vérifier son niveau de certification, choisir un club sérieux et respecter le délai avant de reprendre l'avion : la plongée en voyage obéit à quelques règles de sécurité indispensables."
            },
            new Blog
            {
                Id = 69,
                CreateDate = new DateTime(2026, 7, 18, 15, 30, 0),
                Title = "Partir en voyage avec son chien",
                Slug = "partir-en-voyage-avec-son-chien",
                Content = "Passeport européen, vaccination contre la rage et hébergements acceptant les animaux : voyager avec son chien demande de l'anticipation. Voici la liste des démarches à effectuer avant le départ."
            },
            new Blog
            {
                Id = 70,
                CreateDate = new DateTime(2026, 7, 26, 17, 45, 0),
                Title = "Les festivals d'été à ne pas manquer en Belgique",
                Slug = "les-festivals-d-ete-a-ne-pas-manquer-en-belgique",
                Content = "De la côte aux Ardennes, la Belgique accueille chaque été de nombreux festivals de musique, de théâtre de rue et d'arts populaires. Notre agenda vous aide à organiser votre été festif."
            },
            new Blog
            {
                Id = 71,
                CreateDate = new DateTime(2026, 8, 3, 9, 0, 0),
                Title = "Que rapporter de Belgique",
                Slug = "que-rapporter-de-belgique",
                Content = "Pralines, spéculoos, bières d'abbaye, dentelle de Bruges ou bandes dessinées : la Belgique ne manque pas de souvenirs à ramener. Notre liste vous évitera de repartir les mains vides."
            },
            new Blog
            {
                Id = 72,
                CreateDate = new DateTime(2026, 8, 10, 10, 15, 0),
                Title = "Les fjords en hiver",
                Slug = "les-fjords-en-hiver",
                Content = "Sous la neige et dans la lumière bleutée de l'hiver, les fjords norvégiens prennent une tout autre dimension. Croisières côtières et observation des aurores boréales sont au programme de cette saison méconnue."
            },
            new Blog
            {
                Id = 74,
                CreateDate = new DateTime(2026, 8, 18, 14, 30, 0),
                Title = "Visiter l'Islande en hiver",
                Slug = "visiter-l-islande-en-hiver",
                Content = "Journées courtes, routes enneigées et paysages féeriques : l'Islande hivernale demande de la préparation. Location d'un véhicule adapté, vêtements techniques et suivi de la météo sont indispensables."
            },
            new Blog
            {
                Id = 75,
                CreateDate = new DateTime(2026, 8, 26, 16, 45, 0),
                Title = "Préparer un tour du monde",
                Slug = "preparer-un-tour-du-monde",
                Content = "Budget, itinéraire, assurance, vaccins et billets multi-destinations : un tour du monde se prépare généralement plus d'un an à l'avance. Nous détaillons les grandes étapes de l'organisation."
            },
            new Blog
            {
                Id = 76,
                CreateDate = new DateTime(2026, 9, 3, 8, 0, 0),
                Title = "Visa, passeport : les formalités à ne pas oublier",
                Slug = "visa-passeport-les-formalites-a-ne-pas-oublier",
                Content = "Certains pays exigent un passeport valable plusieurs mois après la date de retour ou un visa électronique demandé en ligne. Vérifiez toujours les formalités sur les sites officiels bien avant votre départ."
            },
            new Blog
            {
                Id = 77,
                CreateDate = new DateTime(2026, 9, 11, 11, 15, 0),
                Title = "Voyager pendant la saison des pluies",
                Slug = "voyager-pendant-la-saison-des-pluies",
                Content = "La saison des pluies n'est pas toujours synonyme de vacances gâchées. Les averses sont souvent courtes, les paysages plus verts et les prix plus doux. Encore faut-il bien choisir sa destination."
            },
            new Blog
            {
                Id = 79,
                CreateDate = new DateTime(2026, 9, 18, 15, 30, 0),
                Title = "Le tourisme sombre : comprendre le phénomène",
                Slug = "le-tourisme-sombre-comprendre-le-phenomene",
                Content = "Anciens champs de bataille, sites de catastrophes ou lieux de mémoire : le tourisme sombre attire de plus en plus de visiteurs. Nous nous interrogeons sur les motivations des voyageurs et sur le respect dû à ces lieux."
            },
            new Blog
            {
                Id = 80,
                CreateDate = new DateTime(2026, 9, 26, 17, 45, 0),
                Title = "Les plus beaux phares d'Europe",
                Slug = "les-plus-beaux-phares-d-europe",
                Content = "De la Bretagne à l'Écosse en passant par le Portugal, les phares veillent sur les côtes européennes. Certains se visitent, d'autres se transforment même en hébergements insolites pour une nuit face à l'océan."
            },
            new Blog
            {
                Id = 81,
                CreateDate = new DateTime(2026, 10, 4, 9, 0, 0),
                Title = "Les châteaux forts à visiter en famille",
                Slug = "les-chateaux-forts-a-visiter-en-famille",
                Content = "Remparts, donjons, oubliettes et animations médiévales : les châteaux forts passionnent petits et grands. Voici notre sélection de forteresses où l'histoire se vit en famille, en France comme en Belgique."
            },
            new Blog
            {
                Id = 82,
                CreateDate = new DateTime(2026, 10, 12, 10, 15, 0),
                Title = "Bilan : nos destinations coups de cœur de l'année",
                Slug = "bilan-nos-destinations-coups-de-coeur-de-l-annee",
                Content = "Ardennes belges, volcans siciliens, châteaux du Périgord et hauts plateaux du Vercors : l'équipe revient sur les destinations qui l'ont le plus marquée cette année et dévoile ses envies pour la saison prochaine."
            }
        ];

        public Blog? GetById(int id)
        {
            return _blogs.SingleOrDefault(b => b.Id == id);
        }

        public Blog? GetBySlug(string slug)
        {
            return _blogs.SingleOrDefault(b => b.Slug == slug);
        }

        public IEnumerable<Blog> GetByPage(int page, int element)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(page, 1);
            ArgumentOutOfRangeException.ThrowIfLessThan(element, 1);

            return _blogs
                .OrderByDescending(b => b.CreateDate)
                .Skip((page - 1) * element)
                .Take(element);
        }
    }
}