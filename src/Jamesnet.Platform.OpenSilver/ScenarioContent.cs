using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Jamesnet.Platform.OpenSilver;

/// <summary>
/// Represents a single case in the content switcher
/// </summary>
public class ContentCase : DependencyObject
{
    public static readonly DependencyProperty SourceValueProperty =
        DependencyProperty.Register(
            nameof(SourceValue),
            typeof(object),
            typeof(ContentCase),
            new PropertyMetadata(null));

    public static readonly DependencyProperty MatchValueProperty =
        DependencyProperty.Register(
            nameof(MatchValue),
            typeof(object),
            typeof(ContentCase),
            new PropertyMetadata(null));

    public static readonly DependencyProperty CaseContentProperty =
        DependencyProperty.Register(
            nameof(CaseContent),
            typeof(object),
            typeof(ContentCase),
            new PropertyMetadata(null));

    /// <summary>
    /// Gets or sets the source value to compare against
    /// </summary>
    public object SourceValue
    {
        get => GetValue(SourceValueProperty);
        set
        {
            Console.WriteLine($"ContentCase - Setting SourceValue: {value}");
            SetValue(SourceValueProperty, value);
        }
    }

    /// <summary>
    /// Gets or sets the value to match against the source
    /// </summary>
    public object MatchValue
    {
        get => GetValue(MatchValueProperty);
        set => SetValue(MatchValueProperty, value);
    }

    /// <summary>
    /// Gets or sets the content to display when values match
    /// </summary>
    public object CaseContent
    {
        get => GetValue(CaseContentProperty);
        set => SetValue(CaseContentProperty, value);
    }
}

/// <summary>
/// A control that switches its content based on value matching
/// </summary>
public class ContentSwitcher : ContentControl
{
    private readonly ObservableCollection<ContentCase> _cases = new();

    public static readonly DependencyProperty CasesProperty =
        DependencyProperty.Register(
            nameof(Cases),
            typeof(ObservableCollection<ContentCase>),
            typeof(ContentSwitcher),
            new PropertyMetadata(null));

    /// <summary>
    /// Gets the collection of content cases
    /// </summary>
    public ObservableCollection<ContentCase> Cases
    {
        get => (ObservableCollection<ContentCase>)GetValue(CasesProperty);
        private set => SetValue(CasesProperty, value);
    }

    public ContentSwitcher()
    {
        Cases = _cases;
        Cases.CollectionChanged += Cases_CollectionChanged;
        this.DataContextChanged += ContentSwitcher_DataContextChanged;
        DefaultStyleKey = typeof(ContentSwitcher);
    }

    private void ContentSwitcher_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
        foreach (var contentCase in Cases)
        {
            SetBinding(contentCase);
        }
        UpdateActiveContent();
    }

    private void Cases_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.NewItems != null)
        {
            foreach (ContentCase newCase in e.NewItems)
            {
                SetBinding(newCase);
            }
        }
        UpdateActiveContent();
    }

    private void SetBinding(ContentCase contentCase)
    {
        if (this.DataContext != null)
        {
            var binding = new Binding();
            binding.Source = DataContext;
            binding.Path = new PropertyPath("IconType");

            BindingOperations.SetBinding(contentCase, ContentCase.SourceValueProperty, binding);
        }
    }

    private void UpdateActiveContent()
    {
        Console.WriteLine($"UpdateActiveContent - Current Cases count: {Cases.Count}");
        Console.WriteLine($"UpdateActiveContent - DataContext: {DataContext}");

        foreach (var contentCase in Cases)
        {
            var sourceValue = contentCase.SourceValue;
            var matchValue = contentCase.MatchValue;

            Console.WriteLine($"Comparing values:");
            Console.WriteLine($"  Source Value: '{sourceValue}' ({sourceValue?.GetType()?.FullName ?? "null"})");
            Console.WriteLine($"  Match Value: '{matchValue}' ({matchValue?.GetType()?.FullName ?? "null"})");

            if (Equals(sourceValue, matchValue))
            {
                Console.WriteLine($"Match found! Setting Content to: {contentCase.CaseContent}");
                Content = contentCase.CaseContent;
                return;
            }
        }
        Console.WriteLine("No matching case found, setting Content to null");
        Content = null;
    }
}