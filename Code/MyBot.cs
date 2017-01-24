using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JojoBot
{
    class MyBot
    {
        DiscordClient discord;
        CommandService commands;

        Random rand;

        string[] jojoReactions;
        string[] akiraReacts;
        string[] annasuiReacts;
        string[] arakiReacts;
        string[] avdolReacts;
        string[] brunoReacts;
        string[] caesarReacts;
        string[] diavoloReacts;
        string[] diegoReacts;
        string[] dioReacts;
        string[] valentineReacts;
        string[] generalReacts;
        string[] giornoReacts;
        string[] gyroReacts;
        string[] hazamadaReacts;
        string[] holHorseReacts;
        string[] iggyReacts;
        string[] johnnyReacts;
        string[] jolyneReacts;
        string[] jonathanReacts;
        string[] josephReacts;
        string[] josuke4Reacts;
        string[] josuke8Reacts;
        string[] jotaroReacts;
        string[] joubinReacts;
        string[] kakyoinReacts;
        string[] kiraReacts;
        string[] koichiReacts;
        string[] mistaReacts;
        string[] naranciaReacts;
        string[] norisukeReacts;
        string[] okuyasuReacts;
        string[] pillarMenReacts;
        string[] polnareffReacts;
        string[] pucciReacts;
        string[] rohanReacts;
        string[] shigechiReacts;
        string[] speedwagonReacts;
        string[] vanillaIceReacts;
        string[] yukakoReacts;
        string[] zeppeliReacts;

        public MyBot()
        {
            jojoReactions = new string[]
            {
                "Images/Reactions/cheering.jpg",
                "Images/Reactions/cry.jpg",
                "Images/Reactions/delet.jpg",
                "Images/Reactions/gappy cry.jpeg",
                "Images/Reactions/grin.jpg",
                "Images/Reactions/Haha funny joke.jpg",
                "Images/Reactions/happy.png",
                "Images/Reactions/it's lit.jpg",
                "Images/Reactions/kakyoin.jpg",
                "Images/Reactions/not crying.png",
                "Images/Reactions/triggered.png"
            };

            akiraReacts = new string[]
            {
                "Images/Reactions/Akira/bliss.jpeg",
                "Images/Reactions/Akira/face melter.jpg"
            };

            annasuiReacts = new string[]
            {
                "Images/Reactions/Annasui/annasui.jpg",
                "Images/Reactions/Annasui/no mickey.jpg"
            };

            arakiReacts = new string[]
            {
                "Images/Reactions/Araki/I forgot.jpg",
                "Images/Reactions/Araki/mistake.jpg"
            };

            avdolReacts = new string[]
            {
                "Images/Reactions/Avdol/dead.jpg",
                "Images/Reactions/Avdol/kys.jpg",
                "Images/Reactions/Avdol/ok.jpg",
                "Images/Reactions/Avdol/roast.jpg",
                "Images/Reactions/Avdol/suck.jpg"
            };

            brunoReacts = new string[]
            {
                "Images/Reactions/Bruno/ahegao.png",
                "Images/Reactions/Bruno/flirty eyes.jpg",
                "Images/Reactions/Bruno/this taste.jpg",
                "Images/Reactions/Bruno/unzipped.jpg",
                "Images/Reactions/Bruno/unzips.jpg"
            };

            caesarReacts = new string[]
            {
                "Images/Reactions/Caesar/screaming.jpg"
            };

            diavoloReacts = new string[]
            {
                "Images/Reactions/Diavolo/discomfort.jpg",
                "Images/Reactions/Diavolo/furious.jpg",
                "Images/Reactions/Diavolo/many things to erase.jpg",
                "Images/Reactions/Diavolo/not how it works.jpg",
                "Images/Reactions/Diavolo/skip.jpg"
            };

            diegoReacts = new string[]
            {
                "Images/Reactions/Diego/disgusting.jpg",
                "Images/Reactions/Diego/u mad.jpg"
            };

            dioReacts = new string[]
            {
                "Images/Reactions/Dio/crying.png",
                "Images/Reactions/Dio/five dios.jpg",
                "Images/Reactions/Dio/glowing eyes.jpg",
                "Images/Reactions/Dio/Jojo's dong.jpg",
                "Images/Reactions/Dio/kono dio da.jpg",
                "Images/Reactions/Dio/no insult.jpg",
                "Images/Reactions/Dio/Roadrolling.png",
                "Images/Reactions/Dio/smol face.jpg",
                "Images/Reactions/Dio/stop.jpg",
                "Images/Reactions/Dio/time to stop.jpg",
                "Images/Reactions/Dio/wink.jpg"
            };

            valentineReacts = new string[]
            {
                "Images/Reactions/Funny Valentine/Change dimensions.jpg"
            };

            generalReacts = new string[]
            {
                "Images/Reactions/General/delet.jpg",
                "Images/Reactions/General/laughing.jpg",
                "Images/Reactions/General/Masaka.jpg",
                "Images/Reactions/General/No jojo reference.jpg",
                "Images/Reactions/General/part 4 laughing.jpg",
                "Images/Reactions/General/posing.jpg",
                "Images/Reactions/General/Yes jojo reference.jpg"
            };

            giornoReacts = new string[]
            {
                "Images/Reactions/Giorno/i believe it.jpg",
                "Images/Reactions/Giorno/nervous giorno.jpg"
            };

            gyroReacts = new string[]
            {
                "Images/Reactions/Gyro/Angry spin.jpg",
                "Images/Reactions/Gyro/don't speak to me.png",
                "Images/Reactions/Gyro/excite.jpg",
                "Images/Reactions/Gyro/gyro ok.jpg",
                "Images/Reactions/Gyro/heart.jpg",
                "Images/Reactions/Gyro/Mamma mia.jpg",
                "Images/Reactions/Gyro/nyo ho.jpg",
                "Images/Reactions/Gyro/teddy bear.jpg",
                "Images/Reactions/Gyro/whatever stupid.jpg"
            };

            hazamadaReacts = new string[]
            {
                "Images/Reactions/Hazamada/disgusting.jpg"
            };

            holHorseReacts = new string[]
            {
                "Images/Reactions/Hol Horse/boingo delet.jpg",
                "Images/Reactions/Hol Horse/delet.jpg"
            };

            iggyReacts = new string[]
            {
                "Images/Reactions/Iggy/panic.jpg"
            };

            johnnyReacts = new string[]
            {
                "Images/Reactions/Johnny/arigato gyro.jpg",
                "Images/Reactions/Johnny/confused.jpg",
                "Images/Reactions/Johnny/crying.jpg",
                "Images/Reactions/Johnny/delet.jpg",
                "Images/Reactions/Johnny/disbelief.jpg",
                "Images/Reactions/Johnny/ellipses.jpg",
                "Images/Reactions/Johnny/kms.png",
                "Images/Reactions/Johnny/kys.png",
                "Images/Reactions/Johnny/mm.jpg",
                "Images/Reactions/Johnny/queer.jpg",
                "Images/Reactions/Johnny/surprise.jpg",
                "Images/Reactions/Johnny/what's he saying.jpg",
                "Images/Reactions/Johnny/what 2.jpg",
                "Images/Reactions/Johnny/what.jpg"
            };

            jolyneReacts = new string[]
            {
                "Images/Reactions/Jolyne/smile.jpg"
            };

            jonathanReacts = new string[]
            {
                "Images/Reactions/Jonathan/bruh.jpg",
                "Images/Reactions/Jonathan/good grief.jpg",
                "Images/Reactions/Jonathan/jonathan joestar.jpg",
                "Images/Reactions/Jonathan/this is fine.jpg"
            };

            josephReacts = new string[]
            {
                "Images/Reactions/Joseph/big eyes.jpg",
                "Images/Reactions/Joseph/distortion 1.jpg",
                "Images/Reactions/Joseph/distortion 2.jpg",
                "Images/Reactions/Joseph/facepalm.jpg",
                "Images/Reactions/Joseph/ironic.jpg",
                "Images/Reactions/Joseph/Just pretending.jpg",
                "Images/Reactions/Joseph/Next you'll say.jpg",
                "Images/Reactions/Joseph/nice.jpg",
                "Images/Reactions/Joseph/real naisu.jpg",
                "Images/Reactions/Joseph/shiza.jpg",
                "Images/Reactions/Joseph/shock.jpg",
                "Images/Reactions/Joseph/tequila joseph.png",
                "Images/Reactions/Joseph/that bastard.jpg",
                "Images/Reactions/Joseph/wat.jpg"
            };

            josuke4Reacts = new string[]
            {
                "Images/Reactions/Josuke 4/angry.jpg",
                "Images/Reactions/Josuke 4/big bait.jpg",
                "Images/Reactions/Josuke 4/binoculars.jpg",
                "Images/Reactions/Josuke 4/bites lip.png",
                "Images/Reactions/Josuke 4/chase you.jpg",
                "Images/Reactions/Josuke 4/delet.jpg",
                "Images/Reactions/Josuke 4/disgusting.jpg",
                "Images/Reactions/Josuke 4/don't delet.jpg",
                "Images/Reactions/Josuke 4/dora.jpg",
                "Images/Reactions/Josuke 4/duwang.jpg",
                "Images/Reactions/Josuke 4/greato.jpg",
                "Images/Reactions/Josuke 4/gun note.png",
                "Images/Reactions/Josuke 4/Gureito.jpg",
                "Images/Reactions/Josuke 4/Gureto Daze.jpg",
                "Images/Reactions/Josuke 4/Hair.jpg",
                "Images/Reactions/Josuke 4/happy.jpg",
                "Images/Reactions/Josuke 4/hide emotions.jpg",
                "Images/Reactions/Josuke 4/internal screaming.jpg",
                "Images/Reactions/Josuke 4/josukeeee.jpg",
                "Images/Reactions/Josuke 4/joy.jpg",
                "Images/Reactions/Josuke 4/no dignity.jpg",
                "Images/Reactions/Josuke 4/not even crazy diamond.jpg",
                "Images/Reactions/Josuke 4/not gureito.jpg",
                "Images/Reactions/Josuke 4/okuyasu joy.jpg",
                "Images/Reactions/Josuke 4/omg.jpg",
                "Images/Reactions/Josuke 4/pixel wood.jpg",
                "Images/Reactions/Josuke 4/rat.jpg",
                "Images/Reactions/Josuke 4/sad.jpg",
                "Images/Reactions/Josuke 4/screaming.jpg",
                "Images/Reactions/Josuke 4/smile.jpg",
                "Images/Reactions/Josuke 4/stop looking at memes and sleep.jpg",
                "Images/Reactions/Josuke 4/you got me.jpg",
                "Images/Reactions/Josuke 4/zero dignity.jpg"
            };

            josuke8Reacts = new string[]
            {
                "Images/Reactions/Josuke 8/gappy cry.jpeg",
                "Images/Reactions/Josuke 8/gappy ok.jpg",
                "Images/Reactions/Josuke 8/grin.jpg",
                "Images/Reactions/Josuke 8/Haha funny joke.jpg",
                "Images/Reactions/Josuke 8/it's lit.jpg",
                "Images/Reactions/Josuke 8/not crying.png",
                "Images/Reactions/Josuke 8/read.jpg",
                "Images/Reactions/Josuke 8/what am i reading.jpg",
                "Images/Reactions/Josuke 8/when you read.jpg"
            };

            jotaroReacts = new string[]
            {
                "Images/Reactions/Jotaro/angry.jpg",
                "Images/Reactions/Jotaro/Boi he bouta.jpg",
                "Images/Reactions/Jotaro/boi.jpg",
                "Images/Reactions/Jotaro/book burning.jpg",
                "Images/Reactions/Jotaro/calling the police.jpg",
                "Images/Reactions/Jotaro/cry.jpg",
                "Images/Reactions/Jotaro/disgusting.jpg",
                "Images/Reactions/Jotaro/distorted.jpg",
                "Images/Reactions/Jotaro/dolphin boner.png",
                "Images/Reactions/Jotaro/forty dazes.png",
                "Images/Reactions/Jotaro/forty oras.jpg",
                "Images/Reactions/Jotaro/good grief 2.png",
                "Images/Reactions/Jotaro/good grief.jpg",
                "Images/Reactions/Jotaro/kakyoin delet.jpg",
                "Images/Reactions/Jotaro/kms.jpg",
                "Images/Reactions/Jotaro/like yare yare daze.jpg",
                "Images/Reactions/Jotaro/nut.jpg",
                "Images/Reactions/Jotaro/ok.jpg",
                "Images/Reactions/Jotaro/police calling intensifies.jpg",
                "Images/Reactions/Jotaro/punch anything.jpg",
                "Images/Reactions/Jotaro/shag platinum.jpg",
                "Images/Reactions/Jotaro/Shut up.jpg",
                "Images/Reactions/Jotaro/sweating.jpg",
                "Images/Reactions/Jotaro/yes yes yes.jpg"
            };

            joubinReacts = new string[]
            {
                "Images/Reactions/Joubin/angery.jpg"
            };

            kakyoinReacts = new string[]
            {
                "Images/Reactions/Kakyoin/badumtss.jpg",
                "Images/Reactions/Kakyoin/disgusted.jpg",
                "Images/Reactions/Kakyoin/enemy stand.jpg",
                "Images/Reactions/Kakyoin/I see.jpg",
                "Images/Reactions/Kakyoin/jotaro delet.jpg",
                "Images/Reactions/Kakyoin/kakyoin.jpg",
                "Images/Reactions/Kakyoin/lewd emotions.png",
                "Images/Reactions/Kakyoin/ok.jpg",
                "Images/Reactions/Kakyoin/prepare for memes.jpg",
                "Images/Reactions/Kakyoin/rero.png",
                "Images/Reactions/Kakyoin/screaming.jpg",
                "Images/Reactions/Kakyoin/sex your mom.jpg",
                "Images/Reactions/Kakyoin/smile.jpg"
            };

            kiraReacts = new string[]
            {
                "Images/Reactions/Kira/angery queen.jpg",
                "Images/Reactions/Kira/angry sha.jpg",
                "Images/Reactions/Kira/angry.jpg",
                "Images/Reactions/Kira/bait the dust.jpg",
                "Images/Reactions/Kira/boner.jpg",
                "Images/Reactions/Kira/delet.jpg",
                "Images/Reactions/Kira/duwang.jpg",
                "Images/Reactions/Kira/get sha.jpg",
                "Images/Reactions/Kira/heavy breathing.png",
                "Images/Reactions/Kira/i am the strong.jpg",
                "Images/Reactions/Kira/kq surprise.jpg",
                "Images/Reactions/Kira/pathetic.jpg",
                "Images/Reactions/Kira/press the trigger.gif",
                "Images/Reactions/Kira/pure disgust.jpg",
                "Images/Reactions/Kira/redo.jpg",
                "Images/Reactions/Kira/send hands.jpg",
                "Images/Reactions/Kira/third bomb.jpg",
                "Images/Reactions/Kira/yabai.jpg"
            };

            koichiReacts = new string[]
            {
                "Images/Reactions/Koichi/act 3.jpg",
                "Images/Reactions/Koichi/delicious.jpg",
                "Images/Reactions/Koichi/hol hirose.png",
                "Images/Reactions/Koichi/Koichi in love.png",
                "Images/Reactions/Koichi/long koichi.jpg",
                "Images/Reactions/Koichi/panic.jpg",
                "Images/Reactions/Koichi/secret bliss.jpg",
                "Images/Reactions/Koichi/smugichi/png",
                "Images/Reactions/Koichi/surprise.png"
            };

            mistaReacts = new string[]
            {
                "Images/Reactions/Mista/delet.jpg",
                "Images/Reactions/Mista/many mistas.jpg",
                "Images/Reactions/Mista/mista.jpg",
                "Images/Reactions/Mista/stop.jpg",
                "Images/Reactions/Mista/swap.jpg"
            };

            naranciaReacts = new string[]
            {
                "Images/Reactions/Narancia/delet.jpg"
            };

            norisukeReacts = new string[]
            {
                "Images/Reactions/Norisuke/Lol.png"
            };

            okuyasuReacts = new string[]
            {
                "Images/Reactions/Okuyasu/confused.png",
                "Images/Reactions/Okuyasu/cry.jpg",
                "Images/Reactions/Okuyasu/Crying.png",
                "Images/Reactions/Okuyasu/delet.jpg",
                "Images/Reactions/Okuyasu/happy.png",
                "Images/Reactions/Okuyasu/I feel you.jpg",
                "Images/Reactions/Okuyasu/josuke joy.jpg",
                "Images/Reactions/Okuyasu/smugyasu.jpg",
                "Images/Reactions/Okuyasu/tough.png",
                "Images/Reactions/Okuyasu/what.jpg"
            };

            pillarMenReacts = new string[]
            {
                "Images/Reactions/Pillar Men/Awaken.png",
                "Images/Reactions/Pillar Men/bliss.jpg",
                "Images/Reactions/Pillar Men/excellent response.jpg",
                "Images/Reactions/Pillar Men/i cannot be angered.jpg",
                "Images/Reactions/Pillar Men/laughing.jpg"
            };

            polnareffReacts = new string[]
            {
                "Images/Reactions/Polnareff/crying.jpg",
                "Images/Reactions/Polnareff/heart.jpg"
            };

            pucciReacts = new string[]
            {
                "Images/Reactions/Pucci/Attain heaven.jpg",
                "Images/Reactions/Pucci/Closer to heaven.jpg",
                "Images/Reactions/Pucci/fill your mouth.jpg",
                "Images/Reactions/Pucci/fucci.jpg",
                "Images/Reactions/Pucci/pucci.png",
                "Images/Reactions/Pucci/reset button.jpg",
                "Images/Reactions/Pucci/reset.jpg",
                "Images/Reactions/Pucci/slapped with lord.jpg"
            };

            rohanReacts = new string[]
            {
                "Images/Reactions/Rohan/calculating.jpg",
                "Images/Reactions/Rohan/cute rohan.png",
                "Images/Reactions/Rohan/I refuse.jpg",
                "Images/Reactions/Rohan/kishigay rohan.jpg",
                "Images/Reactions/Rohan/no nose smile.jpg",
                "Images/Reactions/Rohan/smughan.jpg",
                "Images/Reactions/Rohan/yabai.jpg",
                "Images/Reactions/Rohan/yamete.jpg"
            };

            shigechiReacts = new string[]
            {
                "Images/Reactions/Shigechi/Smugechi.jpg"
            };

            speedwagonReacts = new string[]
            {
                "Images/Reactions/Speedwagon/Afraid.jpg",
                "Images/Reactions/Speedwagon/cheering.jpg",
                "Images/Reactions/Speedwagon/shock.jpg",
                "Images/Reactions/Speedwagon/thumbs up.jpg"
            };

            vanillaIceReacts = new string[]
            {
                "Images/Reactions/Vanilla Ice/triggered.png"
            };

            yukakoReacts = new string[]
            {
                "Images/Reactions/Yukako/stupid.jpg"
            };

            zeppeliReacts = new string[]
            {
                "Images/Reactions/Zeppeli/Breads.png",
                "Images/Reactions/Zeppeli/how to hamon.png"
            };

            rand = new Random();

            discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            discord.UsingCommands(x =>
            {
                x.PrefixChar = '%';
                x.AllowMentionPrefix = true;
            });
            
            commands = discord.GetService<CommandService>();

            RegisterReactionCommand();
            RegisterGitCommand();
            RegisterReadMeCommand();
            RegisterDeletCommand();
            RegisterTriggeredCommand();
            RegisterSadCommand();
            RegisterJoyCommand();
            RegisterBonerCommand();
            RegisterNutCommand();
            RegisterForgotCommand();
            RegisterGayCommand();
            RegisterReroCommand();
            RegisterResetCommand();
            RegisterLoveCommand();
            RegisterRefuseCommand();
            RegisterKysCommand();
            RegisterKmsCommand();
            RegisterYesCommand();
            RegisterLitCommand();
            RegisterUnzipCommand();
            RegisterAngeryCommand();
            RegisterPoliceCommand();
            RegisterKakCommand();

            commands.CreateCommand("ora")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("Muda!");
                });

            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect("MjcyOTU1MTAyMjg3ODg4Mzk1.C2hhJQ.wMlnLoBWADm5OiuB_lat63LX2Hw", TokenType.Bot);
            });

        }

        private void RegisterReactionCommand()
        {
            commands.CreateCommand("react")
                .Parameter("CharacterForImage", ParameterType.Optional)
                .Do(async (e) =>
                {
                    string[] CharacterFolder = ChooseFolder(e.GetArg("CharacterForImage"));
                    int randomIndex = rand.Next(CharacterFolder.Length);
                    string reactToPost = CharacterFolder[randomIndex];
                    await e.Channel.SendFile(reactToPost);
                });
        }

        private void RegisterDeletCommand()
        {
            commands.CreateCommand("delet")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Mista/delet.jpg");
                });
        }

        private void RegisterTriggeredCommand()
        {
            commands.CreateCommand("triggered")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/triggered.png");
                });
        }

        private void RegisterSadCommand()
        {
            commands.CreateCommand("sad")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/cry.jpg");
                });
        }

        private void RegisterJoyCommand()
        {
            commands.CreateCommand("joy")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Josuke 4/Okuyasu Joy.jpg");
                });
        }

        private void RegisterBonerCommand()
        {
            commands.CreateCommand("boner")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Kira/boner.jpg");
                });
        }

        private void RegisterNutCommand()
        {
            commands.CreateCommand("nut")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Jotaro/nut.jpg");
                });
        }

        private void RegisterForgotCommand()
        {
            commands.CreateCommand("forgot")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Araki/I forgot.jpg");
                });
        }

        private void RegisterGayCommand()
        {
            commands.CreateCommand("gay")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Rohan/kishigay rohan.jpg");
                });
        }

        private void RegisterReroCommand()
        {
            commands.CreateCommand("rero")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Kakyoin/rero.png");
                });
        }

        private void RegisterKakCommand()
        {
            commands.CreateCommand("kak")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Kakyoin/kakyoin.jpg");
                });
        }

        private void RegisterYesCommand()
        {
            commands.CreateCommand("yes")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Jotaro/yes yes yes.jpg");
                });
        }

        private void RegisterLoveCommand()
        {
            commands.CreateCommand("love")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Polnareff/heart.jpg");
                });
        }

        private void RegisterResetCommand()
        {
            commands.CreateCommand("reset")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Pucci/reset button.jpg");
                });
        }

        private void RegisterRefuseCommand()
        {
            commands.CreateCommand("refuse")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Rohan/I refuse.jpg");
                });
        }

        private void RegisterKmsCommand()
        {
            commands.CreateCommand("kms")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Johnny/kms.png");
                });
        }

        private void RegisterKysCommand()
        {
            commands.CreateCommand("kys")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Johnny/kys.png");
                });
        }

        private void RegisterPoliceCommand()
        {
            commands.CreateCommand("police")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Jotaro/calling the police.jpg");
                });
        }

        private void RegisterLitCommand()
        {
            commands.CreateCommand("lit")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/it's lit.jpg");
                });
        }

        private void RegisterUnzipCommand()
        {
            commands.CreateCommand("unzip")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Bruno/unzips.jpg");
                });
        }

        private void RegisterAngeryCommand()
        {
            commands.CreateCommand("angery")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Images/Reactions/Diavolo/furious.jpg");
                });
        }

        private void RegisterGitCommand()
        {
            commands.CreateCommand("git")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://github.com/GuavaGuy/JojoBot");
                });
        }

        private void RegisterReadMeCommand()
        {
            commands.CreateCommand("info")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Info/READ_ME.txt");
                });
        }

        private string[] ChooseFolder(string charForReact)
        {
            if (charForReact.Equals("Akira", StringComparison.CurrentCultureIgnoreCase))
            {
                return akiraReacts;
            }
            else if (charForReact.Equals("Annasui", StringComparison.CurrentCultureIgnoreCase))
            {
                return annasuiReacts;
            }
            else if (charForReact.Equals("Araki", StringComparison.CurrentCultureIgnoreCase))
            {
                return arakiReacts;
            }
            else if (charForReact.Equals("Avdol", StringComparison.CurrentCultureIgnoreCase))
            {
                return avdolReacts;
            }
            else if (charForReact.Equals("Bruno", StringComparison.CurrentCultureIgnoreCase))
            {
                return brunoReacts;
            }
            else if (charForReact.Equals("Caesar", StringComparison.CurrentCultureIgnoreCase))
            {
                return caesarReacts;
            }
            else if (charForReact.Equals("Diavolo", StringComparison.CurrentCultureIgnoreCase))
            {
                return diavoloReacts;
            }
            else if (charForReact.Equals("Diego", StringComparison.CurrentCultureIgnoreCase))
            {
                return diegoReacts;
            }
            else if (charForReact.Equals("Dio", StringComparison.CurrentCultureIgnoreCase))
            {
                return dioReacts;
            }
            else if (charForReact.Equals("Valentine", StringComparison.CurrentCultureIgnoreCase))
            {
                return valentineReacts;
            }
            else if (charForReact.Equals("Giorno", StringComparison.CurrentCultureIgnoreCase))
            {
                return giornoReacts;
            }
            else if (charForReact.Equals("Gyro", StringComparison.CurrentCultureIgnoreCase))
            {
                return gyroReacts;
            }
            else if (charForReact.Equals("Hazamada", StringComparison.CurrentCultureIgnoreCase))
            {
                return hazamadaReacts;
            }
            else if (charForReact.Equals("HolHorse", StringComparison.CurrentCultureIgnoreCase))
            {
                return holHorseReacts;
            }
            else if (charForReact.Equals("Iggy", StringComparison.CurrentCultureIgnoreCase))
            {
                return iggyReacts;
            }
            else if (charForReact.Equals("Johnny", StringComparison.CurrentCultureIgnoreCase))
            {
                return johnnyReacts;
            }
            else if (charForReact.Equals("Jolyne", StringComparison.CurrentCultureIgnoreCase))
            {
                return jolyneReacts;
            }
            else if (charForReact.Equals("Jonathan", StringComparison.CurrentCultureIgnoreCase))
            {
                return jonathanReacts;
            }
            else if (charForReact.Equals("Joseph", StringComparison.CurrentCultureIgnoreCase))
            {
                return josephReacts;
            }
            else if (charForReact.Equals("Josuke4", StringComparison.CurrentCultureIgnoreCase) || charForReact.Equals("Josuke", StringComparison.CurrentCultureIgnoreCase))
            {
                return josuke4Reacts;
            }
            else if (charForReact.Equals("Josuke8", StringComparison.CurrentCultureIgnoreCase) || charForReact.Equals("Gappy", StringComparison.CurrentCultureIgnoreCase))
            {
                return josuke8Reacts;
            }
            else if (charForReact.Equals("Jotaro", StringComparison.CurrentCultureIgnoreCase))
            {
                return jotaroReacts;
            }
            else if (charForReact.Equals("Joubin", StringComparison.CurrentCultureIgnoreCase) || charForReact.Equals("Jobin", StringComparison.CurrentCultureIgnoreCase))
            {
                return joubinReacts;
            }
            else if (charForReact.Equals("Kakyoin", StringComparison.CurrentCultureIgnoreCase))
            {
                return kakyoinReacts;
            }
            else if (charForReact.Equals("Kira", StringComparison.CurrentCultureIgnoreCase))
            {
                return kiraReacts;
            }
            else if (charForReact.Equals("Koichi", StringComparison.CurrentCultureIgnoreCase))
            {
                return koichiReacts;
            }
            else if (charForReact.Equals("Mista", StringComparison.CurrentCultureIgnoreCase))
            {
                return mistaReacts;
            }
            else if (charForReact.Equals("Narancia", StringComparison.CurrentCultureIgnoreCase))
            {
                return naranciaReacts;
            }
            else if (charForReact.Equals("Norisuke", StringComparison.CurrentCultureIgnoreCase))
            {
                return norisukeReacts;
            }
            else if (charForReact.Equals("Okuyasu", StringComparison.CurrentCultureIgnoreCase))
            {
                return okuyasuReacts;
            }
            else if (charForReact.Equals("PillarMen", StringComparison.CurrentCultureIgnoreCase))
            {
                return pillarMenReacts;
            }
            else if (charForReact.Equals("Polnareff", StringComparison.CurrentCultureIgnoreCase))
            {
                return polnareffReacts;
            }
            else if (charForReact.Equals("Pucci", StringComparison.CurrentCultureIgnoreCase))
            {
                return pucciReacts;
            }
            else if (charForReact.Equals("Rohan", StringComparison.CurrentCultureIgnoreCase))
            {
                return rohanReacts;
            }
            else if (charForReact.Equals("Shigechi", StringComparison.CurrentCultureIgnoreCase))
            {
                return shigechiReacts;
            }
            else if (charForReact.Equals("Speedwagon", StringComparison.CurrentCultureIgnoreCase))
            {
                return speedwagonReacts;
            }
            else if (charForReact.Equals("VanillaIce", StringComparison.CurrentCultureIgnoreCase))
            {
                return vanillaIceReacts;
            }
            else if (charForReact.Equals("Yukako", StringComparison.CurrentCultureIgnoreCase))
            {
                return yukakoReacts;
            }
            else if (charForReact.Equals("Zeppeli", StringComparison.CurrentCultureIgnoreCase))
            {
                return zeppeliReacts;
            }
            else
            {
                return generalReacts;
            }
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
