// UI-only interactions: no data logic, just toggling classes.

document.addEventListener("DOMContentLoaded", () => {
  // Mobile nav toggle
  document.querySelectorAll("[data-nav-toggle]").forEach((btn) => {
    btn.addEventListener("click", () => {
      document.querySelector(".nav-links")?.classList.toggle("nav-open");
    });
  });

  // Generic tab groups: [data-tabs] wraps [data-tab] buttons + [data-tab-panel] panels
  document.querySelectorAll("[data-tabs]").forEach((group) => {
    const buttons = group.querySelectorAll("[data-tab]");
    buttons.forEach((btn) => {
      btn.addEventListener("click", () => {
        const target = btn.getAttribute("data-tab");
        buttons.forEach((b) => b.classList.remove("active"));
        btn.classList.add("active");
        group.querySelectorAll("[data-tab-panel]").forEach((panel) => {
          panel.classList.toggle("hidden", panel.getAttribute("data-tab-panel") !== target);
        });
      });
    });
  });

  // Chip toggle groups (catalog filters)
  document.querySelectorAll(".chip-row").forEach((row) => {
    row.querySelectorAll(".chip").forEach((chip) => {
      chip.addEventListener("click", () => chip.classList.toggle("active"));
    });
  });

  // Sidebar active link highlight is set per-page via .active class in HTML
});
