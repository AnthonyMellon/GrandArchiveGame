using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GACardImporter : CardImporter
{
    public List<Card> cards = new List<Card>();

    [MenuItem("CardGame/GetJSON")]
    private void ImportCards()
    {
        APIManager.DownloadJSON(1);
    }
}
public class Meta
{
    public int page { get; set; }
    public int total_cards { get; set; }
    public int paginated_cards_count { get; set; }
    public int page_size { get; set; }
    public bool has_more { get; set; }
    public int total_pages { get; set; }
    public string sort { get; set; }
    public string order { get; set; }
}
