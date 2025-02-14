using AltV.Net.Events;

namespace AltV.Net
{
    public static partial class Alt
    {
        public static event CheckpointDelegate OnCheckpoint
        {
            add => Module.CheckpointEventHandler.Add(value);
            remove => Module.CheckpointEventHandler.Remove(value);
        }

        /// <summary>
        /// Player connect event handler
        /// <example>
        /// <code>
        /// Alt.OnPlayerConnect += (player, reason) => {
        ///   Console.WriteLine($"{player.Name} connected.");
        /// };
        /// </code>
        /// </example>
        /// </summary>
        public static event PlayerConnectDelegate OnPlayerConnect
        {
            add => Module.PlayerConnectEventHandler.Add(value);
            remove => Module.PlayerConnectEventHandler.Remove(value);
        }

        public static event PlayerBeforeConnectDelegate OnPlayerBeforeConnect
        {
            add => Module.PlayerBeforeConnectEventHandler.Add(value);
            remove => Module.PlayerBeforeConnectEventHandler.Remove(value);
        }

        public static event ResourceEventDelegate OnAnyResourceStart
        {
            add => Module.ResourceStartEventHandler.Add(value);
            remove => Module.ResourceStartEventHandler.Remove(value);
        }

        public static event ResourceEventDelegate OnAnyResourceStop
        {
            add => Module.ResourceStopEventHandler.Add(value);
            remove => Module.ResourceStopEventHandler.Remove(value);
        }

        public static event ResourceEventDelegate OnAnyResourceError
        {
            add => Module.ResourceErrorEventHandler.Add(value);
            remove => Module.ResourceErrorEventHandler.Remove(value);
        }

        public static event PlayerDamageDelegate OnPlayerDamage
        {
            add => Module.PlayerDamageEventHandler.Add(value);
            remove => Module.PlayerDamageEventHandler.Remove(value);
        }

        public static event PlayerDeadDelegate OnPlayerDead
        {
            add => Module.PlayerDeadEventHandler.Add(value);
            remove => Module.PlayerDeadEventHandler.Remove(value);
        }

        public static event ExplosionDelegate OnExplosion
        {
            add => Module.ExplosionEventHandler.Add(value);
            remove => Module.ExplosionEventHandler.Remove(value);
        }

        /// <summary>
        /// Weapon damage event handler
        /// <example>
        /// <code>
        /// Alt.OnWeaponDamage += (player, target, weapon, damage, shotOffset, bodyPart) => {
        ///   Console.WriteLine($"{player.Name} got damaged.");
        ///   return true; // return false will cancel the weapon damage event and player won't receive damage.
        /// };
        /// </code>
        /// </example>
        /// </summary>
        public static event WeaponDamageDelegate OnWeaponDamage
        {
            add => Module.WeaponDamageEventHandler.Add(value);
            remove => Module.WeaponDamageEventHandler.Remove(value);
        }

        public static event PlayerDisconnectDelegate OnPlayerDisconnect
        {
            add => Module.PlayerDisconnectEventHandler.Add(value);
            remove => Module.PlayerDisconnectEventHandler.Remove(value);
        }

        public static event PlayerRemoveDelegate OnPlayerRemove
        {
            add => Module.PlayerRemoveEventHandler.Add(value);
            remove => Module.PlayerRemoveEventHandler.Remove(value);
        }

        public static event VehicleRemoveDelegate OnVehicleRemove
        {
            add => Module.VehicleRemoveEventHandler.Add(value);
            remove => Module.VehicleRemoveEventHandler.Remove(value);
        }

        public static event PlayerChangeVehicleSeatDelegate OnPlayerChangeVehicleSeat
        {
            add => Module.PlayerChangeVehicleSeatEventHandler.Add(value);
            remove => Module.PlayerChangeVehicleSeatEventHandler.Remove(value);
        }

        public static event PlayerEnterVehicleDelegate OnPlayerEnterVehicle
        {
            add => Module.PlayerEnterVehicleEventHandler.Add(value);
            remove => Module.PlayerEnterVehicleEventHandler.Remove(value);
        }

        public static event PlayerEnteringVehicleDelegate OnPlayerEnteringVehicle
        {
            add => Module.PlayerEnteringVehicleEventHandler.Add(value);
            remove => Module.PlayerEnteringVehicleEventHandler.Remove(value);
        }

