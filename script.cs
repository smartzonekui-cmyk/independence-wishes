document.getElementById('nameForm').addEventListener('submit', function(e) {
  e.preventDefault();
  const name = document.getElementById('userName').value.trim();
  if (name) {
    const wishText = `${name}, আপনাকে স্বাধীনতা দিবসের অনেক শুভেচ্ছা!`;
    document.getElementById('wishText').textContent = wishText;
    document.getElementById('bannerSection').classList.remove('hidden');
  }
});

document.getElementById('shareBtn').addEventListener('click', function() {
  const bannerText = document.getElementById('wishText').textContent + " 🇮🇳";
  if (navigator.share) {
    navigator.share({
      title: 'স্বাধীনতা দিবস শুভেচ্ছা',
      text: bannerText,
      url: window.location.href
    }).catch(err => console.log('Sharing failed:', err));
  } else {
    alert("আপনার ব্রাউজার শেয়ার সাপোর্ট করে না।");
  }
});
