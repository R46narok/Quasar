#include "QBle.h"


#include <memory>

namespace Quasar
{
    static auto s_BleData = CreateSharedInstance<BleData>();

    void InitBle()
    {
        BLE.on();

        BLE.addCharacteristic(s_BleData->TimeCharacteristic);
        BLE.addCharacteristic(s_BleData->DateCharacteristic);
        BLE.addCharacteristic(s_BleData->GestureCharacteristic);
        BLE.addCharacteristic(s_BleData->DeviceGenerationCharacteristic);
        BLE.addCharacteristic(s_BleData->DeviceTypeCharacteristic);


        BleAdvertisingData advData;
        advData.appendLocalName("gen1qwatch");

        advData.appendServiceUUID(s_BleData->DateAndTimeService);
        advData.appendServiceUUID(s_BleData->GestureService);
        advData.appendServiceUUID(s_BleData->DeviceInfoService);

        BLE.advertise(&advData);
            
    }

    SharedInstance<BleData> GetBleData()
    {
        return s_BleData;
    }

    void SetGestureChar(void* pData, size_t size)
    {
        s_BleData->GestureCharacteristic.setValue((uint8_t*) pData, size);
    }
}