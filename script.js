const languages = ['C++', 'C#', 'Java', 'PHP', 'HTML', 'CSS', 'JavaScript'];
const tools = ['Visual Studio', 'VS Code', 'Git', 'GitHub', 'Figma', 'Canva', 'Microsoft Office'];

const projects = [
  {
    name: 'Binary Calculator',
    language: 'C++',
    category: 'Console Application',
    description: '[NEEDS VERIFICATION — source code not yet inspected]. Unable to confirm features without reviewing the source.',
    skills: ['Basic algorithms', 'Console I/O', 'Control structures', 'Binary arithmetic'],
    repo: '[ADD LINK]',
    demo: '[ADD LINK]'
  },
  {
    name: 'Enrollment System',
    language: 'C#',
    category: 'Desktop Application / Academic Project',
    description: 'C# Windows Forms academic project with role-based login (Student/Admin/Faculty), student dashboard for 8 courses, faculty subject schedule, and admin CRUD for student records. All data stored in-memory with no database persistence.',
    skills: ['Windows Forms', 'Event-driven programming', 'Multi-form navigation', 'ListView/DataGridView', 'In-memory CRUD', 'Role-based routing'],
    repo: '[ADD LINK]',
    demo: '[ADD LINK]'
  },
  {
    name: 'GENTLEMAN',
    language: 'Java',
    category: 'Java / OOP Academic Project',
    description: 'Java Swing POS desktop application built with NetBeans GUI Builder featuring login/sign-up, 11-item product catalog, shopping cart with JTable, payment processing, and receipt printing. No data persistence; hardcoded absolute image paths limit portability.',
    skills: ['Swing GUI', 'Inheritance', 'Encapsulation', 'Event-driven programming', 'JTable/DefaultTableModel', 'DecimalFormat', 'Form navigation'],
    repo: '[ADD LINK]',
    demo: '[ADD LINK]'
  }
];

const learning = [
  'Programming fundamentals (C++, C#, Java)',
  'Web development (HTML, CSS, JavaScript, PHP)',
  'Software engineering concepts',
  'Git/GitHub workflow',
  'Project documentation',
  'Clean and maintainable code'
];

const mindset = `Software development is a continuous process of learning, building, making mistakes, and improving. I don't expect to get things right the first time — I expect to debug, refactor, and understand why something works (or doesn't). Each project teaches me something I couldn't learn from tutorials alone. The goal is progress, not perfection.`;

function renderChips(items, containerId) {
  const container = document.getElementById(containerId);
  if (!container) return;
  container.innerHTML = items.map(item => `<span class="chip">${item}</span>`).join('');
}

function renderProjects() {
  const grid = document.getElementById('project-grid');
  if (!grid) return;

  grid.innerHTML = projects.map(p => {
    const isPlaceholder = p.repo.startsWith('[');
    const repoLink = isPlaceholder ? 
      `<a class="project-link placeholder" href="#" aria-disabled="true" tabindex="-1">VIEW REPOSITORY</a>` :
      `<a class="project-link" href="${p.repo}" target="_blank" rel="noopener">VIEW REPOSITORY</a>`;
    const demoLink = p.demo.startsWith('[') ? 
      `<a class="project-link placeholder" href="#" aria-disabled="true" tabindex="-1">VIEW DEMO</a>` :
      `<a class="project-link" href="${p.demo}" target="_blank" rel="noopener">VIEW DEMO</a>`;

    return `
      <article class="project-card">
        <h3>${p.name}</h3>
        <div class="project-meta">
          <span class="project-tag">${p.language}</span>
          <span class="project-tag">${p.category}</span>
        </div>
        <p>${p.description}</p>
        <div class="project-skills">
          ${p.skills.map(s => `<span class="skill-tag">${s}</span>`).join('')}
        </div>
        <div class="project-links">
          ${repoLink}
          ${demoLink}
        </div>
      </article>
    `;
  }).join('');
}

function renderLearning() {
  const list = document.getElementById('learning-list');
  if (!list) return;
  list.innerHTML = learning.map(item => `<li>${item}</li>`).join('');
}

function renderMindset() {
  const el = document.getElementById('mindset-text');
  if (!el) return;
  el.innerHTML = mindset;
}

function init() {
  renderChips(languages, 'lang-chips');
  renderChips(tools, 'tool-chips');
  renderProjects();
  renderLearning();
  renderMindset();
  initMobileNav();
}

function initMobileNav() {
  const toggle = document.querySelector('.nav-toggle');
  const menu = document.querySelector('.nav-links');
  if (!toggle || !menu) return;

  toggle.addEventListener('click', () => {
    const expanded = toggle.getAttribute('aria-expanded') === 'true';
    toggle.setAttribute('aria-expanded', !expanded);
    menu.classList.toggle('open');
  });

  menu.querySelectorAll('a').forEach(link => {
    link.addEventListener('click', () => {
      menu.classList.remove('open');
      toggle.setAttribute('aria-expanded', 'false');
    });
  });

  document.addEventListener('click', (e) => {
    if (!toggle.contains(e.target) && !menu.contains(e.target)) {
      menu.classList.remove('open');
      toggle.setAttribute('aria-expanded', 'false');
    }
  });
}

if (document.readyState === 'loading') {
  document.addEventListener('DOMContentLoaded', init);
} else {
  init();
}