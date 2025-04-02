
using System;
using static System.Console;
using System.Media;
using System.Windows;
using System.Drawing;
using System.Xml.Serialization;
using POEP1;
namespace POEP1
{
    public class Program
    {
        static void Main(string[] args)


        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer Welcome = new SoundPlayer("PoeVoice.wav");
                Welcome.Load();
                Welcome.Play();
                Welcome.PlayLooping();
                Console.ReadKey();

                bool showMenu = true;
                while (showMenu)
                {
                    showMenu = true;
                    MainMenu();
                }
            }
        }
        static List<string> menu = new List<string>();
        static List<string> options = new List<string>();


        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose a topic of your choice");
            Console.WriteLine("1) Phishing");
            Console.WriteLine("2) Malware");
            Console.WriteLine("3) Ransomware");
            Console.WriteLine("4) Password and authentication");
            Console.WriteLine("EXIT");
            Console.Write("\r\nSelect an option: ");

            string input = Console.ReadLine();


            switch (Console.ReadLine())
            {
                case "1":
                    PHISHING();
                    return true;
                case "2":
                    MALWARE();
                    return true;
                case "3":
                    RANSOMWARE();
                    return true;
                case "4":
                    PasswordAndAuthentication();
                    return false;
                default:
                    return true;
            }
        }

        private static string PHISHING()
        {
            Console.Write("Phishing is a type of attack and scam often used to steal user data. This is done by manipulating the user into opening a bogus email or link which can resulting in the installtions of currupt Malware such as viruses,adware etc.");
            return Console.ReadLine();
        }


        private static string MALWARE()
        {
            Console.Write("Malware refers to any type of malicious software designed to harm or exploit a computer system. Malware can be spread in many different ways such as through email, infected software downloads, infected websites and usb drives.");
            return Console.ReadLine();
        }

        private static string RANSOMWARE()
        {
            Console.Write("Ransomware is a type of malware that encrypts a victim's files or locks their device and demands a aransom in exchange for the decryption key or unlock code. They are usually spread during phishing emails, drive-by downloads and infected software.");
            return Console.ReadLine();
        }

        private static string PasswordAndAuthentication()
        {
            Console.Write("These are very crucial components of cybersecurity, ensuring that only authorized individuals can access sensistive information and systems. There are three types of authentication: Single-Factor-which uses one factor, such as a password or pin. Multi-Factor-which requires two or more factors, like apassword, fingerprint, and one-time password(otp). And lastly Two-Factor Authentication(2FA)-A type of MFA that uses two factors.");
            return Console.ReadLine();
            Console.Clear();

            char[] charArray;
            object value = DisplayResult(String.Concat(charArray));
        }

        private static object DisplayResult(string v)
        {
            throw new NotImplementedException();
        }

    } }
        /*

        string[] imagePaths = {
                "image.jpg"

            };

            Bitmap[] images = new Bitmap[imagePaths.Length];

            for (int i = 0; i < imagePaths.Length; i++)
            {
                try
                {
                    images[i] = new Bitmap(imagePaths[i]);
                    Console.WriteLine($"Loaded image: {imagePaths[i]}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Loading: {imagePaths[i]}: {ex.Message}");
                }
            }
            foreach (var img in images)
            {
                if (img != null)
                {
                    Console.WriteLine($"ASCII representation of {img.Width}x{img.Height} image:");

                    Bitmap grayscaleImage = ConvertToGrayscale(img);

                    DisplayImageAsASCII(grayscaleImage);
                }
            }
            Console.WriteLine("Press exit");
            Console.ReadKey();
        }

    private static BitMap ConvertToGrayscale(Bitmap original)
    {
        Bitmap grayscale = new Bitmap(original.Width, original.Height);

        for (int x = 0; x < original.Width; x++)
        {
            for (int y = 0; y < original.Height; y++)
            {
                Color pixelColor = original.GetPixel(x, y);
                int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                grayscale.SetPixel(x, y, grayColor);
            }
        }
        return grayscale;
    }

    static void DisplayImageASCII(Bitmap img)
    {
        string asciiChars = "@%#*+=-:. ";
        for (int y = 0; y < img.Height; y += 6)
        {
            for (int x = 0; x < img.Width; x += 3)
            {
                Color pixel = img.GetPixel(x, y);
                int GrayValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                char asciiChar = asciiChars[GrayValue * (asciiChars.Length - 1) / 255];
                Console.WriteLine(asciiChar);
            }
            Console.WriteLine();
        }
    }
        */

        
        
   
        


  
    



   