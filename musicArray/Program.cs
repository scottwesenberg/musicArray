using System;
using System.Drawing;

namespace movies
{
    class Program
    {
        enum Genre
        {
            HipHop,
            Pop,
            Jazz,
            Rock,
            Classical
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            //public Music(string title, string artist, string album, string length, Genre genre)
            //{
            //    Title = title;
            //    Artist = artist;
            //    Album = album;
            //    Length = length;
            //    Genre = genre;
            //}
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public string Display()
            {
                return "Title: " + Title +
                    "\nArtist: " + Artist +
                    "\nAlbum: " + Album +
                    "\nLength: " + Length +
                    "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to add?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("What is the title of the song?");
                    collection[i].setTitle(Console.ReadLine());

                    Console.WriteLine("Who is the artist of the song?");
                    collection[i].setArtist(Console.ReadLine());

                    Console.WriteLine("What is the album name?");
                    collection[i].setAlbum(Console.ReadLine());

                    Console.WriteLine("What is the length of the song?");
                    collection[i].setLength(Console.ReadLine());

                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("H.) Hip-Hop\nP.) Pop\nJ.) Jazz\nR.) Rock\nC.) Classical");
                    Genre tempGenre = Genre.Rock;
                    char sel = char.Parse(Console.ReadLine());
                    switch (sel)
                    {
                        case 'H':
                            collection[i].setGenre(Genre.HipHop);
                            break;
                        case 'P':
                            collection[i].setGenre(Genre.Pop);
                            break;
                        case 'J':
                            collection[i].setGenre(Genre.Jazz);
                            break;
                        case 'R':
                            collection[i].setGenre(Genre.Rock);
                            break;
                        case 'C':
                            collection[i].setGenre(Genre.Classical);
                            break;
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
            }
        }
    }
}