#ifndef QUASAR_BLE_H
#define QUASAR_BLE_H

#include <Particle.h>
#include <memory>

#include "QTypes.h"
#include "QBleUuids.h"

namespace Quasar
{
    // Data recieved callbacks via BLE
    void TimeDataReceived(const uint8_t* pData, size_t len, const BlePeerDevice& peer, void* pContext);
    void DateDataReceived(const uint8_t* pData, size_t len, const BlePeerDevice& peer, void* pContext);

    struct BleData
    {
        #pragma region Date and time service

        BleUuid DateAndTimeService;

        BleCharacteristic TimeCharacteristic;
        BleCharacteristic DateCharacteristic;

        #pragma endregion

        #pragma region Device info service  

        BleUuid DeviceInfoService;

        BleCharacteristic DeviceGenerationCharacteristic;
        BleCharacteristic DeviceTypeCharacteristic;

        #pragma endregion

        #pragma region Gesture service  

        BleUuid GestureService;
        BleCharacteristic GestureCharacteristic;

        #pragma endregion

        BleData()
            : DateAndTimeService(Uuid::DateAndTimeService),
              TimeCharacteristic("time", BleCharacteristicProperty::WRITE_WO_RSP, Uuid::TimeCharacteristic, Uuid::DateAndTimeService, TimeDataReceived, (void*)Uuid::TimeCharacteristic),
              DateCharacteristic("date", BleCharacteristicProperty::WRITE_WO_RSP, Uuid::DateCharacteristic, Uuid::DateAndTimeService, DateDataReceived, (void*)Uuid::DateCharacteristic),
              
              GestureService(Uuid::GestureService),
              GestureCharacteristic("gesture", BleCharacteristicProperty::NOTIFY, Uuid::GestureCharacteristic, GestureService),

              DeviceInfoService(Uuid::DeviceInfoService),
              DeviceGenerationCharacteristic("generation", BleCharacteristicProperty::READ, Uuid::DeviceGenerationCharacteristic, DeviceInfoService),
              DeviceTypeCharacteristic("type", BleCharacteristicProperty::READ, Uuid::DeviceTypeCharacteristic, DeviceInfoService)
        {
            
        }
    };

    void InitBle();
    SharedInstance<BleData> GetBleData();

    void SetGestureChar(void* pData, size_t size);
}

#endif