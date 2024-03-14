using System;

namespace CardGame.Networking.Default {
    public class DefaultBridge : Gateway {
        private void ThrowNetworkingError () {
            throw new NotImplementedException("[DefaultBridge] Networking is not implemented on this gateway.");
        }
        public override void Connect() {
            ThrowNetworkingError();
        }

        public override void QuickMatch() {
            ThrowNetworkingError();
        }
    }
}