using WpfApp;
using Xunit;

namespace UnitTest;

public class UnitTest1
{
    [Fact]
    public void TestIncrement()
    {
        var vm = new MainViewModel
        {
            Counter = 5
        };

        vm.Increment();
        Assert.Equal(6, vm.Counter);
    }

    [Fact]
    public void TestDecrement()
    {
        var vm = new MainViewModel
        {
            Counter = 5
        };

        vm.Decrement();
        Assert.Equal(4, vm.Counter);
    }

    [Fact]
    public void TestSquare()
    {
        var vm = new MainViewModel
        {
            Counter = 5
        };

        vm.Square();
        Assert.Equal(25, vm.Counter);
    }
}