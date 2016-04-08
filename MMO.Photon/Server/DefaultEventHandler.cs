using MMO.Photon.Application;

namespace MMO.Photon.Server
{
	public abstract class DefaultEventHandler : PhotonServerHandler
	{
		protected DefaultEventHandler(PhotonApplication application) : base(application) { }
	}
}