        public static event PlayerLeaveVehicleDelegate OnPlayerLeaveVehicle
        {
            add => Module.PlayerLeaveVehicleEventHandler.Add(value);
            remove => Module.PlayerLeaveVehicleEventHandler.Remove(value);
        }

        public static event PlayerClientEventDelegate OnPlayerEvent
        {
            add => Module.PlayerClientEventEventHandler.Add(value);
            remove => Module.PlayerClientEventEventHandler.Remove(value);
        }

        public static event PlayerClientCustomEventDelegate OnPlayerCustomEvent
        {
            add => Module.PlayerClientCustomEventEventHandler.Add(value);
            remove => Module.PlayerClientCustomEventEventHandler.Remove(value);
        }

        public static event ServerEventEventDelegate OnServerEvent
        {
            add => Module.ServerEventEventHandler.Add(value);
            remove => Module.ServerEventEventHandler.Remove(value);
        }

        public static event ServerCustomEventEventDelegate OnServerCustomEvent
        {
            add => Module.ServerCustomEventEventHandler.Add(value);
            remove => Module.ServerCustomEventEventHandler.Remove(value);
        }

        public static event ConsoleCommandDelegate OnConsoleCommand
        {
            add => Module.ConsoleCommandEventHandler.Add(value);
            remove => Module.ConsoleCommandEventHandler.Remove(value);
        }

        /// <summary>
        /// Event that is invoked when the meta data of an entity has changed.
        /// </summary>
        /// <remarks>Meta data is accessible across different serverside resources.</remarks>
        public static event MetaDataChangeDelegate OnMetaDataChange
        {
            add => Module.MetaDataChangeEventHandler.Add(value);
            remove => Module.MetaDataChangeEventHandler.Remove(value);
        }

        /// <summary>
        /// Event that is invoked when the synced meta data of an entity has changed.
        /// </summary>
        /// <remarks>Synced meta data is accessible across different serverside resources and to all clients without range limitation.</remarks>
        public static event MetaDataChangeDelegate OnSyncedMetaDataChange
        {
            add => Module.SyncedMetaDataChangeEventHandler.Add(value);
            remove => Module.SyncedMetaDataChangeEventHandler.Remove(value);
        }

        public static event ColShapeDelegate OnColShape
        {
            add => Module.ColShapeEventHandler.Add(value);
            remove => Module.ColShapeEventHandler.Remove(value);
        }

        public static event VehicleDestroyDelegate OnVehicleDestroy
        {
            add => Module.VehicleDestroyEventHandler.Add(value);
            remove => Module.VehicleDestroyEventHandler.Remove(value);
        }

        public static event FireDelegate OnFire
        {
            add => Module.FireEventHandler.Add(value);
            remove => Module.FireEventHandler.Remove(value);
        }

        public static event StartProjectileDelegate OnStartProjectile
        {
            add => Module.StartProjectileEventHandler.Add(value);
            remove => Module.StartProjectileEventHandler.Remove(value);
        }

        public static event PlayerWeaponChangeDelegate OnPlayerWeaponChange
        {
            add => Module.PlayerWeaponChangeEventHandler.Add(value);
            remove => Module.PlayerWeaponChangeEventHandler.Remove(value);
        }

        public static event NetOwnerChangeDelegate OnNetworkOwnerChange
        {
            add => Module.NetOwnerChangeEventHandler.Add(value);
            remove => Module.NetOwnerChangeEventHandler.Remove(value);
        }

        public static event VehicleAttachDelegate OnVehicleAttach
        {
            add => Module.VehicleAttachEventHandler.Add(value);
            remove => Module.VehicleAttachEventHandler.Remove(value);
        }

        public static event VehicleDetachDelegate OnVehicleDetach
        {
            add => Module.VehicleDetachEventHandler.Add(value);
            remove => Module.VehicleDetachEventHandler.Remove(value);
        }

        public static event VehicleDamageDelegate OnVehicleDamage
        {
            add => Module.VehicleDamageEventHandler.Add(value);
            remove => Module.VehicleDamageEventHandler.Remove(value);
        }
        
        public static event ConnectionQueueAddDelegate OnConnectionQueueAdd
        {
            add => Module.ConnectionQueueAddHandler.Add(value);
            remove => Module.ConnectionQueueAddHandler.Remove(value);
        }
        
        public static event ConnectionQueueRemoveDelegate OnConnectionQueueRemove
        {
            add => Module.ConnectionQueueRemoveHandler.Add(value);
            remove => Module.ConnectionQueueRemoveHandler.Remove(value);
        }
    }
}