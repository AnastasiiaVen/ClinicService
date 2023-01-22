using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// ДОМАШНЯЯ РАБОТА: разработать методы тестирования контроллера PetController:
/// Обновление данных UpdateTest
/// Получение данных (по всем животным) GetAllTest
/// Получение данных (по конкретному животному) GetByIdTest
/// </summary>


namespace ClinicServiceTests
{
    public class PetControllerTests
    {
        private PetController _petController;

        public PetControllerTests() 
        {
            _petController = new PetController();
        }

        [Fact]
        public void PetCreateBadRequestTest()
        {

            CreatePetRequest createPetRequest = new CreatePetRequest();
            createPetRequest.Name = "П";
            createPetRequest.Birthday = DateTime.Now.AddYears(-55);
            createPetRequest.ClientId = 1;

            ActionResult<int> operationResult = _petController.Create(createPetRequest);

            int expectedOperationValue = 0;

            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)operationResult.Result).Value);

        }

        [Fact]
        public void PetCreateTest()
        {
            // МЕТОД ТЕСТИРОВАНИЯ СОСТОИТ ИЗ УСЛОВНЫХ 3 ЧАСТЕЙ

            // [1] Подготовка данных для тестирования
            CreatePetRequest createPetRequest = new CreatePetRequest();
            createPetRequest.Name = "Персик";
            createPetRequest.Birthday = DateTime.Now.AddYears(-15);
            createPetRequest.ClientId = 1;

            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _petController.Create(createPetRequest);


            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 1;

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((OkObjectResult)operationResult.Result).Value);

        }

        [Fact]
        public void PetUpdateBadRequestTest()
        {
            UpdatePetRequest updatePetRequest = new UpdatePetRequest();
            updatePetRequest.Name = "То";
            updatePetRequest.Birthday = DateTime.Now.AddDays(-100);
            updatePetRequest.ClientId = 2;

            ActionResult<int> operationResult = _petController.Update(updatePetRequest);

            int expectedOperationValue = 0;

            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)(operationResult.Result)).Value);

        }

       [Fact]
        public void PetUpdateTest()
        {
            UpdatePetRequest updatePetRequest = new UpdatePetRequest();
            updatePetRequest.Name = "Тошка";
            updatePetRequest.Birthday = DateTime.Now.AddDays(-10);
            updatePetRequest.ClientId = 2;

            ActionResult<int> operationResult = _petController.Update(updatePetRequest);

            int expectedOperationValue = 1;
            Assert.IsType<OkObjectResult> (operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((OkObjectResult)operationResult.Result).Value);
        }


        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-50)]
        public void DeletePetBadRequestTest(int petId)
        {

            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _petController.Delete(petId);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 0;

            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)operationResult.Result).Value);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(50)]
        [InlineData(100)]
        public void DeletePetTest(int petId)
        {

            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _petController.Delete(petId);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 1;

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((OkObjectResult)operationResult.Result).Value);
        }

        [Fact]
        public void GetAllPetsTest()
        {
            ActionResult<List<Pet>> operationResult = _petController.GetAll();

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<List<Pet>>(((OkObjectResult)operationResult.Result).Value);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(50)]
        [InlineData(100)]
        public void GetByIdPetTest(int petId)
        {
            ActionResult<Pet> operationResult = _petController.GetById(petId);

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<Pet>(((OkObjectResult)operationResult.Result).Value);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void GetByIdPetBadRequestTest(int petId)
        {
            ActionResult<Pet> operationResult = _petController.GetById(petId);

            int expectedOperationValue = 0;

            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)operationResult.Result).Value);
        }
    }

    
}
