using State.Structural;

namespace State.UnitTests
{
    public class StateChange2
    {
        [Fact]
        public void StateChangeCheck()
        {
            var context = new Context( new ConcreteStateB() );
            context.Request();
            Assert.Same( context.State.GetType() , typeof( ConcreteStateA ) );
            context.Request();
            Assert.Same( context.State.GetType() , typeof( ConcreteStateB ) );
        }
    }
}
