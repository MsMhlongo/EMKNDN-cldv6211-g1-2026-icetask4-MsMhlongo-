using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Collections.Generic;
using System.Linq;

namespace MvcMovie.Controllers;
public class GamesController : Controller
{
    private static List<Game> _games = new();
    private static int _nextId = 1;

    public IActionResult Index() => View(_games);

    public IActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Game game)
    {
        if (ModelState.IsValid)
        {
            game.Id = _nextId++;
            _games.Add(game);
            return RedirectToAction(nameof(Index));
        }
        return View(game);
    }

    public IActionResult Edit(int id)
    {
        var game = _games.FirstOrDefault(g => g.Id == id);
        if (game == null) return NotFound();
        return View(game);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Game game)
    {
        if (id != game.Id) return NotFound();
        if (ModelState.IsValid)
        {
            var index = _games.FindIndex(g => g.Id == id);
            _games[index] = game;
            return RedirectToAction(nameof(Index));
        }
        return View(game);
    }

    public IActionResult Delete(int id)
    {
        var game = _games.FirstOrDefault(g => g.Id == id);
        if (game == null) return NotFound();
        return View(game);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var game = _games.FirstOrDefault(g => g.Id == id);
        if (game != null) _games.Remove(game);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Details(int id)
    {
        var game = _games.FirstOrDefault(g => g.Id == id);
        if (game == null) return NotFound();
        return View(game);
    }
}
