<template>
  <div>
    <form @submit.prevent="create" action="/assets/inc/sendemail.php">
      <div class="form-group container">
        <div class="row">
          <div class="col">
            <label for="FullNameArm">Full Name in Armenian</label>
            <input v-model="createData.FullNameArm" type="text" id="FullNameArm" placeholder="Full name in Armenian" name="FullNameArm">
          </div>

          <div class="col">
            <label for="FullNameEng">Full name in English</label>
            <input v-model="createData.FullNameEng" type="text" id="FullNameEng" placeholder="Full name in English" name="FullNameEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="PositionArm">Position in Armenian</label>
            <input v-model="createData.PositionArm" type="text" id="PositionArm" placeholder="Position in Armenian" name="PositionArm">
          </div>

          <div class="col">
            <label for="PositionEng">Position in English</label>
            <input v-model="createData.PositionEng" type="text" id="PositionEng" placeholder="Position in English" name="PositionEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="TextArm">Text in Armenian</label>
            <textarea rows="4" cols="50" v-model="createData.TextArm" id="TextArm" placeholder="Text in Armenian" name="TextArm"></textarea>
          </div>

          <div class="col">
            <label for="TextEng">Text in English</label>
            <textarea rows="4" cols="50" v-model="createData.TextEng" id="TextEng" placeholder="Text in English" name="TextEng"></textarea>
          </div>
        </div>

        <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
      </div>
    </form><!-- /.become-teacher__form-content -->
  </div>
</template>

<script>
  import https from 'https';
  export default {
    name: 'CreateTestimonial',
    setup() {
      return {
        createData: { FullNameArm: '', FullNameEng: '', PositionArm: '', PositionEng: '', TextArm: '', TextEng: '' },
      };
    },
    methods: {
      async create() {
        try {
          await this.$axios.post('/api/Testimonials/Create', this.createData)
          // Show success message
            .then(function (response) {
              if (response) {
                window.location = "/admin/testimonial/list"
              }
            })
            .catch(function (error) {

            })
        } catch (error) {
          // Handle error and display message
        }
      },
    },
    created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
  }
</script>

<style scoped>
  .form-group {
    margin-bottom: 20px;
  }

  .row {
    display: flex;
    justify-content: space-between;
    margin-bottom: 10px;
  }

  .col {
    flex: 0 0 48%; /* Adjust the width as needed */
  }

  label {
    display: block;
    margin-bottom: 5px;
    font-weight: bold;
  }

  input,
  textarea,
  select {
    width: 100%;
    padding: 8px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
    margin-top: 5px;
  }
</style>
