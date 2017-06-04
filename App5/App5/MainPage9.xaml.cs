using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage9 : ContentPage
	{
        private const string Url = "http://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
	    private ObservableCollection<Post> _posts;

        public MainPage9 ()
		{
			InitializeComponent ();
		}

	    protected override async void OnAppearing()
	    {
	       var content= await _client.GetStringAsync(Url);
	       var posts = JsonConvert.DeserializeObject<List<Post>>(content);
            _posts = new ObservableCollection<Post>(posts);
	        postsListView.ItemsSource = _posts;


	        base.OnAppearing();
	    }

	    async void OnAdd(object sender, System.EventArgs e)
	    {
	        var post = new Post {Title = "Title" + DateTime.Now.Ticks};
	        _posts.Insert(0, post);

            var content = JsonConvert.SerializeObject(post);
	       await _client.PostAsync(Url, new StringContent(content));

          
	    }

	    async void OnUpdate(object sender, System.EventArgs e)
	    {
	       var post = _posts[0];
	        post.Title += " Updated";

	        var content = JsonConvert.SerializeObject(post);
	        await _client.PutAsync(Url + "/" + post.Id, new StringContent(content));
        }

	    async void OnDelete(object sender, System.EventArgs e)
	    {
	        var post = _posts[0];

	        _posts.Remove(post);

	       await _client.DeleteAsync(Url + "/" + post.Id);
	    }
    }
}