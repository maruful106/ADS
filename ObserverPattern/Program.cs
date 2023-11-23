using System;
using System.Collections.Generic;

// Observer interface
public interface IObserver
{
    void Update(string news);
}

// Subject class
public class NewspaperAgency
{
    private List<IObserver> subscribers = new List<IObserver>();
    private string latestNews;

    public void Attach(IObserver subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void Detach(IObserver subscriber)
    {
        subscribers.Remove(subscriber);
    }

    public void NotifyObservers()
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update(latestNews);
        }
    }

    public void PublishNews(string news)
    {
        latestNews = news;
        NotifyObservers();
    }
}

// ConcreteObserver class
public class Subscriber : IObserver
{
    private string name;

    public Subscriber(string name)
    {
        this.name = name;
    }

    public void Update(string news)
    {
        Console.WriteLine($"{name} received the latest news: {news}");
    }
}

class Program
{
    static void Main()
    {
        // Create a newspaper agency (subject)
        NewspaperAgency newspaperAgency = new NewspaperAgency();

        // Create subscribers (observers)
        Subscriber subscriber1 = new Subscriber("Subscriber 1");
        Subscriber subscriber2 = new Subscriber("Subscriber 2");

        // Subscribers subscribe to the newspaper agency
        newspaperAgency.Attach(subscriber1);
        newspaperAgency.Attach(subscriber2);

        // Newspaper agency publishes news
        newspaperAgency.PublishNews("Breaking News: Observer Pattern Explained!");

        // Output:
        // Subscriber 1 received the latest news: Breaking News: Observer Pattern Explained!
        // Subscriber 2 received the latest news: Breaking News: Observer Pattern Explained!
    }
}
