using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//下列範例示範如何以 C# 表示上圖所示範的類別關聯性
public class WorkItem
{
    private static int currentID;
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string Description { get; set; }
    protected TimeSpan jobLength { get; set; }
    public WorkItem()
    {
        ID = 0;
        Title = "Default title";
        Description = "Default description.";
        jobLength = new TimeSpan();
    }
    //初始化WorkItem(有傳入值)
    public WorkItem(string title, string descr, TimeSpan jobLen)
    {
        this.ID = GetNextID();
        this.Title = title;
        this.Description = descr;
        this.jobLength = jobLen;
    }
    static WorkItem()
    {
        currentID = 0;
    }
    protected int GetNextID()
    {
        return ++currentID;
    }
    public void Update(string title, TimeSpan jobLen)
    {
        this.Title = title;
        this.jobLength = jobLen;
    }
    public override string ToString()
    {
        return String.Format("{0} - {1}", this.ID, this.Title);
    }

}
public class ChangeRequest : WorkItem
{
    protected int originalItemID { get; set; }
    public ChangeRequest() { }

    public ChangeRequest(string title, string desc, TimeSpan jobLen, int originalID)
    {
        this.ID = GetNextID();
        this.Title = title;
        this.Description = desc;
        this.jobLength = jobLen;

        this.originalItemID = originalID;
    }

}
namespace test_40
{
    class Program
    {
        static void Main(string[] args)
        {
             WorkItem item = new WorkItem("Fix Bugs",
                                         "Fix all bugs in my code branch",
                                         new TimeSpan(3, 4, 0, 0));
            ChangeRequest change = new ChangeRequest("Change Base Class Design",
                                                     "Add members to the class",
                                                      new TimeSpan(4, 0, 0),
                                                      1);
            Console.WriteLine(item.ToString());

            change.Update("Change the Design of the Base Class",new TimeSpan(4,0,0,0));

            Console.WriteLine(change.ToString());

            Console.ReadKey();


        }
    }
}
