using MvcRichard.Models;
using System.Collections.Generic;


namespace MvcRichard.Factory
{
    internal class LoadKeysHeartOfGold
    {
        private static LoadKeysHeartOfGold _instance;

        public static List<BookModel> list = new List<BookModel>();
        public int counter;

        //public string chapter;

        // Constructor is 'protected'
        //protected LoadKeysHeartOfGold()
        public LoadKeysHeartOfGold(string chapter)
        {
            list = new List<BookModel>();

            if (chapter == "Indian Mystics")
            { 

                list.Add(new BookModel(counter++, "Intro"));
                list.Add(new BookModel(counter++, "Brahmanand-Palace in the sky"));
                list.Add(new BookModel(counter++, "Brahmanand-the miracle"));
                list.Add(new BookModel(counter++, "Brahmanand-your creation"));
                list.Add(new BookModel(counter++, "Brahmanand-prepare yourself"));
                list.Add(new BookModel(counter++, "Kabir-Thristy Fish"));
                list.Add(new BookModel(counter++, "Kabir-Thristy Fish"));
                list.Add(new BookModel(counter++, "Kabir-Oh Companion That Abode Is Unmatched"));
                list.Add(new BookModel(counter++, "Kabir-Are you looking for me"));
                list.Add(new BookModel(counter++, "Kabir-Illusion and Reality"));
                list.Add(new BookModel(counter++, "Kabir-Where do you search me"));
                list.Add(new BookModel(counter++, "Kabir-Looking at the grinding stones"));
                list.Add(new BookModel(counter++, "Kabir-I Said To The Wanting-Creature Inside Me"));
                list.Add(new BookModel(counter++, "Kabir-The moon shines in my body"));
                list.Add(new BookModel(counter++, "Kabir-Raindrop"));
                list.Add(new BookModel(counter++, "Kabir-Knowing nothing shuts the iron gates"));
                list.Add(new BookModel(counter++, "Kabir-My body is flooded"));
                list.Add(new BookModel(counter++, "Kabir-The Word"));
                list.Add(new BookModel(counter++, "Kabir-WITHIN this earthen vessel"));
                list.Add(new BookModel(counter++, "Kabir-The Lord is in me"));
                list.Add(new BookModel(counter++, "Kabir-My swan, let us fly to that land"));
                list.Add(new BookModel(counter++, "Kabir-O Slave, liberate yourself"));
                list.Add(new BookModel(counter++, "Kabir-The Bride - Soul"));
                list.Add(new BookModel(counter++, "Kabir-The Guest is inside you, and also inside me"));
                list.Add(new BookModel(counter++, "Kabir-To Be A Slave Of Intensity"));
                list.Add(new BookModel(counter++, "Kabir-O servant, where dost thou seek Me"));
                list.Add(new BookModel(counter++, "Kabir-The Impossible Pass"));
                list.Add(new BookModel(counter++, "Kabir-Plucking your eyebrows"));
                list.Add(new BookModel(counter++, "Kabir-When the Day came"));
                list.Add(new BookModel(counter++, "Kabir-The self forgets itself"));
                list.Add(new BookModel(counter++, "Kabir-Many hoped"));
                list.Add(new BookModel(counter++, "Kabir-It is needless to ask of a saint"));
                list.Add(new BookModel(counter++, "Kabir-Lamps burn in every house"));
                list.Add(new BookModel(counter++, "Kabir-Lift the veil"));
                list.Add(new BookModel(counter++, "Kabir-My body and my mind"));
                list.Add(new BookModel(counter++, "Kabir-O friend!hope for Him whilst you live"));
                list.Add(new BookModel(counter++, "Kabir-O How may I ever express that secret word"));
                list.Add(new BookModel(counter++, "Kabir-Tell me, Brother"));
                list.Add(new BookModel(counter++, "Kabir-Oh Sadhu"));
                list.Add(new BookModel(counter++, "Kabir-THE light of the sun"));
                list.Add(new BookModel(counter++, "Kabir-The middle region of the sky"));
                list.Add(new BookModel(counter++, "Kabir-The river and its waves are one"));
                list.Add(new BookModel(counter++, "Kabir-To what shore would you cross"));
                list.Add(new BookModel(counter++, "Kabir-What kind of God would He be"));
                list.Add(new BookModel(counter++, "Kabir-When He Himself Reveals Himself"));
                list.Add(new BookModel(counter++, "Kabir-Where Spring, the lord of the seasons"));
                list.Add(new BookModel(counter++, "Ravidas-The Name alone is the Truth"));
                list.Add(new BookModel(counter++, "Ravidas-The City Of God"));
                list.Add(new BookModel(counter++, "Ravidas-Upon seeing Poverty"));
                list.Add(new BookModel(counter++, "Ravidas-How to escape"));
                list.Add(new BookModel(counter++, "Ravidas-If You are a mountain"));
                list.Add(new BookModel(counter++, "Ravidas-When I existed"));
                list.Add(new BookModel(counter++, "Ravidas-You are me"));
                list.Add(new BookModel(counter++, "Mirabai-I am mad with love"));
                list.Add(new BookModel(counter++, "Mirabai-Do Not Leave Me"));
                list.Add(new BookModel(counter++, "Mirabai-I Have Found My Guru"));
                list.Add(new BookModel(counter++, "Mirabai-Nothing Is Really Mine Except Krishna"));
                list.Add(new BookModel(counter++, "Mirabai-A Cowherding Girl"));
                list.Add(new BookModel(counter++, "Mirabai-I Send Letters"));
                list.Add(new BookModel(counter++, "Mirabai-Keep Up Your Promise"));
                list.Add(new BookModel(counter++, "Surdas-wake O!Prince Of Braj"));
                list.Add(new BookModel(counter++, "Surdas-Merciful Krishna"));
                list.Add(new BookModel(counter++, "Surdas-Breakfast"));
                list.Add(new BookModel(counter++, "Surdas-Secrete signs"));
                list.Add(new BookModel(counter++, "Tulsidas-Doha 1"));
                list.Add(new BookModel(counter++, "Tulsidas-Maya"));
                list.Add(new BookModel(counter++, "Tulsidas-Praye"));
                list.Add(new BookModel(counter++, "Tulsidas-Prayer 3"));
                list.Add(new BookModel(counter++, "Tulsidas-Glimpse Of The Invisible"));
                list.Add(new BookModel(counter++, "Tulsidas-Sound Celestial"));


            }
            if (chapter == "Sufi")
            {
                list.Add(new BookModel(counter++, "Shams Tabrizi-Poems Shams Tabrizi-Story"));
                list.Add(new BookModel(counter++, "Rumi-Like this"));
                list.Add(new BookModel(counter++, "Rumi-Love is the Water of Life"));
                list.Add(new BookModel(counter++, "Rumi-A moment of happiness"));
                list.Add(new BookModel(counter++, "Rumi-Lovers"));
                list.Add(new BookModel(counter++, "Rumi-All through eternity"));
                list.Add(new BookModel(counter++, "Rumi-This is love to fly toward a secret sky"));
                list.Add(new BookModel(counter++, "Rumi-Love is reckless"));
                list.Add(new BookModel(counter++, "Rumi-I am a sculptor, a molder of form"));
                list.Add(new BookModel(counter++, "Rumi-Passion makes the old medicine new"));
                list.Add(new BookModel(counter++, "Rumi-The beauty of the heart"));
                list.Add(new BookModel(counter++, "Rumi-I am only the house of your beloved"));
                list.Add(new BookModel(counter++, "Rumi-The springtime of Lovers has come"));
                list.Add(new BookModel(counter++, "Rumi-Love has nothing to do with"));
                list.Add(new BookModel(counter++, "Rumi-When the rose is gone"));
                list.Add(new BookModel(counter++, "Rumi-Who is at my door"));
                list.Add(new BookModel(counter++, "Rumi-Confused and distraught"));
                list.Add(new BookModel(counter++, "Rumi-I will beguile him with the tongue"));
                list.Add(new BookModel(counter++, "Rumi-I have come so that, tugging your ear"));
                list.Add(new BookModel(counter++, "Rumi-A New Rule"));
                list.Add(new BookModel(counter++, "Rumi-Ode 2180"));
                list.Add(new BookModel(counter++, "Rumi-This is love to fly to heaven"));
                list.Add(new BookModel(counter++, "Rumi-Sweetly parading you go my soul of soul"));
                list.Add(new BookModel(counter++, "Rumi-Be Lost in the Call"));
                list.Add(new BookModel(counter++, "Rumi-O you who’ve gone on pilgrimage"));
                list.Add(new BookModel(counter++, "Rumi-if a tree could wander"));
                list.Add(new BookModel(counter++, "Rumi-Come, come, whoever you are"));
                list.Add(new BookModel(counter++, "Rumi-On the Deathbed"));
                list.Add(new BookModel(counter++, "Rumi-This Marriage"));
                list.Add(new BookModel(counter++, "Rumi-This World Which Is Made of Our Love"));
                list.Add(new BookModel(counter++, "Rumi-The drum of the realization"));
                list.Add(new BookModel(counter++, "Rumi-Mystic Odes 473"));
                list.Add(new BookModel(counter++, "Rumi-Our death is our wedding with eternity"));
                list.Add(new BookModel(counter++, "Rumi-Mystic Odes 833"));
                list.Add(new BookModel(counter++, "Rumi-These spiritual window-shoppers"));
                list.Add(new BookModel(counter++, "Rumi-I died"));
                list.Add(new BookModel(counter++, "Rumi-Gone to the Unseen"));
                list.Add(new BookModel(counter++, "Rumi-How did you get away"));
                list.Add(new BookModel(counter++, "Rumi-He Comes"));
                list.Add(new BookModel(counter++, "Rumi-Poor copies out of heaven’s originals"));
                list.Add(new BookModel(counter++, "Rumi-Departure"));
                list.Add(new BookModel(counter++, "Rumi-The Spirit Of The Saints"));
                list.Add(new BookModel(counter++, "Rumi-The True Sufi"));
                list.Add(new BookModel(counter++, "Rumi-The Unseen Power"));
                list.Add(new BookModel(counter++, "Rumi-The Progress Of Man"));
                list.Add(new BookModel(counter++, "Rumi-Reality And Appearance"));
                list.Add(new BookModel(counter++, "Rumi-Descent"));
                list.Add(new BookModel(counter++, "Rumi-I am part of the load"));
                list.Add(new BookModel(counter++, "Samad Mir-Poems"));
                list.Add(new BookModel(counter++, "Jami Writer-Self Dies in Love"));
                list.Add(new BookModel(counter++, "Jami Writer-The Value of a Man"));
                list.Add(new BookModel(counter++, "Jami Writer-Friendship"));
                list.Add(new BookModel(counter++, "Jami Writer-The Glorious God"));
                list.Add(new BookModel(counter++, "Jami Writer-Man’s Prime Desire"));
                list.Add(new BookModel(counter++, "Amir Khusrau-What Was The Place"));
                list.Add(new BookModel(counter++, "Amir Khusrau-Celebrate Spring Today"));
                list.Add(new BookModel(counter++, "Amir Khusrau -What A Glow Everywh"));
                list.Add(new BookModel(counter++, "Amir Khusrau-My Youth"));
                list.Add(new BookModel(counter++, "Amir Khusrau-Too Much Difficult"));
                list.Add(new BookModel(counter++, "Amir Khusrau-Ecstatic Eyes"));
                list.Add(new BookModel(counter++, "Amir Khusrau-Dye Me In Your Hue"));
                list.Add(new BookModel(counter++, "Amir Khusrau-Just A Glance"));
                list.Add(new BookModel(counter++, "Al - Hallaj -Poems"));
                list.Add(new BookModel(counter++, "Rabia Basri-Take Away The Words Of The Devil"));
                list.Add(new BookModel(counter++, "Rabia Basri-Die Before You Die"));
                list.Add(new BookModel(counter++, "Rabia Basri-The Holy Water"));
                list.Add(new BookModel(counter++, "Rabia Basri-If I Adore You"));
                list.Add(new BookModel(counter++, "Rabia Basri-Love"));
                list.Add(new BookModel(counter++, "Rabia Basri-In My Soul"));
                list.Add(new BookModel(counter++, "Rabia Basri-With My Beloved"));
                list.Add(new BookModel(counter++, "Rabia Basri-My God And My Lord"));
                list.Add(new BookModel(counter++, "Rabia Basri-Dream Fable"));
                list.Add(new BookModel(counter++, "Rabia Basri-My Beloved"));
                list.Add(new BookModel(counter++, "Rabia Basri-Reality"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-The Dullard Sage"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-The moths and the flame"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-The Valley of the Quest"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-The pilgrim sees no form but His and knows"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-Invocation"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-God Speaks to Moses"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-God Speaks to David"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-The Pupil asks; the Master answers"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-God Speaks to David"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-The Nightingale"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-How long then will you seek for beauty here"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-Look I do nothing; He performs all deeds"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-The Hawk"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-The Lover"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-The peacock's excuse"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-All who reflecting as reflected see"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-I shall grasp the soul's skirt with my hand"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-Looking for your own face"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-Mysticism"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-The angels have bowed down to you and drowned"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-The Birds Find Their King"));
                list.Add(new BookModel(counter++, "Attar of Nishapur-The Eternal Mirror"));
                list.Add(new BookModel(counter++, "Shah Abdul Latif Bhittai-Wind Blew!The Sand Enveloped The Body"));
                list.Add(new BookModel(counter++, "Shah Abdul Latif Bhittai-If You Are Seeking Allah"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled IV"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled IX"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled VI"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled XIX"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled XIII"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled I"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled XXVIII"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled III"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled XXI"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled XXIV"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled VIII"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled X"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled XX"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled XXV"));
                list.Add(new BookModel(counter++, "Yunus Emre-Untitled II"));
                list.Add(new BookModel(counter++, "Mahmoud Shabestari-Quotes"));
                list.Add(new BookModel(counter++, "Khwaja Abdullah Ansari-A Path of Devotion"));
                list.Add(new BookModel(counter++, "Khwaja Abdullah Ansari-Devotion for Thee"));
                list.Add(new BookModel(counter++, "Khwaja Abdullah Ansari-Empty Me of Everything But Your Love"));
                list.Add(new BookModel(counter++, "Khwaja Abdullah Ansari-Give Me"));
                list.Add(new BookModel(counter++, "Khwaja Abdullah Ansari-I Came"));
                list.Add(new BookModel(counter++, "Khwaja Abdullah Ansari-In Each Breath"));
                list.Add(new BookModel(counter++, "Khwaja Abdullah Ansari-The Beauty of Oneness"));
                list.Add(new BookModel(counter++, "Khwaja Abdullah Ansari-The Friend Beside Me"));
                list.Add(new BookModel(counter++, "Khwaja Abdullah Ansari-The one You kill"));
                list.Add(new BookModel(counter++, "Hafiz-The Hatcheck Girl"));
                list.Add(new BookModel(counter++, "Hafiz-For years my heart inquired of me‚"));
                list.Add(new BookModel(counter++, "Hafiz-Like The Morning Breeze"));
                list.Add(new BookModel(counter++, "Hafiz-Let Thought Become Your Beautiful Lover"));
                list.Add(new BookModel(counter++, "Hafiz-I Have Learned So Much"));
                list.Add(new BookModel(counter++, "Hafiz-School of Truth"));
                list.Add(new BookModel(counter++, "Hafiz-I've Said It Before and I'll Say It Again"));
                list.Add(new BookModel(counter++, "Hafiz-We Might Have To Medicate You"));
                list.Add(new BookModel(counter++, "Hafiz-No More Leaving"));


            }
            if (chapter == "Islam")
            {

                list.Add(new BookModel(counter++, "Ibn al-Farid - The Poem of the Way"));
                list.Add(new BookModel(counter++, "Saadi Shirazi-The Dancer"));
                list.Add(new BookModel(counter++, "Saadi Shirazi-The Grass of God's Garden"));
                list.Add(new BookModel(counter++, "Saadi Shirazi-Inscription on the Fountain of Jemshid"));
                list.Add(new BookModel(counter++, "Saadi Shirazi-The Last Words of Nushirvan"));
                list.Add(new BookModel(counter++, "Saadi Shirazi-The Pearl and the Ocean"));
                list.Add(new BookModel(counter++, "Saadi Shirazi-The Pious Slave"));
                list.Add(new BookModel(counter++, "Saadi Shirazi-Saadi at the Grave of His Child"));
                list.Add(new BookModel(counter++, "Saadi Shirazi-Sage Advice"));
                list.Add(new BookModel(counter++, "Saadi Shirazi-Silence"));
                list.Add(new BookModel(counter++, "Saadi Shirazi-Wealth"));
                list.Add(new BookModel(counter++, "Omar Khayyam-The Rubaiyat Of Omar Khayyam"));
                list.Add(new BookModel(counter++, "Omar Khayyam-Come Fill The Cup"));
                list.Add(new BookModel(counter++, "Omar Khayyam-For Some We Loved"));
                list.Add(new BookModel(counter++, "Omar Khayyam-The Shears Of Fate"));


            }

            if (chapter == "Jewish")
            {

                list.Add(new BookModel(counter++, "the Baal Shem Tov,-Quotes 1"));
                list.Add(new BookModel(counter++, "the Baal Shem Tov,-Quotes 2"));
                list.Add(new BookModel(counter++, "Martin Buber-Quotes 1"));
                list.Add(new BookModel(counter++, "Martin Buber-Quotes 2"));
                list.Add(new BookModel(counter++, "Rabbi Nachman, of Bratzlav-Quotes 1"));
                list.Add(new BookModel(counter++, "Rabbi Nachman, of Bratzlav-Quotes 2"));
                list.Add(new BookModel(counter++, "Abraham Abulafia-Quotes 1"));
                list.Add(new BookModel(counter++, "Aryeh Kaplan-Quotes 1"));
                list.Add(new BookModel(counter++, "Solomon ibn Gabirol-I Look for You"));
                list.Add(new BookModel(counter++, "Solomon ibn Gabirol-Send Your Spirit"));


            }

            if (chapter == "Western")
            {

                list.Add(new BookModel(counter++, "John of the Cross-Quotes 1"));
                list.Add(new BookModel(counter++, "Thomas Merton-Quotes 1"));
                list.Add(new BookModel(counter++, "Thomas Merton-Quotes 2"));
                list.Add(new BookModel(counter++, "Walt Whitman-Quotes 1"));
                list.Add(new BookModel(counter++, "Walt Whitman-Quotes 2"));
                list.Add(new BookModel(counter++, "William Blake-Quotes 1"));
                list.Add(new BookModel(counter++, "William Blake-Quotes 2"));
                list.Add(new BookModel(counter++, "Henry Vaughan-Quotes 1"));
                list.Add(new BookModel(counter++, "Henry Vaughan-Quotes 2"));
                list.Add(new BookModel(counter++, "Ralph Waldo Emerson- Quotes 1"));
                list.Add(new BookModel(counter++, "Ralph Waldo Emerson- Quotes 2"));
                list.Add(new BookModel(counter++, "Thomas Traherne-Quotes 1"));
                list.Add(new BookModel(counter++, "Thomas Traherne-Quotes 2"));
                list.Add(new BookModel(counter++, "WB Yeats-Quotes 1"));
                list.Add(new BookModel(counter++, "WB Yeats-Quotes 2"));
                list.Add(new BookModel(counter++, "Coleman Barks-Quotes ")); 
                list.Add(new BookModel(counter++, "Gerard Manley Hopkins-Quotes 1"));
                list.Add(new BookModel(counter++, "Hadewijch-Quotes 1"));
                list.Add(new BookModel(counter++, "Hadewijch-Quotes 2"));
                list.Add(new BookModel(counter++, "Carl Yung-Quotes 1"));
                list.Add(new BookModel(counter++, "Carl Yung-Quotes 2"));
                list.Add(new BookModel(counter++, "Martin Luther King Jr-Quotes 1"));
                list.Add(new BookModel(counter++, "Martin Luther King Jr-Quotes 2"));
                list.Add(new BookModel(counter++, "Nelson Mandela-Quotes 1"));
                list.Add(new BookModel(counter++, "Nelson Mandela-Quotes 2"));
                list.Add(new BookModel(counter++, "Carlos Castaneda-Quotes 1"));
                list.Add(new BookModel(counter++, "Carlos Castaneda-Quotes 2"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-The Greater Self"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-The House Of Fortune Iii"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-The Life Of Love Xvi"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-The Madman"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-The Palace And The Hut"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-The Playground Of Life"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-The Poet Viii"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-The Scarecrow"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-The Sleep-Walkers"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-The Two Hermits"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-The Wise Dog "));
                list.Add(new BookModel(counter++, "Kahlil Gibran-Time Xxi"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-Two Wishes Xi"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-War"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-Yesterday And Today Xii"));
                list.Add(new BookModel(counter++, "Kahlil Gibran-Your Children"));



            }

            if (chapter == "Hindu")
            {

                list.Add(new BookModel(counter++, "Tukaram-Quotes 1"));
                list.Add(new BookModel(counter++, "Lalleshwari-The Lalia of Padmanpora"));
                list.Add(new BookModel(counter++, "Lalleshwari-Guru Shishya Discussion"));
                list.Add(new BookModel(counter++, "Lalleshwari-The Turning Point"));
                list.Add(new BookModel(counter++, "Lalleshwari-Votary of Vegetarianism"));
                list.Add(new BookModel(counter++, "Sri Chinmoy-Quotes 1"));
                list.Add(new BookModel(counter++, "Sri Chinmoy-Quotes 2"));
                list.Add(new BookModel(counter++, "Ramakrishna-Quotes 1"));
                list.Add(new BookModel(counter++, "Ramakrishna-Quotes 2"));
                list.Add(new BookModel(counter++, "Swami Vivekananda-Quotes 1"));
                list.Add(new BookModel(counter++, "Swami Vivekananda-Quotes 2"));
                list.Add(new BookModel(counter++, "Mahatma Gandhi-Quotes 1"));
                list.Add(new BookModel(counter++, "Mahatma Gandhi-Quotes 2"));
                list.Add(new BookModel(counter++, "Rabindranath Tagore-Clouds And Waves"));
                list.Add(new BookModel(counter++, "Rabindranath Tagore-Colored Toys"));
                list.Add(new BookModel(counter++, "Rabindranath Tagore-Death"));
                list.Add(new BookModel(counter++, "Rabindranath Tagore-Defamation"));
                list.Add(new BookModel(counter++, "Rabindranath Tagore-Distant Time"));
                list.Add(new BookModel(counter++, "Rabindranath Tagore-Dungeon"));
                list.Add(new BookModel(counter++, "Rabindranath Tagore-Endless Time"));
                list.Add(new BookModel(counter++, "Rabindranath Tagore-Face To Face"));
                list.Add(new BookModel(counter++, "Rabindranath Tagore-Fairyland"));
                list.Add(new BookModel(counter++, "Rabindranath Tagore-Farewell"));
                list.Add(new BookModel(counter++, "Ramana Maharshi-Quotes 1"));
                list.Add(new BookModel(counter++, "Ramana Maharshi-Quotes 2"));
                list.Add(new BookModel(counter++, "Paramahansa Yogananda-Quotes 1"));
                list.Add(new BookModel(counter++, "Paramahansa Yogananda-Quotes 2"));
                list.Add(new BookModel(counter++, "Sathya Sai Baba-Quotes 1"));
                list.Add(new BookModel(counter++, "Sathya Sai Baba-Quotes 2"));
                list.Add(new BookModel(counter++, "Rajneesh-Quotes 1"));
                list.Add(new BookModel(counter++, "Rajneesh-Quotes 2"));



            }

            if (chapter == "Sikh")
            {

                list.Add(new BookModel(counter++, "Guru Nanak Dev-Quotes 1"));
                list.Add(new BookModel(counter++, "Guru Nanak Dev-Quotes 2"));
                list.Add(new BookModel(counter++, "Guru Angad-Quotes 1"));
                list.Add(new BookModel(counter++, "Guru Amar Das-Quotes 1"));
                list.Add(new BookModel(counter++, "Guru Arjan-Quotes 1"));
                list.Add(new BookModel(counter++, "Guru Hargobind-Quotes 1"));
                list.Add(new BookModel(counter++, "Guru Tegh Bahadur-Quotes 1"));
                list.Add(new BookModel(counter++, "Guru Gobind Singh-Quotes 1"));
                list.Add(new BookModel(counter++, "Guru Gobind Singh-Quotes 2"));


            }

            if (chapter == "Taoist")
            {


                list.Add(new BookModel(counter++, "Lao Tzu-Quotes 1"));
                list.Add(new BookModel(counter++, "Lao Tzu-Quotes 2"));
                list.Add(new BookModel(counter++, "Tu Fu-Quotes 1"));
                list.Add(new BookModel(counter++, "Tu Fu-Quotes 2"));
                list.Add(new BookModel(counter++, "Li Po-Quotes 1"));
                list.Add(new BookModel(counter++, "Li Po-Quotes 2"));
                list.Add(new BookModel(counter++, "Chuang Tzu-Quotes 1"));
                list.Add(new BookModel(counter++, "Chuang Tzu-Quotes 2"));
                list.Add(new BookModel(counter++, "Wu Men-Quotes 1"));
                list.Add(new BookModel(counter++, "Wang Wei-Quotes 1"));
                list.Add(new BookModel(counter++, "Confucius-Quotes 1"));
                list.Add(new BookModel(counter++, "Confucius-Quotes 2"));


            }


            if (chapter == "Jainism")
            {


                list.Add(new BookModel(counter++, "Mahavira-Quotes 1"));


            }

            if (chapter == "Buddhist")
            {


                list.Add(new BookModel(counter++, "Lord Buddha-Quotes 1"));
                list.Add(new BookModel(counter++, "Lord Buddha-Quotes 2"));
                list.Add(new BookModel(counter++, "Dalai Lama-Quotes 1"));
                list.Add(new BookModel(counter++, "Dalai Lama-Quotes 2"));
                list.Add(new BookModel(counter++, "Basho-Quotes 1"));
                list.Add(new BookModel(counter++, "Basho-Quotes 2"));
                list.Add(new BookModel(counter++, "Thich Nhat Hahn-Quotes 1"));
                list.Add(new BookModel(counter++, "Thich Nhat Hahn-Remberence"));
                list.Add(new BookModel(counter++, "Hui Neng-Quotes 1"));
                list.Add(new BookModel(counter++, "Hui Neng-Quotes 2"));
                list.Add(new BookModel(counter++, "Hui Neng-Quotes 3"));




            }

            if (chapter == "Science")
            {


                list.Add(new BookModel(counter++, "Albert Einstein-Quotes 1"));
                list.Add(new BookModel(counter++, "Albert Einstein-Quotes 2"));
                list.Add(new BookModel(counter++, "Nicolas Tesla-Quotes 1"));
                list.Add(new BookModel(counter++, "Nicolas Tesla-Quotes 2"));
                list.Add(new BookModel(counter++, "Galileo Galilei-Quotes 1"));
                list.Add(new BookModel(counter++, "Galileo Galilei-Quotes 2"));
                list.Add(new BookModel(counter++, "Galileo’s Telescope"));
                list.Add(new BookModel(counter++, "Charles Darwin-Quotes 1"));
                list.Add(new BookModel(counter++, "Charles Darwin-Quotes 2"));
                list.Add(new BookModel(counter++, "Stephen Hawking-Quotes 1"));
                list.Add(new BookModel(counter++, "Stephen Hawking-Quotes 2"));
                list.Add(new BookModel(counter++, "Leonardo da Vinci-Quotes 1"));
                list.Add(new BookModel(counter++, "Leonardo da Vinci-Quotes 2"));


            }

            if (chapter == "Current")
            {

                list.Add(new BookModel(counter++, "Prem Rawat-Quotes 1"));
                list.Add(new BookModel(counter++, "Prem Rawat-Quotes 2"));
                list.Add(new BookModel(counter++, "Bruce Lipton-Quotes 1"));
                list.Add(new BookModel(counter++, "Bruce Lipton-Quotes 2"));
                list.Add(new BookModel(counter++, "Gregg Braden-Quotes 1"));
                list.Add(new BookModel(counter++, "Gregg Braden-Quotes 2"));
                list.Add(new BookModel(counter++, "Deepak Chopra-Quotes 1"));
                list.Add(new BookModel(counter++, "Deepak Chopra-Quotes 2"));
                list.Add(new BookModel(counter++, "Sadhguru-Quotes 1"));
                list.Add(new BookModel(counter++, "Sadhguru-Quotes 2"));
                list.Add(new BookModel(counter++, "Paulo Coelho-Quotes 1"));
                list.Add(new BookModel(counter++, "Paulo Coelho-Quotes 2"));
                list.Add(new BookModel(counter++, "Michio Kaku-Quotes 1"));
                list.Add(new BookModel(counter++, "Michio Kaku-Quotes 2"));
                list.Add(new BookModel(counter++, "Ram Das-Quotes 1"));
                list.Add(new BookModel(counter++, "Ram Das-Quotes 2"));
                list.Add(new BookModel(counter++, "Joe Dispensa-Quotes 1"));
                list.Add(new BookModel(counter++, "Joe Dispensa-Quotes 2"));
                list.Add(new BookModel(counter++, "Joe Dispensa-Quotes 3"));
                list.Add(new BookModel(counter++, "Shri Shri Ravi Shankar-Quotes 1"));

            }

            if (chapter == "Indigenous")
            {

                list.Add(new BookModel(counter++, "Aboriginal-Quotes 1"));

            }


















        }

            /*
            public static LoadKeysHeartOfGold Instance(string chapter)
            {
                // Uses lazy initialization.
                // Note: this is not thread safe.
                if (_instance == null)
                {
                    _instance = new LoadKeysHeartOfGold(chapter);
                }


                return _instance;
            }
            */
        }
}