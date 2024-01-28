using Microsoft.AspNetCore.Mvc;
using Novo_Hotel.Models;


namespace Novo_Hotel
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            using var _context = new Novo_HotelContext();
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<Cliente> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.Clientes.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Clientes.FirstOrDefault(i => i.ClienteID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] Cliente cliente)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Clientes.FirstOrDefault(i => i.ClienteID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(cliente);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Clientes.FirstOrDefault(i => i.ClienteID == id);
            if (item == null)
            {
                return;
            }
            _context.Clientes.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class ContaController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Conta conta)
        {
            using var _context = new Novo_HotelContext();
            _context.Contas.Add(conta);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<Conta> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.Contas.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Contas.FirstOrDefault(i => i.ContaID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] Conta conta)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Contas.FirstOrDefault(i => i.ContaID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(conta);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Contas.FirstOrDefault(i => i.ContaID == id);
            if (item == null)
            {
                return;
            }
            _context.Contas.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class EnderecoController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Endereco endereco)
        {
            using var _context = new Novo_HotelContext();
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<Endereco> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.Enderecos.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Enderecos.FirstOrDefault(i => i.EnderecoID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] Endereco endereco)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Enderecos.FirstOrDefault(i => i.EnderecoID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(endereco);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Enderecos.FirstOrDefault(i => i.EnderecoID == id);
            if (item == null)
            {
                return;
            }
            _context.Enderecos.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class FilialController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Filial filial)
        {
            using var _context = new Novo_HotelContext();
            _context.Filiais.Add(filial);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<Filial> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.Filiais.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Filiais.FirstOrDefault(i => i.FilialID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] Filial filial)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Filiais.FirstOrDefault(i => i.FilialID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(filial);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Filiais.FirstOrDefault(i => i.FilialID == id);
            if (item == null)
            {
                return;
            }
            _context.Filiais.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class FuncionarioController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Funcionario funcionario)
        {
            using var _context = new Novo_HotelContext();
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<Funcionario> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.Funcionarios.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Funcionarios.FirstOrDefault(i => i.FuncionarioID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] Funcionario funcionario)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Funcionarios.FirstOrDefault(i => i.FuncionarioID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(funcionario);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Funcionarios.FirstOrDefault(i => i.FuncionarioID == id);
            if (item == null)
            {
                return;
            }
            _context.Funcionarios.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class ItemController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Item item)
        {
            using var _context = new Novo_HotelContext();
            _context.Itens.Add(item);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<Item> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.Itens.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Itens.FirstOrDefault(i => i.ItemID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] Item item)
        {
            using var _context = new Novo_HotelContext();
            var item_especifico = _context.Itens.FirstOrDefault(i => i.ItemID == id);
            if (item_especifico == null)
            {
                return;
            }
            _context.Entry(item_especifico).CurrentValues.SetValues(item);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Itens.FirstOrDefault(i => i.ItemID == id);
            if (item == null)
            {
                return;
            }
            _context.Itens.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class ItemConsumidoController : Controller
    {
        [HttpPost]
        public void Post([FromBody] ItemConsumido itemConsumido)
        {
            using var _context = new Novo_HotelContext();
            _context.ItensConsumidos.Add(itemConsumido);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<ItemConsumido> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.ItensConsumidos.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.ItensConsumidos.FirstOrDefault(i => i.ItemConsumidoId == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] ItemConsumido itemConsumido)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.ItensConsumidos.FirstOrDefault(i => i.ItemConsumidoId == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(item);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.ItensConsumidos.FirstOrDefault(i => i.ItemConsumidoId == id);
            if (item == null)
            {
                return;
            }
            _context.ItensConsumidos.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class LavanderiaController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Lavanderia lavanderia)
        {
            using var _context = new Novo_HotelContext();
            _context.Lavanderias.Add(lavanderia);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<Lavanderia> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.Lavanderias.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Lavanderias.FirstOrDefault(i => i.LavanderiaID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] Lavanderia lavanderia)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Lavanderias.FirstOrDefault(i => i.LavanderiaID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(lavanderia);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Lavanderias.FirstOrDefault(i => i.LavanderiaID == id);
            if (item == null)
            {
                return;
            }
            _context.Lavanderias.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class PagamentoController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Pagamento pagamento)
        {
            using var _context = new Novo_HotelContext();
            _context.Pagamentos.Add(pagamento);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<Pagamento> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.Pagamentos.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Pagamentos.FirstOrDefault(i => i.PagamentoID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] Pagamento pagamento)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Pagamentos.FirstOrDefault(i => i.PagamentoID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(pagamento);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Pagamentos.FirstOrDefault(i => i.PagamentoID == id);
            if (item == null)
            {
                return;
            }
            _context.Pagamentos.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class QuartoController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Quarto quarto)
        {
            using var _context = new Novo_HotelContext();
            _context.Quartos.Add(quarto);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<Quarto> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.Quartos.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Quartos.FirstOrDefault(i => i.QuartoID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] Quarto quarto)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Quartos.FirstOrDefault(i => i.QuartoID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(quarto);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Quartos.FirstOrDefault(i => i.QuartoID == id);
            if (item == null)
            {
                return;
            }
            _context.Quartos.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class ReservaController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Reserva reserva)
        {
            using var _context = new Novo_HotelContext();
            _context.Reservas.Add(reserva);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<Reserva> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.Reservas.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Reservas.FirstOrDefault(i => i.ReservaID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] Reserva reserva)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Reservas.FirstOrDefault(i => i.ReservaID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(reserva);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.Reservas.FirstOrDefault(i => i.ReservaID == id);
            if (item == null)
            {
                return;
            }
            _context.Reservas.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class ServicoLavanderiaController : Controller
    {
        [HttpPost]
        public void Post([FromBody] ServicoLavanderia servicoLavanderia)
        {
            using var _context = new Novo_HotelContext();
            _context.ServicosLavanderia.Add(servicoLavanderia);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<ServicoLavanderia> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.ServicosLavanderia.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.ServicosLavanderia.FirstOrDefault(i => i.ServicoLavanderiaID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] ServicoLavanderia servicoLavanderia)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.ServicosLavanderia.FirstOrDefault(i => i.ServicoLavanderiaID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(servicoLavanderia);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.ServicosLavanderia.FirstOrDefault(i => i.ServicoLavanderiaID == id);
            if (item == null)
            {
                return;
            }
            _context.ServicosLavanderia.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class TipoFuncionarioController : Controller
    {
        [HttpPost]
        public void Post([FromBody] TipoFuncionario tipoFuncionario)
        {
            using var _context = new Novo_HotelContext();
            _context.TiposFuncionario.Add(tipoFuncionario);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<TipoFuncionario> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.TiposFuncionario.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.TiposFuncionario.FirstOrDefault(i => i.TipoFuncionarioID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] TipoFuncionario tipoFuncionario)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.TiposFuncionario.FirstOrDefault(i => i.TipoFuncionarioID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(tipoFuncionario);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.TiposFuncionario.FirstOrDefault(i => i.TipoFuncionarioID == id);
            if (item == null)
            {
                return;
            }
            _context.TiposFuncionario.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class TipoPagamentoController : Controller
    {
        [HttpPost]
        public void Post([FromBody] TipoPagamento tipoPagamento)
        {
            using var _context = new Novo_HotelContext();
            _context.TiposPagamento.Add(tipoPagamento);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<TipoPagamento> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.TiposPagamento.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.TiposPagamento.FirstOrDefault(i => i.TipoPagamentoID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] TipoPagamento tipoPagamento)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.TiposPagamento.FirstOrDefault(i => i.TipoPagamentoID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(tipoPagamento);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.TiposPagamento.FirstOrDefault(i => i.TipoPagamentoID == id);
            if (item == null)
            {
                return;
            }
            _context.TiposPagamento.Remove(item);
            _context.SaveChanges();
        }
    }

    [Route("[controller]")]
    public class TipoQuartoController : Controller
    {
        [HttpPost]
        public void Post([FromBody] TipoQuarto tipoQuarto)
        {
            using var _context = new Novo_HotelContext();
            _context.TiposQuarto.Add(tipoQuarto);
            _context.SaveChanges();
        }

        [HttpGet]
        public List<TipoQuarto> Get()
        {
            using var _context = new Novo_HotelContext();
            return _context.TiposQuarto.ToList();
        }
        [HttpGet("ver/{id}")]
        public IActionResult Get(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.TiposQuarto.FirstOrDefault(i => i.TipoQuartoID == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPut("atualizar/{id}")]
        public void Put(int id,[FromBody] TipoQuarto tipoQuarto)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.TiposQuarto.FirstOrDefault(i => i.TipoQuartoID == id);
            if (item == null)
            {
                return;
            }
            _context.Entry(item).CurrentValues.SetValues(tipoQuarto);
            _context.SaveChanges();
        }
        [HttpDelete("deletar/{id}")]
        public void Delete(int id)
        {
            using var _context = new Novo_HotelContext();
            var item = _context.TiposQuarto.FirstOrDefault(i => i.TipoQuartoID == id);
            if (item == null)
            {
                return;
            }
            _context.TiposQuarto.Remove(item);
            _context.SaveChanges();
        }
    }

    

}