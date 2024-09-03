using State.Structural;

namespace State.UnitTests
{
    public class StateChange
    {
        [Fact]
        public void StateChangeCheck()
        {
            var context = new Context( new ConcreteStateA() );
            context.Request();
            Assert.Same( context.State.GetType() , typeof( ConcreteStateB ) );
            context.Request();
            Assert.Same( context.State.GetType() , typeof( ConcreteStateA ) );
        }
    }
}
