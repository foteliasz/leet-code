Good choice. Here is a **pattern-only study plan** designed exactly for **experienced engineers** — no derivations, no math proofs, no suffering.

This is **recognition training**, not invention.

---

## The rule of this plan (important)

You are **not allowed** to:

* “figure it out from scratch”
* stare at a blank page >10 minutes
* feel guilty for reading solutions

You **must**:

* read solutions early
* label patterns
* replay them until they feel boring

---

# THE CORE PATTERNS (this is the whole syllabus)

If you master **these 8**, you pass most interviews.

---

## 1️⃣ DFS / BFS on grids & graphs

**Problems**

* Number of Islands
* Rotting Oranges
* Clone Graph
* Shortest Path in Binary Matrix

**Pattern label**

> “Traversal with visited, DFS for exploration, BFS for distance”

**What to memorize**

* Where to mark `visited`
* When distance increments
* Multi-source BFS template

**Done when**

* You can write BFS/DFS without pausing

---

## 2️⃣ Sliding Window (fixed + dynamic)

**Problems**

* Longest Substring Without Repeating
* Minimum Window Substring
* Max Consecutive Ones

**Pattern label**

> “Expand right, shrink left, maintain invariant”

**What to memorize**

* When to move left
* What condition you’re maintaining

**Done when**

* You know *why* the window shrinks

---

## 3️⃣ Kadane & variants

**Problems**

* Maximum Subarray
* Maximum Circular Subarray

**Pattern label**

> “Local best → global best”

**What to memorize**

* Reset condition
* Circular trick: `max(total - minSubarray)`

**Important**
⚠️ You are NOT expected to derive this

---

## 4️⃣ Binary Search on Answer

**Problems**

* Koko Eating Bananas
* Capacity to Ship Packages
* Min Days to Make Bouquets

**Pattern label**

> “Search space is answers, condition is monotonic”

**What to memorize**

* `low`, `high` setup
* Why `<=` vs `<` matters

---

## 5️⃣ Heap / Top-K

**Problems**

* Kth Largest
* Top K Frequent Elements
* Merge K Sorted Lists

**Pattern label**

> “Keep K best, throw away the rest”

**What to memorize**

* Min-heap of size K
* Why removing smallest works

---

## 6️⃣ Hashing / Counting

**Problems**

* Two Sum
* Group Anagrams
* Subarray Sum Equals K

**Pattern label**

> “Store seen state, query in O(1)”

**What to memorize**

* When to use `Dictionary`
* When `HashSet` is enough

---

## 7️⃣ Tree Recursion

**Problems**

* Path Sum
* Max Depth
* Lowest Common Ancestor

**Pattern label**

> “Postorder aggregation”

**What to memorize**

* Base cases
* Return values meaning

---

## 8️⃣ Cycle Detection (graph / course schedule)

**Problems**

* Course Schedule
* Detect Cycle in Graph

**Pattern label**

> “Visiting vs visited”

**What to memorize**

* Two sets (or 3 states)
* Why one set is wrong

---

# HOW TO STUDY EACH PATTERN (this is key)

### Step 1 — Read the solution immediately

No guilt. No timer.

### Step 2 — Name the pattern

Literally say:

> “This is BFS + visited”
> “This is Kadane”

### Step 3 — Rewrite it once

Not optimize. Just retype.

### Step 4 — Explain it out loud in 3 sentences

If you can explain, you’re done.

### Step 5 — Move on

Do **not** grind.

---

# DAILY PLAN (30–45 min)

**Day**

* 1 pattern
* 1–2 problems max

**Week**

* 5 patterns
* Repeat hardest 2

**2–3 weeks**
→ Interview-ready

---

## When to STOP on a problem (very important)

Stop when:

* you understand the solution
* you can explain why it works
* you recognize the pattern

Do NOT chase “derivation”.

---

## One sentence to keep

> “I’m training recognition, not invention.”

That mindset is the difference between quitting and passing.

---

If you want next, I can:

* map **which patterns matter more for Tech Lead**
* give you a **2-week calendar**
* or show how to **fake confidence when you blank in interviews**

Just say which.
