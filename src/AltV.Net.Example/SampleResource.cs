using System.Collections.Generic;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;

namespace AltV.Net.Example
{
    public class SampleResource : IResource
    {
        public void OnStart()
        {
            Alt.On<string>("test", s => { Alt.Log("test=" + s); });
            Alt.On("test", args => { Alt.Log("args=" + args[0]); });
            Alt.Emit("test", "bla");
            Alt.On("bla", bla);
            Alt.On<string>("bla2", bla2);
            Alt.On<string, bool>("bla3", bla3);
            Alt.On<string, string>("bla4", bla4);
            Alt.On<MyVehicle>("vehicleTest", myVehicle => { Alt.Server.LogInfo("myData: " + myVehicle.MyData); });

            Alt.OnPlayerConnect += OnPlayerConnect;
            Alt.OnPlayerDisconnect += OnPlayerDisconnect;
            Alt.OnEntityRemove += OnEntityRemove;

            var vehicle = Alt.CreateVehicle(VehicleHash.Apc, Position.Zero, float.MinValue);
            vehicle.PrimaryColor = 7;

            Alt.Emit("vehicleTest", vehicle);

            Alt.On("event_name",
                delegate(string s, string s1, long i1, string[] arg3, object[] arg4, MyVehicle arg5,
                    Dictionary<string, object> arg6, MyVehicle[] myVehicles, string probablyNull)
                {
                    Alt.Server.LogInfo("bla:" + ((object[]) arg4[1])[0]);
                    Alt.Server.LogInfo("myData-2: " + arg5.Position.x + " " + arg5.MyData);
                    Alt.Server.LogInfo("myData-4: " + myVehicles[0].Position.x + " " + myVehicles[0].MyData);
                    Alt.Server.LogInfo("myData-3: " + arg6["test"]);
                    Alt.Server.LogInfo("null?" + (probablyNull == null ? "y" : "n"));
                });

            Alt.Emit("event_name", "param_string_1", "param_string_2", 1, new[] {"array_1", "array_2"},
                new object[] {"test", new[] {1337}}, vehicle,
                new Dictionary<string, object>
                {
                    ["test"] = "test"//,
                    //["test2"] = new Dictionary<string, long> {["test"] = 1},
                    //["test3"] = new Dictionary<string, long> {["test"] = 42}
                },
                new MyVehicle[] {(MyVehicle) vehicle}, null);

            vehicle.Remove();
        }

        public void OnStop()
        {
        }

        public IVehicleFactory GetVehicleFactory()
        {
            return new MyVehicleFactory();
        }

        private void OnPlayerConnect(IPlayer player, string reason)
        {
        }

        private void OnPlayerDisconnect(IPlayer player, string reason)
        {
            var readOnlyPlayer = player.Copy();
            //Do async processing here even when player got already removed
        }

        private void OnEntityRemove(IEntity entity)
        {
        }

        public void bla()
        {
        }

        public void bla2(string test)
        {
        }

        public bool bla3(string test)
        {
            return true;
        }

        public void bla4(string test, string test2)
        {
        }
    }
}