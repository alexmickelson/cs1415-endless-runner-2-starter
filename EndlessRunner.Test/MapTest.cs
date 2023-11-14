
using System.Text;

public class MapTest
{
  [Test]
  public void TestBlankMap()
  {
    var expected = new StringBuilder("|  |  |  |  |" + Environment.NewLine);
    expected.Append("|  |  |  |  |" + Environment.NewLine);
    expected.Append("|  |  |  |  |" + Environment.NewLine);
    expected.Append("|  |😀|  |  |" + Environment.NewLine);

    var map = new Map();
    Assert.AreEqual(expected.ToString(), map.ToString());
  }

  [Test]
  public void TestNewRowMap()
  {
    var expected = new StringBuilder("|🧱|🧱|  |  |" + Environment.NewLine);
    expected.Append("|  |  |  |  |" + Environment.NewLine);
    expected.Append("|  |  |  |  |" + Environment.NewLine);
    expected.Append("|  |😀|  |  |" + Environment.NewLine);

    var map = new Map();
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Blank, Icon.Blank });
    Assert.AreEqual(expected.ToString(), map.ToString());
  }

  [Test]
  public void TestDeath()
  {
    var expected = new StringBuilder("|🧱|🧱|  |  |" + Environment.NewLine);
    expected.Append("|🧱|🧱|  |  |" + Environment.NewLine);
    expected.Append("|🧱|🧱|  |  |" + Environment.NewLine);
    expected.Append("|🧱|💀|  |  |" + Environment.NewLine);

    var map = new Map();
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Blank, Icon.Blank });
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Blank, Icon.Blank });
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Blank, Icon.Blank });
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Blank, Icon.Blank });
    Assert.AreEqual(expected.ToString(), map.ToString());
  }
}